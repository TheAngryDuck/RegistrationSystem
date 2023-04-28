using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Data.Interface
{
    public interface IParticipantService
    {
        IEnumerable<Participant> getParticipants();
        public void addParticipant(Participant participant);
        public void removeParticipant(Participant participant);
        public void updateParticipant(Participant participant);
    }
}
