using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public class ClassRoomRepository : IClassRoomRepository
    {
        private readonly ApplicationDbContext _context;
        public ClassRoomRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public string SaveNewClassRoom(ClassRoom classRoom)
        {
            var classRoomExist = _context.ClassRoom.Where(r => r.BranchClassId == classRoom.BranchClassId
                                                            && r.RoomId == classRoom.RoomId
                                                            && r.SectionId == classRoom.SectionId
                                                            && r.TeacherId == classRoom.TeacherId
                                                            ).FirstOrDefault();

            if (classRoomExist == null)
            {
                var bc = _context.BranchClass.Where(r => r.Id == classRoom.BranchClassId).FirstOrDefault();
                var isinRoom = _context.Room.Where(w => w.BranchId == bc.BranchId && w.Id == classRoom.RoomId).FirstOrDefault();
                if (isinRoom != null)
                {
                    var teacherExist = _context.ClassRoom.Where(r => r.TeacherId == classRoom.TeacherId).FirstOrDefault();
                    if (teacherExist == null)
                    {
                        var sessionExist = _context.ClassRoom.Where(r => r.SectionId == classRoom.SectionId).FirstOrDefault();
                        if (sessionExist == null)
                        {
                            var isinSession = _context.Section.Where(w => w.BranchClassId == classRoom.BranchClassId && w.Id == classRoom.SectionId).FirstOrDefault();
                            if (isinSession != null)
                            {
                                _context.ClassRoom.Add(classRoom);
                                try
                                {
                                    _context.SaveChanges();
                                    return "Successfully Created New Class Room.";
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }
                            }
                            return "This Session are not in Branch class.";
                        }
                        return "A Class Room Contain only one Session.";
                    }
                    return "A Teacher not able to more then one class teacher.";
                }
                return "This Room not into this branch.";
            }
            return "This Class Room Already Exist.";
        }




        public async Task<IEnumerable<ClassRoom>> GetClassRooms()
        {
            if (_context != null)
            {
                return await _context.ClassRoom.ToListAsync();
            }
            return null;
        }

        public async Task<ClassRoom> GetClassRoom(int id)
        {
            if (ClassRoomExists(id))
            {
                var classRoom = await _context.ClassRoom.FindAsync(id);
                return classRoom;
            }
            return null;

        }
        public async Task<ClassRoom> CreateClassRoom(ClassRoom classRoom)
        {
            if (classRoom.Id == 0)
            {
                _context.ClassRoom.Add(classRoom);
            }
            try
            {
                await _context.SaveChangesAsync();
                return classRoom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<ClassRoom> UpdateClassRoom(int id, ClassRoom classRoom)
        {
            ClassRoom clr = _context.ClassRoom.Find(classRoom.Id);

            if (clr != null)
            {
                //Update that educationSystem
                clr.BranchClassId = classRoom.BranchClassId;
                clr.SectionId = classRoom.SectionId;
                clr.RoomId = classRoom.RoomId;
                clr.TeacherId = classRoom.TeacherId;

                _context.ClassRoom.Update(clr);
            }
            try
            {
                var result = await _context.SaveChangesAsync();
                return classRoom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<ClassRoom> DeleteClassRoom(int id)
        {
            var clr = await _context.ClassRoom.FindAsync(id);
            if (clr != null)
            {
                _context.ClassRoom.Remove(clr);
            }
            try
            {
                var res = await _context.SaveChangesAsync();
                return clr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool ClassRoomExists(int id)
        {
            return _context.ClassRoom.Any(e => e.Id == id);
        }



        public IEnumerable<ClassRoom> GetBranchWiseClassRoom(int BranchId)
        {
            List<ClassRoom> classList = new List<ClassRoom>();
            var BranchClass = _context.BranchClass.Where(a => a.BranchId == BranchId).ToList();
            foreach (var bc in BranchClass)
            {
                var classRoom = _context.ClassRoom.Where(e => e.BranchClassId == bc.Id).FirstOrDefault();
                classList.Add(classRoom);
            }
            return classList.ToList();
        }

        public IEnumerable<ClassRoom> GetAllClassRoom(int BranchId)
        {
            List<ClassRoom> classList = new List<ClassRoom>();
            var BranchClass = _context.BranchClass.Where(a => a.BranchId == BranchId);
            foreach (var bc in BranchClass)
            {
                var classRoom = _context.ClassRoom.Where(e => e.BranchClassId == bc.Id).FirstOrDefault();
                classList.Add(classRoom);
            }
            return classList.ToList();
        }


    }
}
