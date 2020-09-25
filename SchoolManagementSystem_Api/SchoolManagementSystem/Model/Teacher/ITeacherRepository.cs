using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public interface ITeacherRepository
    {  

        public Task<IEnumerable<Teacher>> GetAllTeacher();
        public Task<Teacher> GetTeacher(int id);
        public Task<Teacher> UpdateTeacher(int id, Teacher teacher);
        public Task<Teacher> AddTeacher(Teacher teacher);
        public Task<Teacher> DeleteTeacher(int id);

        //Kawsar
        IEnumerable<Teacher> GetAllTeacherForBranch(int BranchId);


        //Ala Uddin
        IEnumerable<Teacher> GetSubjectWiseTeacherForBranch(int BranchId, int subjectId);
        //Kawsar
        IEnumerable<Teacher> GetAllTeacherCheckResign(int BranchId);

        //Benojir
        public Task<Teacher> EditTeacherProfile(int id, Teacher teacher);
        //Benojir
        IEnumerable<Teacher> GetBranchWiseActiveTeacher(int BranchId);


    }
}
