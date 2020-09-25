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
    public class BranchController : ControllerBase
    {

        private readonly NoticeBoardRepository _noticeBoardRepository;
        private readonly IRulesRegulationRepository _RulesRegulationRepository;
        private readonly IHolidayRepository _holidayRepository;
        private readonly ISubjectRepository _subjectRepository;
        public BranchController(  NoticeBoardRepository noticeBoardRepository, IRulesRegulationRepository RulesRegulationRepository,IHolidayRepository holidayRepository, ISubjectRepository subjectRepository)
        {

         
            _noticeBoardRepository = noticeBoardRepository;
            _RulesRegulationRepository = RulesRegulationRepository;
            _holidayRepository = holidayRepository;
            _subjectRepository = subjectRepository;
        }


        [HttpGet]
        public ActionResult<IEnumerable<NoticeBoard>> GetAllbranchWiseNotice(/* int branchId ,int year*/)
        {
            try
            {
                var notices = _noticeBoardRepository.GetAllBranchWiseNotice(1, 2020);

                if (notices == null)
                {
                    return NotFound();
                }
                return Ok(notices);


            }
            catch (Exception)
            {
                return BadRequest();
            }
        }



        [HttpGet]
        public ActionResult<IEnumerable<RulesRegulation>> GetAllbranchWiseRules(/* int branchId*/)
        {
            try
            {
                var notices = _RulesRegulationRepository.GetAllBranchWiseRules(1);

                if (notices == null)
                {
                    return NotFound();
                }
                return Ok(notices);


            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        //Kawsar
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Holiday>>> GetDateWiseAllHoliday(/*int branchId, int year*/)
        {

            var notices = await _holidayRepository.GetDateWiseAllHoliday(2020, 1, 01);
            if (notices.Count() != 0)
            {
                return notices.ToList();
            }
            return NotFound();
        }



        //**********GetAllSubjectForBranch  *****************//

        [HttpGet]
        public ActionResult<IEnumerable<Subject>> GetAllSubjectForbranch()
        {
            var subjectlist = _subjectRepository.GetAllSubjectForBranch(1);
            if (subjectlist.Count() != 0)
            {
                return subjectlist.ToList();
            }
            return NotFound("Scerching Subject is Not found");
        }



    }
}
