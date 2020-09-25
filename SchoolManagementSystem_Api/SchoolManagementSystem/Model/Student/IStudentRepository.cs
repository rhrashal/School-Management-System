using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem
{
    public interface IStudentRepository
    {
        public Task<IEnumerable<Student>> GetAllStudent();
        public Task<Student> GetStudent(int id);
        public Task<int> SaveStudent(Student student);
        public Task<int> UpdateStudent(Student student);
        public Task<Student> DeleteStudent(int? id);
        //Ala uddin
        public Task<int> EditStudentProfile(Student student);
    }
}
