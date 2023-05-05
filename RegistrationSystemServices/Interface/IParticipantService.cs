using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystemDataLayer.Interface
{
    public interface IParticipantService
    {
        IEnumerable<Participant> getParticipants();
        public void addParticipant(Participant participant);
        public void removeParticipant(Participant participant);
        public void updateParticipant(Participant participant);
        public Participant getParticipantById(Guid id);
    }
}
