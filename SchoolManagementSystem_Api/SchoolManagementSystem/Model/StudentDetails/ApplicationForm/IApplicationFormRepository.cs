using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem
{
    public interface IApplicationFormRepository
    {
        IEnumerable<ApplicationForm> GetAllApplication();
        ApplicationForm GetApplication(int id);
        int DeleteApplication(int id);
        Task<int> SaveApplication(ApplicationForm applicationForm);
    }
}
