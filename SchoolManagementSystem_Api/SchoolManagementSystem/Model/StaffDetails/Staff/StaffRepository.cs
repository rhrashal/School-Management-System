using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class StaffRepository : IStaffRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _rollManager;
        public StaffRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> rollManager)
        {
            _context = context;
            _userManager = userManager;
            _rollManager = rollManager;
        }

        public async Task<IEnumerable<Staff>> GetAllStaff()
        {
            if(_context.Staff.Count() != 0)
            {
                return await _context.Staff.ToListAsync();
            }
            return null;
        }

        public async Task<Staff> GetStaff(int id)
        {
            if (StaffExists(id))
            {
                return await _context.Staff.FindAsync(id);
            }
            return null;
        }

        public async Task<Staff> SaveStaff(Staff staff)
        {

            if (staff.Id == 0)
            {
                try
                {
                    ApplicationUser user = new ApplicationUser()
                    {
                        Email = staff.Email,
                        UserName = staff.Email
                    };
                    IdentityResult result = await _userManager.CreateAsync(user, staff.ConfirmPassword);
                    if (!result.Succeeded)
                    {
                        return null;
                    }
                    else
                    {
                        _context.Staff.Add(staff);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                var oldStaff = _context.Staff.Where(w => w.Id == staff.Id).FirstOrDefault();
                if (staff.Email != null)
                {
                    ApplicationUser userStaff = _context.Users.Where(w => w.Email == oldStaff.Email).FirstOrDefault();
                    if (userStaff != null)
                    {
                        userStaff.Email = staff.Email;
                        userStaff.UserName = staff.Email;
                    };
                    IdentityResult result = await _userManager.UpdateAsync(userStaff);
                    if (!result.Succeeded)
                    {
                        return null;
                    }

                }
                if (oldStaff != null)
                {
                    oldStaff.FirstName = staff.FirstName;
                    oldStaff.LastName = staff.LastName;
                    oldStaff.DateOfBirth = staff.DateOfBirth;
                    oldStaff.Gender = staff.Gender;
                    oldStaff.Religion = staff.Religion;
                    oldStaff.PhoneNo = staff.PhoneNo;
                    oldStaff.NationalIdNo = staff.NationalIdNo;

                    if (staff.Email != null)
                    {
                        oldStaff.Email = staff.Email;
                    }
                    if (staff.ImageUrl != null)
                    {
                        oldStaff.ImageUrl = staff.ImageUrl;
                    }                    
                    oldStaff.FathersName = staff.FathersName;
                    oldStaff.MothersName = staff.MothersName;
                    oldStaff.MaritalStatus = staff.MaritalStatus;
                    oldStaff.IsPresent = staff.IsPresent;
                    oldStaff.PresentAddress = staff.PresentAddress;
                    oldStaff.ParmanentAddress = staff.ParmanentAddress;
                    oldStaff.JoiningDate = staff.JoiningDate;
                    oldStaff.ResignDate = staff.ResignDate;
                    oldStaff.CreatedDate = staff.CreatedDate;
                    oldStaff.BranchId = staff.BranchId;
                    oldStaff.DesignationId = staff.DesignationId;
                    oldStaff.PostOfficeId = staff.PostOfficeId;

                    _context.Staff.Update(oldStaff);
                }
            }
            try
            {
                await _context.SaveChangesAsync();
                return staff;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Staff> DeleteStaff(int id)
        {
            Staff st = _context.Staff.Find(id);
            if(st != null)
            {
                ApplicationUser userStaff = _context.Users.Where(w => w.Email == st.Email).FirstOrDefault();
                IdentityResult result = await _userManager.DeleteAsync(userStaff);

                if (result.Succeeded)
                {
                    _context.Staff.Remove(st);
                    await _context.SaveChangesAsync();
                    return st;
                }
            }
            return null;
        }
        public bool StaffExists(int id)
        {
            return _context.Staff.Any(e => e.Id == id);
        }

        public IEnumerable<Staff> GetAllStaffByDesignation(int BranchId, int designatonId)
        {

            return _context.Staff.Where(b => b.BranchId == BranchId && b.DesignationId == designatonId && b.ResignDate == null).ToList();
        }

        //List<Staff> staffs;
        //var Branch = _context.Branch.Find(BranchId);
        //var designation = _context.Designation.Find(designatonId);
        //if (Branch != null && designation != null)
        //{
        //    staffs = _context.Staff.Where(b => b.BranchId == BranchId && b.DesignationId == designatonId && b.ResignDate == null).ToList();
        //    return staffs;
        //}
        //else
        //{
        //    return null;
        //}

        //var Branch = _context.Branch.Find(BranchId);
        //var designation = _context.Designation.Find(designatonId);
        //if (Branch != null && designation != null)
        //{
        //    var staffs = _context.Staff.Where(b => b.BranchId == BranchId && b.DesignationId == designatonId && b.ResignDate == null).ToList();
        //    return staffs;
        //}
        //else
        //{
        //    return null;
        //}
        //Kawsar
        public async Task<Staff> EditStaffProfile(int id, Staff staff)
        {
            var staff1 = _context.Staff.Where(w => w.Id == id).FirstOrDefault();

            if (staff1 != null)
            {
                staff1.Religion = staff.Religion;
                staff1.PhoneNo = staff.PhoneNo;
                if (staff.ImageUrl != null)
                {
                    staff1.ImageUrl = staff.ImageUrl;
                }
                staff1.MaritalStatus = staff.MaritalStatus;
                staff1.PresentAddress = staff.PresentAddress;
                staff1.ParmanentAddress = staff.ParmanentAddress;
                staff1.PostOfficeId = staff.PostOfficeId;

                _context.Staff.Update(staff1);
            }

            try
            {
                await _context.SaveChangesAsync();
                return staff;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        //Rokeya
        public IEnumerable<Staff> GetStaffForBranch(int BranchId)
        {
            return _context.Staff.Where(e => e.BranchId == BranchId);
        }
    }
}
