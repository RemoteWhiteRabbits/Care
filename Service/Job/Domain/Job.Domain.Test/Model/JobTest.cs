namespace Job.Domain.Test.Model
{
    using System;
    using Domain.Model;
    using Enum;
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class JobTest
    {
        [Test]
        public void Instantiate_Ok()
        {
            var clientProfileId = Guid.NewGuid();
            var stylistProfileId = Guid.NewGuid();
            var serviceId = Guid.NewGuid();
            var locationId = Guid.NewGuid();
            var jobReference = new JobReference(clientProfileId, stylistProfileId, serviceId, locationId);
            var jobId = Guid.NewGuid();
            var status = EnJobStatus.InProgress;
            var startTimeStamp = DateTime.Now;
            var stopTimeStamp = DateTime.Now.AddHours(1);

            // Act
            var sut = new Job(jobId, jobReference, status, startTimeStamp, stopTimeStamp);

            // Assert
            sut.JobReference.Should().BeSameAs(jobReference);
            Assert.AreEqual(jobId, sut.JobId);
            Assert.AreEqual(status, sut.Status);
            Assert.AreEqual(startTimeStamp, sut.StartTimeStamp);
            Assert.AreEqual(stopTimeStamp, sut.StopTimeStamp);
        }
    }
}