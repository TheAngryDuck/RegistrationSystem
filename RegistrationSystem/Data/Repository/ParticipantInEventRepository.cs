using RegistrationSystem.Data.Entity;
using RegistrationSystem.Data.Interface;

namespace RegistrationSystem.Data.Repository
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