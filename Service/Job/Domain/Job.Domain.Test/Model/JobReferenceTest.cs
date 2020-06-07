namespace Job.Domain.Test.Model
{
    using System;
    using Domain.Model;
    using NUnit.Framework;

    [TestFixture]
    public class JobReferenceTest
    {
        [Test]
        public void Instantiate_Ok()
        {
            var clientProfileId = Guid.NewGuid();
            var stylistProfileId = Guid.NewGuid();
            var serviceId = Guid.NewGuid();
            var locationId = Guid.NewGuid();

            // Act
            var sut = new JobReference(clientProfileId, stylistProfileId, serviceId, locationId);

            // Assert
            Assert.AreEqual(clientProfileId, sut.ClientProfileId);
            Assert.AreEqual(stylistProfileId, sut.StylistProfileId);
            Assert.AreEqual(serviceId, sut.ServiceId);
            Assert.AreEqual(locationId, sut.LocationId);
        }
    }
}