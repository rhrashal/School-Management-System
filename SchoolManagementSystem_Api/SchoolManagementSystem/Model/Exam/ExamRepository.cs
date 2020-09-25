using SchoolManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class ExamRepository : IExamRepository
    {

        private readonly ApplicationDbContext _context;
        public ExamRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<int> AddNewExam(Exam exam)
        {
            if (exam.Id == 0)
            {
                _context.Exam.Add(exam);
            }
            else
            {
                Exam exa = _context.Exam.Find(exam.Id);

                if (exa != null)
                {

                    exa.ExamType = exam.ExamType;
                    exa.ExamDiscription = exam.ExamDiscription;
                    exa.StartDate = exam.StartDate;
                    exa.EndDate = exam.EndDate;
                    exa.IsActive = exam.IsActive;
                    exa.Duration = exam.Duration;
                    exa.BranchId = exam.BranchId;
                    _context.Exam.Update(exa);
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

        public int DeleteExam(int id)
        {
            Exam exa = _context.Exam.Find(id);
            if (exa != null)
            {
                _context.Exam.Remove(exa);
            }
            try
            {
                var res = _context.SaveChanges();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Exam> GetAllExam()
        {
            return _context.Exam.ToList();
        }

        public Exam getExam(int id)
        {
            if (ExamExists(id))
            {
                return this.GetAllExam().Where(exa => exa.Id == id).FirstOrDefault();
            }
            return null;
        }

        private bool ExamExists(int id)
        {
            return _context.Exam.Any(e => e.Id == id);
        }
    }
}
