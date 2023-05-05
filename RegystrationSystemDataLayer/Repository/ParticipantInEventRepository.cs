using RegistrationSystemDataLayer.Entity;
using RegistrationSystemDataLayer.Interface;

namespace RegistrationSystemDataLayer.Repository
{
    public class ParticipantInEventRepository : GenericRepository<ParticipantInEvent>, IParticipantInEventRepository
    {
        public ParticipantInEventRepository(RegistrationSystemContext context) : base(context) { }

        public IEnumerable<ParticipantInEvent> GetAllRelatedToEventId(Guid id)
        {
            return _context.ParticipansInEvents.Where(p => p.EventId == id).ToList();
        }
    }
}