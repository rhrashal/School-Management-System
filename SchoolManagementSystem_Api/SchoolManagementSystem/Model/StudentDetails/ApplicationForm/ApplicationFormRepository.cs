using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem
{
    public class ApplicationFormRepository : IApplicationFormRepository
    {
        private readonly ApplicationDbContext _context;
        public ApplicationFormRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        // Get By Id
        public ApplicationForm GetApplication(int id)
        {
            if (ApplicationFormExists(id))
            {
                return this.GetAllApplication().Where(appl => appl.Id == id).FirstOrDefault();
            }
            return null;
        }



        // Get All Admission
        public IEnumerable<ApplicationForm> GetAllApplication()
        {
            return _context.ApplicationForm.ToList();
        }


        //Save or Edit Application
        public Task<int> SaveApplication(ApplicationForm applicationForm)
        {
            if (applicationForm.Id == 0)
            {
                _context.ApplicationForm.Add(applicationForm);
            }
            else
            {
                ApplicationForm appl = _context.ApplicationForm.Find(applicationForm.Id);

                if (appl != null)
                {

                    
                    appl.ApplicantId = applicationForm.ApplicantId;
                    appl.FirstName = applicationForm.FirstName;
                    appl.LastName = applicationForm.LastName;
                    appl.DateOfBirth = applicationForm.DateOfBirth;

                    appl.Gender = applicationForm.Gender;
                    appl.Religion = applicationForm.Religion;
                    appl.BirthRegistrationNo = applicationForm.BirthRegistrationNo;
                    appl.ImageUrl = applicationForm.ImageUrl;

                    appl.ApplingDate = applicationForm.ApplingDate;
                    appl.FatherName = applicationForm.FatherName;
                    appl.FatherOccupation = applicationForm.FatherOccupation;
                    appl.FatherPhone = applicationForm.FatherPhone;

                    appl.MotherName = applicationForm.MotherName;
                    appl.MotherOccupation = applicationForm.MotherOccupation;
                    appl.MotherPhone = applicationForm.MotherPhone;

                    appl.MonthlyFamillyIncome = applicationForm.MonthlyFamillyIncome;
                    appl.FormarSchoolName = applicationForm.FormarSchoolName;
                    appl.IsSelected = applicationForm.IsSelected;

                    appl.PresentAddress = applicationForm.PresentAddress;
                    appl.ParmanentAddress = applicationForm.ParmanentAddress;
                    appl.PostOfficeId = applicationForm.PostOfficeId;

                    appl.PostOffice = applicationForm.PostOffice;
                    appl.QuotaId = applicationForm.QuotaId;
                    appl.Quota = applicationForm.Quota;

                    appl.BranchClassId = applicationForm.BranchClassId;
                    appl.BranchClass = applicationForm.BranchClass;

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

        //Delete 
        public int DeleteApplication(int id)
        {
            ApplicationForm admi = _context.ApplicationForm.Find(id);
            if (admi != null)
            {
                _context.ApplicationForm.Remove(admi);
            }
            try
            {
                var result = _context.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ApplicationFormExists(int id)
        {
            return _context.ApplicationForm.Any(a => a.Id == id);
        }
    }
}
