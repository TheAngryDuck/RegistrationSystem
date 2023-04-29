namespace RegistrationSystem.Data.Entity
{
    public class Participant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? FamilyName { get; set; }
        public string? IdCode { get; set; }
        public string? RegistryCode { get; set; }
    }
}
