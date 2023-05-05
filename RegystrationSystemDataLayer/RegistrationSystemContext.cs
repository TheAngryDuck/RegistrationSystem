using Microsoft.EntityFrameworkCore;
using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystemDataLayer
{
    public class RegistrationSystemContext : DbContext
    {
        public RegistrationSystemContext(DbContextOptions<RegistrationSystemContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }

        public DbSet<Participant> Participants { get; set; }

        public DbSet<PaymentMethod> PaymentMethods { get; set; }

        public DbSet<ParticipantInEvent> ParticipansInEvents { get; set; }
    }
}
