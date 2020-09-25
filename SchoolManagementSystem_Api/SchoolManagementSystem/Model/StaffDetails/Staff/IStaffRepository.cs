using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public interface IStaffRepository
    {

        Task< IEnumerable<Staff>> GetAllStaff();

        Task<Staff> GetStaff(int id);

        Task<Staff> SaveStaff(Staff staff);

        Task<Staff> DeleteStaff(int id);

        bool StaffExists(int id);

        IEnumerable<Staff> GetStaffForBranch(int BranchId); 

        IEnumerable<Staff> GetAllStaffByDesignation(int BranchId, int DesignatonId);
        //Kawsar
        public Task<Staff> EditStaffProfile(int id, Staff staff);
    }
}
