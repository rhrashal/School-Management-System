using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository _teacherR;
       
        public TeacherController(ITeacherRepository teacherR)
        {
            _teacherR = teacherR;
            

        }

        //Mohammad Alauddin
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Teacher>> GetAllTeacherForBranch(int id)
        {
            var teacher = _teacherR.GetAllTeacherForBranch(id);
            if (teacher.Count() != 0)
            {
                return teacher.ToList();
            }
            return NotFound("Searching data is null");
        }

        //Ala uddin
        [HttpGet]
        public ActionResult<IEnumerable<Teacher>> GetSubjectWiseTeacherForBranch(/*int BranchId*/)
        {
            var teacherList = _teacherR.GetSubjectWiseTeacherForBranch(1,1);
            if (teacherList.Count() != 0)
            {
                return teacherList.ToList();
            }
            return NotFound("Scerching Data is null");
        }
        //Kawsar
        //Get: Teacher/GetAllTeacherCheckResign
        public ActionResult<IEnumerable<Teacher>> GetAllTeacherCheckResign(/*int BranchId*/)
        {
            var teacherList = _teacherR.GetAllTeacherCheckResign(1);
            if (teacherList.Count() != 0)
            {
                return teacherList.ToList();
            }
            return NotFound("Scerching Data is null");
        }

        //Benojir
        //Put : Teacher/EditTeacher/1
        [HttpPut("{id}")]
        public async Task<ActionResult<Teacher>> EditTeacher(int id, Teacher teacher)
        {
            var ET = await _teacherR.EditTeacherProfile(id, teacher);

            if (ET == null)
            {
                return NotFound();
            }

            return ET;
        }

        //Benojir
        //Get: Teacher/GetTeacher/1
        [HttpGet]
        public ActionResult<IEnumerable<Teacher>> GetTeacher(/*int BranchId*/)
        {
            var teacherList = _teacherR.GetBranchWiseActiveTeacher(1);
            if (teacherList.Count() != 0)
            {
                return teacherList.ToList();
            }
            return NotFound("Scerching Data is null");
        }


    }
}
