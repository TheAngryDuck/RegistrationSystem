using RegistrationSystemDataLayer.Entity;
using RegistrationSystemDataLayer.Interface;

namespace RegistrationSystemDataLayer.Repository
{
    public class EventRepository : GenericRepository<Event>, IEventRepository
    {
        public EventRepository(RegistrationSystemContext context) : base(context) { }
    }
}
