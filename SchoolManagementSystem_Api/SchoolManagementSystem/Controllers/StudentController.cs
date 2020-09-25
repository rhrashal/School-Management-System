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
    public class StudentController : ControllerBase
    {
        //Mohammad Alauddin
        private readonly IStudentRepository _studentR;
        private readonly ISubjectRepository _subjectR;
        public StudentController(IStudentRepository studentR, ISubjectRepository subjectR)
        {
            _studentR = studentR;
            _subjectR = subjectR;


        }


        //Mohammad Alauddin
        [HttpGet]
        public ActionResult<IEnumerable<Subject>> GetAllSubjectForStudent(int studentId)
        {
            var subjectList = _subjectR.GetAllSubjectForStudent(1);

            if (subjectList.Count() != 0)
            {
                return subjectList.ToList();
            }
            return NotFound("Scerching Data is null");
        }

        //Ala uddin
        
        [HttpPut]
        //[Route("PutStudent")]
        public async Task<IActionResult> EditStudentProfile([FromBody] Student model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _studentR.EditStudentProfile(model);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }




    }
}
