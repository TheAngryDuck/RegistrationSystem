﻿using RegistrationSystem.Data.Entity;
using RegistrationSystem.Data.Repository;

namespace RegistrationSystem.Data.Interface
{
    public interface IEventService
    {
        IEnumerable<Event> getEvents();
        public void addEvent(Event eventOb);
        public void removeEvent(Event eventOb);
        public void updateEvent(Event eventOb);
        public Event getEventById(Guid id); 

    }
}