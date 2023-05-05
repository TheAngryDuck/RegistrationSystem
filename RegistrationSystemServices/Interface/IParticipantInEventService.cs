using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystemDataLayer.Interface
{
    public interface IParticipantInEventService
    {
        IEnumerable<ParticipantInEvent> getParticipantsInEvents();
        public void addParticipantInEvent(ParticipantInEvent participantInEvent);
        public void removeParticipantInEvent(ParticipantInEvent participantInEvent);
        public void updateParticipantInEvent(ParticipantInEvent participantInEvent);
        public ParticipantInEvent getParticipantInEventById(Guid id);
        public IEnumerable<ParticipantInEvent> GetAllRelatedToEventId(Guid id);
    }
}
