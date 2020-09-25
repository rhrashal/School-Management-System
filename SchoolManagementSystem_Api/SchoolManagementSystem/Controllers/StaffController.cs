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
    public class StaffController : ControllerBase
    {
        private readonly IStaffRepository  _context;

        public StaffController(IStaffRepository context)
        {
            _context = context;
        }

        //Rokeya

        //GET: api/Staffs
        [HttpGet]
        public ActionResult<IEnumerable<Staff>> GetStaff()
        {
            var staffList = _context.GetStaffForBranch(1);
            if (staffList.Count() != 0)
            {
                return staffList.ToList();
            }
            return NotFound("Scerching Data is null");
        }


        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Staff>>> GetStaff()
        //{
        //    var stf = await _context.GetAllStaff();
        //    return Ok(stf);
        //}

        // GET: api/Staffs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Staff>> GetStaff(int id)
        {
            var staff = await _context.GetStaff(id);

            if (staff == null)
            {
                return NotFound();
            }

            return staff;
        }

        //Kawsar
        [HttpPut("{id}")]
        public async Task<ActionResult<Staff>> EditStaffProfile(int id, Staff staff)
        {
            if (id != staff.Id)
            {
                return BadRequest();
            }
            else
            {
                await _context.EditStaffProfile(id, staff);
            }

            return Ok();
        }
    }
}
