namespace Geolocation.Domain.Test.Model
{
    using System;
    using Domain.Model;
    using NUnit.Framework;

    [TestFixture]
    public class GeolocationTest
    {
        [Test]
        public void Instantiate_Ok()
        {
            // Arrange
            var locationId = Guid.NewGuid();
            var profileId = Guid.NewGuid();
            var direction = "Carrer Somewhere 119";
            var coordinates = "0:00:00:00 1:00:00:00";

            // Act
            var sut = new Geolocation(locationId, profileId, direction, coordinates);

            // Assert
            Assert.AreEqual(locationId, sut.LocationId);
            Assert.AreEqual(profileId, sut.ProfileId);
            Assert.AreEqual(direction, sut.Direction);
            Assert.AreEqual(coordinates, sut.Coordinates);
        }
    }
}