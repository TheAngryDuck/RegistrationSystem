using RegistrationSystem.Data.Entity;
using RegistrationSystem.Data.Interface;

namespace RegistrationSystem.Data.Service
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public IEnumerable<Event> getEvents()
        {
            return _eventRepository.GetAll();
        }

        public void addEvent(Event eventOb) 
        {
            _eventRepository.Add(eventOb);
        }

        public void removeEvent(Event eventOb)
        {
            _eventRepository.Remove(eventOb);
        }

        public void updateEvent(Event eventOb)
        {
            _eventRepository.Update(eventOb);
        }

        public Event getEventById(Guid id)
        {
          return  _eventRepository.GetById(id);
        }
    }
}
