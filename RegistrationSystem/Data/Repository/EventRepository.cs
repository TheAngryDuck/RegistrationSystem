using System;
using RegistrationSystem.Data.Entity;
using RegistrationSystem.Data.Interface;

namespace RegistrationSystem.Data.Repository
{

    public class EventRepository : GenericRepository<Event>, IEventEventRepository
    {
        public EventRepository(RegistrationSystemContext context) : base(context)
        {
        }
    }
}
