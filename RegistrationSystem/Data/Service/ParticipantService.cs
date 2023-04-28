using RegistrationSystem.Data.Entity;
using RegistrationSystem.Data.Interface;

namespace RegistrationSystem.Data.Service
{
    public class ParticipantService : IParticipantService
    {
        private readonly IParticipantRepository _participantRepository;

        public ParticipantService(IParticipantRepository participantRepository)
        {
            _participantRepository = participantRepository;
        }

        public void addParticipant(Participant participant)
        {
            _participantRepository.Add(participant);
        }

        public IEnumerable<Participant> getParticipants()
        {
            return _participantRepository.GetAll();
        }

        public void removeParticipant(Participant participant)
        {
            _participantRepository.Remove(participant);
        }

        public void updateParticipant(Participant participant)
        {
            _participantRepository.Update(participant);
        }
        public Participant getParticipantById(Guid id)
        {
            return _participantRepository.GetById(id);
        }
    }
}
