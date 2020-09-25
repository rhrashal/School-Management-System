using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class BranchClassRepository : IBranchClassRepository
    {
        private readonly ApplicationDbContext _context;
        public BranchClassRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<BranchClass>> GetBranchClass()
        {
            if (_context != null)
            {
                return await _context.BranchClass.ToListAsync();
            }
            return null;
        }

        public async Task<BranchClass> GetBranchClass(int id)
        {
            if (BranchClassExists(id))
            {
                var BranchClass = await _context.BranchClass.FindAsync(id);
                return BranchClass;
            }
            return null;

        }
        public async Task<BranchClass> CreateBranchClass(BranchClass BranchClass)
        {
            if (BranchClass.Id == 0)
            {
                _context.BranchClass.Add(BranchClass);
            }
            try
            {
                await _context.SaveChangesAsync();
                return BranchClass;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<BranchClass> UpdateBranchClass(int id, BranchClass BranchClass)
        {
            BranchClass clr = _context.BranchClass.Find(BranchClass.Id);

            if (clr != null)
            {
                //Update that educationSystem
                clr.BranchId = BranchClass.BranchId;
                clr.SchoolClassId = BranchClass.SchoolClassId;

                _context.BranchClass.Update(clr);
            }
            try
            {
                var result = await _context.SaveChangesAsync();
                return BranchClass;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<BranchClass> DeleteBranchClass(int id)
        {
            var clr = await _context.BranchClass.FindAsync(id);
            if (clr != null)
            {
                _context.BranchClass.Remove(clr);
            }
            try
            {
                var res = await _context.SaveChangesAsync();
                return clr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool BranchClassExists(int id)
        {
            return _context.ClassRoom.Any(e => e.Id == id);
        }
    }
}
