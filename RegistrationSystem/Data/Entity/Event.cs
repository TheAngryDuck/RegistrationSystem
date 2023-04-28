namespace RegistrationSystem.Data.Entity
{
    public class Event
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public string? Notes { get; set; }

        public List<ParticipantInEvent>? Participants { get; set; }
    }
}
