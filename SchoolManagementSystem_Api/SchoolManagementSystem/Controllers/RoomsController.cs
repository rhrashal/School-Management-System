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
    public class RoomsController : ControllerBase
    {
        private readonly IRoomRepository _roomRepository;

        public RoomsController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }



   


        //// GET: api/Room/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Room>> GetRoom(int id)
        //{
        //    var room = await _roomRepository.GetRoom(id);

        //    if (room == null)
        //    {
        //        return NotFound();
        //    }

        //    return room;
        //}


        // PUT: api/Events/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            if (id != room.Id)
            {
                return BadRequest();
            }
            try
            {
                await _roomRepository.AddNewRoom(room);
                return CreatedAtAction("GetRoom", new { id = room.Id }, room);
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
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            if (ModelState.IsValid)
            {
                await _roomRepository.AddNewRoom(room);
                return CreatedAtAction("GetRoom", new { id = room.Id }, room);
            }
            return BadRequest("Model is not valid");
        }


        // DELETE: api/Room/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Room>> DeleteRoom(int id)
        //{
        //    try
        //    {
        //        await _roomRepository.DeleteRoom(id);
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

        //Benojir
        // GET:Room/GetAllAssignRoom/1

        //[HttpGet("{id}")]
        //public ActionResult<IEnumerable<Room>> GetAllAssignRoom(int id)
        //{
        //    var roomList = _roomRepository.GetAllAssignRoom(id);
        //    if (roomList.Count() != 0)
        //    {
        //        return roomList.ToList();
        //    }
        //    return NotFound("Scerching Data is null");
        //}



    }
}
