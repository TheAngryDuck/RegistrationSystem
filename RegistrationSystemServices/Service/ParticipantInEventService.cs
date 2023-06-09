﻿using RegistrationSystemDataLayer.Entity;
using RegistrationSystemDataLayer.Interface;

namespace RegistrationSystemDataLayer.Service
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

        public IEnumerable<ParticipantInEvent> GetAllRelatedToEventId(Guid id)
        {
            return _participantInEventRepository.GetAllRelatedToEventId(id);
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
