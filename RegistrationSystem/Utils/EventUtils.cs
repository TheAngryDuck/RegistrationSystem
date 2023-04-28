using RegistrationSystem.Data.Entity;

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
    }
}
