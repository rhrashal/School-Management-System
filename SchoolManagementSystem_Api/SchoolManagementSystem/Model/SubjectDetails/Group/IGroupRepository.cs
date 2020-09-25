using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public interface IGroupRepository
    {
        IEnumerable<Group> GetAllGroup();
        Group getGroup(int id);
        int RemoveGroup(int id);
        Task<int> SaveGroup(Group group);
    }
}
