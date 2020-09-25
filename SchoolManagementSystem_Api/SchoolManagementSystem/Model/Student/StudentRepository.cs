using Microsoft.AspNetCore.Identity;
using SchoolManagementSystem.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Model;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;

namespace SchoolManagementSystem
{
    public class StudentRepository : IStudentRepository
    {
        ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _rollManager;
        public StudentRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> rollManager)
        {
            _context = context;
            _userManager = userManager;
            _rollManager = rollManager;

        }

        public async Task<IEnumerable<Student>> GetAllStudent()
        {
            if (_context != null)
            {
                return await _context.Student.ToListAsync();
            }
            return null;
        }

        public async Task<Student> GetStudent(int id)
        {
            if (StudentExists(id))
            {
                return await _context.Student.FirstOrDefaultAsync(s => s.Id == id);
            }
            return null;
        }

        public async Task<int> SaveStudent(Student student)
        {

            if (_context != null)
            {
                if (student.Id == 0)
                {
                    try
                    {
                        ApplicationUser user = new ApplicationUser()
                        {
                            UserName = student.FirstName,
                            FirstName = student.FirstName,
                            LastName = student.LastName,

                        };

                        IdentityResult result = await _userManager.CreateAsync(user, student.FirstName);

                        if (result.Succeeded)
                        {
                            try
                            {
                                _context.Student.Add(student);
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
                //Commit the transaction
                await _context.SaveChangesAsync();
                return student.Id;

            }

            return 0;
        }

        public async Task<int> UpdateStudent(Student student)
        {
            if (_context != null)
            {
                var dbEntry = _context.Student.Where(s => s.Id == student.Id).FirstOrDefault();

                if (dbEntry != null)
                {
                    ApplicationUser userStudent = _context.Users.Where(s => s.UserName == dbEntry.FirstName).FirstOrDefault();

                    if (userStudent != null)
                    {
                        userStudent.UserName = dbEntry.FirstName;
                        userStudent.FirstName = dbEntry.FirstName;
                        userStudent.LastName = dbEntry.LastName;
                    };
                    IdentityResult result = await _userManager.UpdateAsync(userStudent);

                    if (result.Succeeded)
                    {
                        dbEntry.FirstName = student.FirstName;
                        dbEntry.LastName = student.LastName;
                        dbEntry.DateOfBirth = student.DateOfBirth;
                        //dbEntry.RegistrationNo = student.RegistrationNo;
                        dbEntry.RollNo = student.RollNo;
                        dbEntry.Gender = student.Gender;
                        dbEntry.Religion = student.Religion;
                        dbEntry.BirthRegistrationNo = student.BirthRegistrationNo;
                        dbEntry.ImageUrl = student.ImageUrl;
                        dbEntry.FatherName = student.FatherName;
                        dbEntry.FatherOccupation = student.FatherOccupation;
                        dbEntry.FatherPhone = student.FatherPhone;
                        dbEntry.MotherName = student.MotherName;
                        dbEntry.MotherName = student.MotherName;
                        dbEntry.MotherPhone = student.MotherPhone;
                        dbEntry.MonthlyFamillyIncome = student.MonthlyFamillyIncome;
                        dbEntry.FormarSchoolName = student.FormarSchoolName;
                        dbEntry.GuardianName = student.GuardianName;
                        dbEntry.GuardianPhoneNo = student.GuardianPhoneNo;
                        dbEntry.RelationOfAltGuardian = dbEntry.RelationOfAltGuardian;
                        dbEntry.QuotaId = student.QuotaId;
                        dbEntry.PostOfficeId = student.PostOfficeId;

                        //Update that Student
                        _context.Student.Update(dbEntry);

                    }

                }
                try
                {
                    await _context.SaveChangesAsync();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return dbEntry.Id;
            }
            return student.Id;
        }


        //Ala uddin
        public async Task<int> EditStudentProfile(Student student)
        {
            if (_context != null)
            {
                var dbEntry = _context.Student.Where(s => s.Id == student.Id).FirstOrDefault();

                if (dbEntry != null)
                {
                    //dbEntry.PasswordHints = student.PasswordHints;
                    dbEntry.ImageUrl = student.ImageUrl;

                    dbEntry.FatherOccupation = student.FatherOccupation;
                    dbEntry.FatherPhone = student.FatherPhone;

                    dbEntry.MotherOccupation = student.MotherOccupation;
                    dbEntry.MotherPhone = student.MotherPhone;
                    dbEntry.MonthlyFamillyIncome = student.MonthlyFamillyIncome;

                    dbEntry.GuardianName = student.GuardianName;
                    dbEntry.GuardianPhoneNo = student.GuardianPhoneNo;
                    dbEntry.RelationOfAltGuardian = dbEntry.RelationOfAltGuardian;

                    dbEntry.PostOfficeId = student.PostOfficeId;

                    //Update that Student
                    _context.Student.Update(dbEntry);

                }
                try
                {
                    await _context.SaveChangesAsync();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return dbEntry.Id;
            }
            return student.Id;
        }









        public async Task<Student> DeleteStudent(int? id)
        {
            // Find Student is already exit in database?
            Student dbEntry = _context.Student.Find(id);

            if (dbEntry != null)
            {
                ApplicationUser userStudent = _context.Users.Where(s => s.UserName == dbEntry.FirstName).FirstOrDefault();
                IdentityResult result = await _userManager.DeleteAsync(userStudent);

                if (result.Succeeded)
                {
                    var student = _context.Student.First(s => s.Id == dbEntry.Id);
                }

                //Delete that Student
                _context.Student.Remove(dbEntry);

            }
            //Commit the transaction
            await _context.SaveChangesAsync();

            return dbEntry;
        }

        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
