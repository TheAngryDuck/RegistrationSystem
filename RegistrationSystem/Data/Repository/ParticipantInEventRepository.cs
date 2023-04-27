using RegistrationSystem.Data.Entity;
using RegistrationSystem.Data.Interface;

namespace RegistrationSystem.Data.Repository
{
    public class ParticipantInEventRepository : GenericRepository<ParticipantInEvent>, IParticipantInEventRepository
    {
        public ParticipantInEventRepository(RegistrationSystemContext context) : base(context)
        {
        }
    }
}