using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystemDataLayer.Interface
{
    public interface IParticipantInEventRepository : IGenericRepository<ParticipantInEvent>
    {
        IEnumerable<ParticipantInEvent> GetAllRelatedToEventId(Guid id);
    }
}
