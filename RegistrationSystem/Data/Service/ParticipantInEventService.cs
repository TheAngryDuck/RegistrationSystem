using RegistrationSystem.Data.Entity;
using RegistrationSystem.Data.Interface;

namespace RegistrationSystem.Data.Service
{
    public class ParticipantInEventService : IParticipantInEventService
    {
        private readonly IParticipantInEventRepository _participantInEventRepository;

        public ParticipantInEventService(IParticipantInEventRepository participantInEventRepository)
        {
            _participantInEventRepository = participantInEventRepository;
        }
        public void addParticipantInEvent(ParticipantInEvent participantInEvent)
        {
            _participantInEventRepository.Add(participantInEvent);
        }

        public ParticipantInEvent getParticipantInEventById(Guid id)
        {
            return _participantInEventRepository.GetById(id);
        }

        public IEnumerable<ParticipantInEvent> getParticipantsInEvents()
        {
            return _participantInEventRepository.GetAll();
        }

        public void removeParticipantInEvent(ParticipantInEvent participantInEvent)
        {
            _participantInEventRepository.Remove(participantInEvent);
        }

        public void updateParticipantInEvent(ParticipantInEvent participantInEvent)
        {
            _participantInEventRepository.Update(participantInEvent);
        }
    }
}
