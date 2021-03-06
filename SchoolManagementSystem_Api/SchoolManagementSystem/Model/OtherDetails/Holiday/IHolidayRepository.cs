﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolManagementSystem.Model;

namespace SchoolManagementSystem
{
    public interface IHolidayRepository
    {
        public Task<IEnumerable<Holiday>> GetAllHoliday();

        public Task<Holiday> GetHoliday(int id);
        public Task<int> AddNewHoliday(Holiday holiday);
        public Task<Holiday> DeleteHoliday(int id);
        //Kawsar
        public Task<IEnumerable<Holiday>> GetDateWiseAllHoliday(int year, int? month, int? date);
    }
}
