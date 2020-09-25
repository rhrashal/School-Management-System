using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public interface IExamRepository
    {
        IEnumerable<Exam> GetAllExam();
        Exam getExam(int id);
        int DeleteExam(int id);
        Task<int> AddNewExam(Exam exam);
    }
}
