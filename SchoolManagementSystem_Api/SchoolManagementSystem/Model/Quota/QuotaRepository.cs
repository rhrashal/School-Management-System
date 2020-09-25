using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem
{
    public class QuotaRepository : IQuotaRepository
    {
        private readonly ApplicationDbContext _context;
        public QuotaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get All Quota
        public IEnumerable<Quota> GetAllQuota()
        {
            return _context.Quota.ToList();
        }

        // Get By Id
        public Quota GetQuota(int id)
        {
            if (QuotaExists(id))
            {
                return this.GetAllQuota().Where(quo => quo.Id == id).FirstOrDefault();
            }
            return null;
        }

        //Save or Edit Quota
        public Task<int> SaveQuota(Quota quota)
        {
            if (quota.Id == 0)
            {
                _context.Quota.Add(quota);
            }
            else
            {
                Quota quo = _context.Quota.Find(quota.Id);

                if (quo != null)
                {

                    quo.QuotaName = quota.QuotaName;
                    _context.Quota.Update(quo);
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


        //Delete Quota
        public int DeleteQuota(int id)
        {
            Quota quo = _context.Quota.Find(id);

            if (quo != null)
            {
                _context.Quota.Remove(quo);
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

        private bool QuotaExists(int id)
        {
            return _context.Quota.Any(e => e.Id == id);
        }
    }
}
