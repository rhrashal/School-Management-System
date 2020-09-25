using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem
{

    public interface IQuotaRepository
    {
        IEnumerable<Quota> GetAllQuota();
        Quota GetQuota(int id);
        int DeleteQuota(int id);
        Task<int> SaveQuota(Quota quota);
    }

}
