using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Model
{
    public interface IClassRoomRepository
    {
        public Task<IEnumerable<ClassRoom>> GetClassRooms();
        public Task<ClassRoom> GetClassRoom(int id);
        public Task<ClassRoom> UpdateClassRoom(int id, ClassRoom classRoom);
        public Task<ClassRoom> CreateClassRoom(ClassRoom classRoom);
        public Task<ClassRoom> DeleteClassRoom(int id);

        public IEnumerable<ClassRoom> GetAllClassRoom(int BranchId);

    }
}
