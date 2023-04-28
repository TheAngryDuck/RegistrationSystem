using RegistrationSystem.Data.Entity;
using System.Numerics;

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
            if(code.Length > 9 && code.Length < 12 && (long.TryParse(code, out _))) 
            {
                int firstNumber = int.Parse(code.Substring(0,1));
                if (firstNumber > 0 && firstNumber < 7)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
