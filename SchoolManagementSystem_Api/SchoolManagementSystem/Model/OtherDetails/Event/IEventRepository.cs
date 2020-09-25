using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem
{
    public interface IEventRepository
    {
        public Task<IEnumerable<Event>> GetAllEvent();
        
        public Task<Event> GetEvent(int id);
        public Task<int> AddNewEvent(Event eve);
        public Task<Event> DeleteEvent(int id);

        Task<List<Event>> GetAllEventByEarlierDateTime();


        IEnumerable<Event> GetBranchWiseAllEvent(int BranchId, int year);
        IEnumerable<Event> GetBranchWiseAllEvent1(int BranchId, int year, int month);
        IEnumerable<Event> GetBranchWiseAllEvent2(int BranchId, int year, int month, int date);

    }
}
