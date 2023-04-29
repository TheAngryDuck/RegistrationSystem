using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Data.Interface
{
    public interface IParticipantInEventRepository : IGenericRepository<ParticipantInEvent>
    {
        IEnumerable<ParticipantInEvent> GetAllRelatedToEventId(Guid id);
    }
}
