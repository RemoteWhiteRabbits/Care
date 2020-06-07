using NUnit.Framework;
using Profile.Domain.Model;

namespace Profile.Domain.Test.Model
{
    [TestFixture]
    public class PersonalInfoTests
    {
        [Test]
        public void CreatePersonalInfo()
        {
            var sut = new PersonalInfo("Erika", "Rossi", Enum.Gender.Female);

            Assert.AreEqual("Erika", sut.FirstName);
            Assert.AreEqual(Enum.Gender.Female, sut.Gender);
        }
    }
}
