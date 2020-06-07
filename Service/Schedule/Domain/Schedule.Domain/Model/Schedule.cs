using System;
using System.Collections.Generic;

namespace Schedule.Domain.Model
{
    public class Schedule
    {
        public Guid ScheduleId { get; }
        public Guid StylistProfileId { get; }
        public List<double> StartStopHoursPerDay { get; }
        public List<EnDaysPerWeek> WorkableDaysPerWeek { get; }
        public List<DateTime> HolidayDays { get; }

        public Schedule(Guid scheduleId, Guid stylistProfileId, List<double> startStopHoursPerDay, List<EnDaysPerWeek> workableDaysPerWeek, List<DateTime> holidayDays)
        {
            this.ScheduleId = scheduleId;
            this.StylistProfileId = stylistProfileId;
            this.StartStopHoursPerDay = startStopHoursPerDay;
            this.WorkableDaysPerWeek = workableDaysPerWeek;
            this.HolidayDays = holidayDays;
        }
    }
}
