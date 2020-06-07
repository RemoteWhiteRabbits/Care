using NUnit.Framework;
using Profile.Domain.Enum;
using Profile.Domain.Model;

namespace Profile.Domain.Test.Model
{
    [TestFixture]
    public class ProfileTests
    {

        [Test]
        public void CreateProfile_Ok()
        {
            var id = System.Guid.NewGuid();
            var person = new PersonalInfo("Mario","Rossi",Gender.Male);
            var contact = new Contact("mario.rossi@gmail.com","+34667569890");
            var nickName = "Rabbit";
            var password = "112233";
            var type = ProfyleType.Stylist;
            var isVerified = false;
            var sessionToken = "sessionToken";

            var sut = new Domain.Model.Profile(id, person, contact,nickName, password, type, isVerified, sessionToken );

            Assert.AreEqual("Mario", sut.Person.FirstName);
            Assert.AreEqual("Rossi", sut.Person.LastName);
        }

    }
}