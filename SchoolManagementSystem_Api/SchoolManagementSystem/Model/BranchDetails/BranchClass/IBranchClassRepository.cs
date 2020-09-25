using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public interface IBranchClassRepository
    {
        public Task<IEnumerable<BranchClass>> GetBranchClass();
        public Task<BranchClass> GetBranchClass(int id);
        public Task<BranchClass> UpdateBranchClass(int id, BranchClass classRoom);
        public Task<BranchClass> CreateBranchClass(BranchClass classRoom);
        public Task<BranchClass> DeleteBranchClass(int id);
    }
}
