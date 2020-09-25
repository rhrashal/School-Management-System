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
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _rollManager;
        public TeacherRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> rollManager)
        {
            _context = context;
            _userManager = userManager;
            _rollManager = rollManager;
        }

        public async Task<IEnumerable<Teacher>> GetAllTeacher()
        {
            if (_context.Teacher.Count() != 0)
            {
                return await _context.Teacher.ToListAsync();
            }
            return null;
        }
        public async Task<Teacher> GetTeacher(int id)
        {
            if (TeacherExists(id))
            {
                var teacher = await _context.Teacher.FindAsync(id);
                return teacher;
            }
            return null;
        }
        public async Task<Teacher> AddTeacher(Teacher teacher)
        {
            if (teacher.Id == 0)
            {
                try
                {
                    ApplicationUser user = new ApplicationUser()
                    {
                        Email = teacher.Email,
                        UserName = teacher.Email
                    };
                    IdentityResult result = await _userManager.CreateAsync(user, teacher.ConfirmPassword);
                    if (!result.Succeeded)
                    {
                        return null;
                    }
                    else
                    {
                        _context.Teacher.Add(teacher);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            try
            {
                await _context.SaveChangesAsync();
                return teacher;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<Teacher> UpdateTeacher(int id, Teacher teacher)
        {
            var teacher1 = _context.Teacher.Where(w => w.Id == teacher.Id).FirstOrDefault();
            if (teacher.Email != null)
            {
                ApplicationUser userTeacher = _context.Users.Where(w => w.Email == teacher1.Email).FirstOrDefault();
                if (userTeacher != null)
                {
                    userTeacher.Email = teacher.Email;
                    userTeacher.UserName = teacher.Email;
                };
                IdentityResult result = await _userManager.UpdateAsync(userTeacher);
                if (!result.Succeeded)
                {
                    return null;
                }

            }

            if (teacher1 != null)
            {
                //Update that educationSystem
                teacher1.FirstName = teacher.FirstName;
                teacher1.LastName = teacher.LastName;
                teacher1.DateOfBirth = teacher.DateOfBirth;
                //teacher1.Password = teacher.Password;
                teacher1.Gender = teacher.Gender;
                teacher1.Religion = teacher.Religion;
                teacher1.PhoneNo = teacher.PhoneNo;
                teacher1.NationalIdNo = teacher.NationalIdNo;
                if (teacher.Email != null)
                {
                    teacher1.Email = teacher.Email;
                }
                if (teacher.ImageUrl != null)
                {
                    teacher1.ImageUrl = teacher.ImageUrl;
                }
                teacher1.IsPresent = teacher.IsPresent;
                teacher1.CreatedDate = teacher.CreatedDate;
                teacher1.FathersName = teacher.FathersName;
                teacher1.MothersName = teacher.MothersName;
                teacher1.MaritalStatus = teacher.MaritalStatus;
                teacher1.JoiningDate = teacher.JoiningDate;
                teacher1.ResignDate = teacher.ResignDate;
                teacher1.BranchId = teacher.BranchId;
                teacher1.DesignationId = teacher.DesignationId;
                //teacher1.SubjectId = teacher.SubjectId;


                _context.Teacher.Update(teacher1);
            }
            try
            {
                var result = await _context.SaveChangesAsync();
                return teacher1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Teacher> DeleteTeacher(int id)
        {

            Teacher T = _context.Teacher.Find(id);
            if (T != null)
            {
                ApplicationUser userTeacher = _context.Users.Where(w => w.Email == T.Email).FirstOrDefault();
                IdentityResult result = await _userManager.DeleteAsync(userTeacher);

                if (result.Succeeded)
                {
                    _context.Teacher.Remove(T);
                    await _context.SaveChangesAsync();
                    return T;
                }
            }
            return null;

        }

        private bool TeacherExists(int id)
        {
            return _context.ClassRoom.Any(e => e.Id == id);
        }

        //Benojir
        public IEnumerable<Teacher> GetBranchWiseActiveTeacher(int BranchId)
        {
            var aa = _context.Teacher.Where(te => te.BranchId == BranchId && te.IsPresent == true).ToList();
            return aa;
        }

        //Mohammad Alauddin
        public IEnumerable<Teacher> GetAllTeacherForBranch(int BranchId)
        {
            var aa = _context.Teacher.Where(te => te.BranchId == BranchId && te.ResignDate == null || te.ResignDate > DateTime.Now);
            return aa;
            //throw new NotImplementedException();
        }


        //Ala uddin
        public IEnumerable<Teacher> GetSubjectWiseTeacherForBranch(int BranchId, int subjectId)
        {
            var teachers = this.GetAllTeacherForBranch(BranchId);

            return teachers.ToList(); //.Where(d => d.SubjectId == subjectId).ToList();
        }

        //Kawsar
        public IEnumerable<Teacher> GetAllTeacherCheckResign(int BranchId)
        {
            var tt = _context.Teacher.Where(aa => aa.BranchId == BranchId && aa.ResignDate == null || aa.ResignDate >= DateTime.Now).ToList();
            return tt;
        }

        //Benojir
        public async Task<Teacher> EditTeacherProfile(int id, Teacher teacher)
        {
            var teacher1 = _context.Teacher.Where(w => w.Id == teacher.Id).FirstOrDefault();
            if (teacher.Email != null)
            {
                ApplicationUser userTeacher = _context.Users.Where(w => w.Email == teacher1.Email).FirstOrDefault();
                if (userTeacher != null)
                {
                    userTeacher.Email = teacher.Email;
                    userTeacher.UserName = teacher.Email;
                };
                IdentityResult result = await _userManager.UpdateAsync(userTeacher);
                if (!result.Succeeded)
                {
                    return null;
                }

            }

            if (teacher1 != null)
            {
               
                teacher1.FirstName = teacher.FirstName;
                teacher1.LastName = teacher.LastName;
               
                teacher1.Gender = teacher.Gender;
                teacher1.Religion = teacher.Religion;
                teacher1.PhoneNo = teacher.PhoneNo;
                
                if (teacher.ImageUrl != null)
                {
                    teacher1.ImageUrl = teacher.ImageUrl;
                }
                
                teacher1.FathersName = teacher.FathersName;
                teacher1.MothersName = teacher.MothersName;
                teacher1.MaritalStatus = teacher.MaritalStatus;
                


                _context.Teacher.Update(teacher1);
            }
            try
            {
                var result = await _context.SaveChangesAsync();
                return teacher1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

    }
}
