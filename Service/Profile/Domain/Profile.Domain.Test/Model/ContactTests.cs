using System;
using NUnit.Framework;
using Profile.Domain.Model;

namespace Profile.Domain.Test.Model
{

    [TestFixture]
    public class ContactTests
    {
        [Test]
        public void CreateContact_Ok()
        {
            var sut = new Contact("996633", "prueba@gmail.com");

            Assert.AreEqual("prueba@gmail.com", sut.Email);
        }

    }
}
