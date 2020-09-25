using SchoolManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class GroupRepository : IGroupRepository
    {
        private readonly ApplicationDbContext _context;
        public GroupRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Group getGroup(int id)
        {
            if (GroupExists(id))
            {
                return this.GetAllGroup().Where(g => g.Id == id).FirstOrDefault();
            }
            return null;
        }

        public IEnumerable<Group> GetAllGroup()
        {
            return _context.Group.ToList();
        }

        public int RemoveGroup(int id)
        {
            Group g = _context.Group.Find(id);
            if (g != null)
            {
                _context.Group.Remove(g);
            }
            try
            {
                var res = _context.SaveChanges();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<int> SaveGroup(Group group)
        {
            if (group.Id == 0)
            {

                _context.Group.Add(group);
            }
            else
            {
                Group g = _context.Group.Find(group.Id);

                if (g != null)
                {
                    //Update that SubjectGroup
                    g.GroupName = group.GroupName;

                    _context.Group.Update(g);
                }
            }
            try
            {
                var result = _context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool GroupExists(int id)
        {
            return _context.Group.Any(e => e.Id == id);
        }
    }
}
