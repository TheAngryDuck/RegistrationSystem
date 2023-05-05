using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystem.Utils
{
    public class EventUtils
    {
        public int CountParticipants(Event eventOb)
        {
            var count = 0;

            if (eventOb.Participants != null)
            {
                foreach (var participant in eventOb.Participants)
                {
                    count = count + participant.ParticipantCount;
                }
            }

            return count;
        }

        public bool isValidIdCode(string code)
        {
            var isValid = false;
            if (code.Length > 9 && code.Length < 12 && (long.TryParse(code, out _)))
            {
                int firstNumber = int.Parse(code.Substring(0, 1));
                var year = code.Substring(1, 2);
                var month =code.Substring(3, 2);
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
