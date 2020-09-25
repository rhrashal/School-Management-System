using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("[controller]/[action]")]
    public class EventsController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;

        public EventsController( IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }





        //public async Task<ActionResult<IEnumerable<Event>>> GetEvent()
        //{
        //    var eve = await _eventRepository.GetAllEvent() ;
        //    return Ok(eve);
        //}


       

        //Rokeya
        // GET: api/Event
        [HttpGet]
        public ActionResult<IEnumerable<Event>> GetBranchWiseAllEvent(/*int BranchId, int year*/)
        {

            try
            {
                var notices = _eventRepository.GetBranchWiseAllEvent(1,2021);

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

        //[HttpGet]
        public ActionResult<IEnumerable<Event>> GetBranchWiseAllEvent1(/* int BranchId ,int month*/)
        {

            try
            {
                var notices = _eventRepository.GetBranchWiseAllEvent1(1, 2021, 01);

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



        //[HttpGet]
        public ActionResult<IEnumerable<Event>> GetBranchWiseAllEvent2(/* int BranchId ,int Date*/)
        {

            try
            {
                var notices = _eventRepository.GetBranchWiseAllEvent2(1, 2021, 01, 01);

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




        // GET: api/Event/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var eve = await _eventRepository.GetEvent(id);

            if (eve == null)
            {
                return NotFound();
            }

            return eve;
        }


        // PUT: api/Events/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent(int id, Event eve)
        {
            if (id != eve.Id)
            {
                return BadRequest();
            }
            try
            {
                await _eventRepository.AddNewEvent(eve);
                return CreatedAtAction("GetEvent", new { id = eve.Id }, eve);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        // POST: api/Event
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Event>> PostEvent(Event eve)
        {
            if (ModelState.IsValid)
            {
                await _eventRepository.AddNewEvent(eve);
                return CreatedAtAction("GetEvent", new { id = eve.Id }, eve);
            }
            return BadRequest("Model is not valid");
        }


        // DELETE: api/Event/5
        [HttpDelete("{id}")]
        public  async Task<ActionResult<Event>> DeleteEvent(int id)
        {
            try
            {
               await _eventRepository.DeleteEvent(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        

    }
}
