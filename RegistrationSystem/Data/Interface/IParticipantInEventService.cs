using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Data.Interface
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
