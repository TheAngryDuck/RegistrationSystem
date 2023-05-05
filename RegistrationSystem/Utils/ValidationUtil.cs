using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystem.Utils
{
    public class ValidationUtil
    {
        public bool ValidateEvent( Event eventOb)
        {
            var isTrueCounter = 0;

            if (eventOb.Name != null && eventOb.Name.Length > 0)
            {
                isTrueCounter++;
            }
            if (eventOb.Date > DateTime.Now)
            {
                isTrueCounter++;
            }
            if (eventOb.Location != null && eventOb.Location.Length > 0)
            {
                isTrueCounter++;
            }

            if (isTrueCounter < 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidateParticipant( Participant participant, bool isCompany)
        {

            var isTrueCounter = 0;

            if (participant.Name != null && participant.Name.Length > 0)
            {
                isTrueCounter++;
            }

            if (isCompany)
            {
                if (participant.RegistryCode != null && participant.RegistryCode.Length == 8)
                {
                    isTrueCounter++;
                }
                if (isTrueCounter < 2)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (participant.IdCode != null)
            {
                if (isValidIdCode(participant.IdCode))
                {
                    isTrueCounter++;
                }
            }
                if (participant.FamilyName != null && participant.FamilyName.Length > 0)
                {
                    isTrueCounter++;
                }
                if (isTrueCounter < 3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public bool ValidateParticipantInEvent( ParticipantInEvent participantInEvent)
        {
            if (participantInEvent.ParticipantId != Guid.Empty && participantInEvent.PaymentMethodId != Guid.Empty && participantInEvent.ParticipantCount > 0)
            { 
                return true;
            }
                return false;
        }
        public bool ValidatePaymentMethod(PaymentMethod paymentMethod)
        {
            if (paymentMethod.Name != null && paymentMethod.Name.Length > 0)
            {
                return true;
            }
            return false;
        }

        public bool isValidIdCode(string code)
        {
            var isValid = false;
            if (code.Length > 9 && code.Length < 12 && (long.TryParse(code, out _)))
            {
                int firstNumber = int.Parse(code.Substring(0, 1));
                var year = code.Substring(1, 2);
                var month = code.Substring(3, 2);
                var day = code.Substring(5, 2);
                if (firstNumber > 0 && firstNumber < 7)
                {
                    isValid = isValidDate(firstNumber.ToString(), year, month, day);
                }
            }
            return isValid;
        }

        public bool isValidDate(string firstNumber, string year, string month, string day)
        {
            var fullYear = "";
            switch (firstNumber)
            {
                case "1" or "2":
                    fullYear = "18" + year;
                    break;
                case "3" or "4":
                    fullYear = "19" + year;
                    break;
                case "5" or "6":
                    fullYear = "20" + year;
                    break;
            }
            var dateParts = new string[] { month, day, fullYear };
            try
            {
                DateTime testDate = new
                    DateTime(Convert.ToInt32(dateParts[2]),
                    Convert.ToInt32(dateParts[0]),
                    Convert.ToInt32(dateParts[1]));
                if (testDate < DateTime.Now)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
