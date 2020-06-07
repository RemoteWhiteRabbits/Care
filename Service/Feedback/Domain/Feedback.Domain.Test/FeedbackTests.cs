using NUnit.Framework;
using System;

namespace Feedback.Domain.Test
{
    [TestFixture]
    public class FeedbackTests
    {

        [Test]
        public void CreateFeedback_Ok()
        {
            var sut = new Model.Feedback(Guid.NewGuid(), Guid.NewGuid(), 4, "Very good");
            
            Assert.AreEqual(4, sut.Rate);
            Assert.AreEqual("Very good", sut.Comment);
        }
    }
}