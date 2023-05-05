
using RegistrationSystem.Utils;
using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystemTests
{
    [TestClass]
    public class UtilTests
    {

        [TestMethod]
        public void IsValidCodeReturnsTrueOnValidIdCodeTest()
        {
            // Arrange
            var code = "39709241234";

            var util = new EventUtils();

            // Assert
            Assert.IsTrue(util.isValidIdCode(code));
        }

        [TestMethod]
        public void IsValidCodeReturnsFalseOnIncorrectFirstDigitTest()
        {
            // Arrange
            var code = "79709241234";

            var util = new EventUtils();

            // Assert
            Assert.IsFalse(util.isValidIdCode(code));
        }

        [TestMethod]
        public void IsValidCodeReturnsFalseOnIncorrectCodeLengthTest()
        {
            // Arrange
            var code = "7970924123412345";
            var code2 = "7";

            var util = new EventUtils();

            // Assert
            Assert.IsFalse(util.isValidIdCode(code));
            Assert.IsFalse(util.isValidIdCode(code2));
        }

        [TestMethod]
        public void IsValidCodeReturnsFalseIfCodeContainsLettersTest()
        {
            // Arrange
            var code = "79abcd41234";

            var util = new EventUtils();

            // Assert
            Assert.IsFalse(util.isValidIdCode(code));
        }

        [TestMethod]
        public void CountParticipantsReturnsCorrectNumberTest()
        {
            // Arrange
            var util = new EventUtils();
            var eventOb = new Event();
            eventOb.Participants = new List<ParticipantInEvent>();

            for (int i = 1; i < 6; i++)
            {
                var participant = new ParticipantInEvent();
                participant.ParticipantCount = i;
                eventOb.Participants.Add(participant);
            }

            // Assert
            Assert.AreEqual(15, util.CountParticipants(eventOb));
        }

        [TestMethod]
        public void IsValidDateReturnsTrueOnCorrectDateInputTest()
        {
            // Arrange
            var util = new EventUtils();

            // Assert
            Assert.IsTrue(util.isValidDate("3", "97", "09", "24"));
        }

        [TestMethod]
        public void IsValidDateReturnsFalseOnIncorrectDateTest()
        {
            // Arrange
            var util = new EventUtils();

            // Assert
            Assert.IsFalse(util.isValidDate("3", "97", "02", "31"));
        }

        [TestMethod]
        public void IsValidDateReturnsFalseOnFutureDateTest()
        {
            // Arrange
            var util = new EventUtils();

            // Assert
            Assert.IsFalse(util.isValidDate("6", "97", "09", "24"));
        }
    }
}
