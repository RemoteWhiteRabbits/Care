namespace Schedule.Domain.Test.Model
{
    using System;
    using System.Collections.Generic;
    using Domain.Model;
    using NUnit.Framework;

    [TestFixture]
    public class ScheduleTest
    {
        [Test]
        public void Instantiate_Ok()
        {
            // Arrange
            var scheduleId = Guid.NewGuid();
            var stylistProfileId = Guid.NewGuid();
            var startStopHoursPerDay = new List<double> {9, 13, 15, 19};
            var workableDaysPerWeek = new List<EnDaysPerWeek> {EnDaysPerWeek.Tuesday, EnDaysPerWeek.Thursday};
            var holidayDays = new List<DateTime> { DateTime.Today };

            // Act
            var sut = new Schedule(scheduleId, stylistProfileId, startStopHoursPerDay, workableDaysPerWeek, holidayDays);

            // Assert
            Assert.AreEqual(scheduleId, sut.ScheduleId);
            Assert.AreEqual(stylistProfileId, sut.StylistProfileId);
            Assert.AreEqual(startStopHoursPerDay, sut.StartStopHoursPerDay);
            Assert.AreEqual(workableDaysPerWeek, sut.WorkableDaysPerWeek);
            Assert.AreEqual(holidayDays, sut.HolidayDays);
        }
    }
}