using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Model;
using SchoolManagementSystem.Data;

namespace SchoolManagementSystem.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IExamMarkRepository _examMarkRepo;
        private readonly IExamResultRepository _examResutlRepo;
        private readonly ApplicationDbContext _context;
        public ExamController(IExamMarkRepository examMarkRepo, IExamResultRepository examResutlRepo, ApplicationDbContext context)
        {
            _examMarkRepo = examMarkRepo;
            _examResutlRepo = examResutlRepo;
            _context = context;
        }
        [HttpGet]
        [Route("{examId,studentId}")]
        public ActionResult<IEnumerable<ExamMark>> GetMarks(int examId, int studentId)
        {
            try
            {
                var Result = _examMarkRepo.GetAllExamMarkOfStudent( examId, studentId);

                if (Result == null)
                {
                    return NotFound();
                }

                return Ok(Result);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpPost]
        public ActionResult<ExamMark> saveMark(ExamMark examMarks)
        {
            try
            {
                var examMrk = _examMarkRepo.AddExamMark(examMarks);

                if (examMrk == null)
                {
                    return NotFound();
                }

                return Ok(examMrk);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }


        [HttpPost]
        public ActionResult<ExamResult> saveResult(ResultGenerate result)
        {
            try
            {
                var examMrk = _examResutlRepo.GenerateExamResult(result);

                if (examMrk == null)
                {
                    return NotFound();
                }

                return Ok(examMrk);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

    }
}
