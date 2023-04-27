namespace RegistrationSystem.Data.Entity
{
    public class ParticipantInEvent
    {
        public Guid Id { get; set; }

        public Participant Participant { get; set; }

        public Guid ParticipantId { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public Guid PaymentMethodId { get; set; }

        public Event Event { get; set; }

        public Guid EventId { get; set; }

        public int ParticipantCount { get; set; }

        public string? Notes { get; set; }
    }
}
