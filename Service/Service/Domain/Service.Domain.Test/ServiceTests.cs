using NUnit.Framework;
using System;

namespace Service.Domain.Test
{
    [TestFixture]
    public class ServiceTests
    {

        [Test]
        public void CreateService_OK()
        {
            var sut = new Model.Service(Guid.NewGuid(), Guid.NewGuid(), "Corte de pelo");
            
            Assert.AreEqual("Corte de pelo", sut.ServiceType);
        }
    }
}