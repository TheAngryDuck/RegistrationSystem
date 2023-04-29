using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Pages
{
    public partial class EventPage
    {
        [Parameter]
        public Guid Id { get; set; }

        private Event EventOb { get; set; }

        private bool AddNewParticipant { get; set; }

        private bool RegisterCompany { get; set; }

        private Participant Participant { get; set; }

        private IEnumerable<Participant> Participants { get; set; }

        private ParticipantInEvent ParticipantInEvent { get; set; }

        private IEnumerable<PaymentMethod> PaymentMethods { get; set; }

        private List<ParticipantInEvent> ParticipantInEvents { get; set; }

        private int numberOfParticipants { get; set; }

        private void SaveParticipant()
        {
            if (Participant.IdCode != null && Participant.Name != null && Participant.FamilyName != null)
            {
                if (util.isValidIdCode(Participant.IdCode))
                {
                    ParticipantService.addParticipant(Participant);
                    AddNewParticipant = false;
                    NavigationManager.NavigateTo("/event/" + EventOb.Id, true);
                }
            }
            else if (Participant.RegistryCode != null && Participant.Name != null)
            {
                ParticipantService.addParticipant(Participant);
                AddNewParticipant = false;
                NavigationManager.NavigateTo("/event/" + EventOb.Id, true);
            }

        }

        private void BackToLanding()
        {
            NavigationManager.NavigateTo("/", true);
        }

        private void SaveEntry()
        {
            if (ParticipantInEvent.ParticipantId == Guid.Empty && ParticipantInEvent.PaymentMethodId == Guid.Empty && ParticipantInEvent.ParticipantCount > 0)
            {
                ParticipantInEvent.EventId = EventOb.Id;
                ParticipantInEventService.addParticipantInEvent(ParticipantInEvent);
                NavigationManager.NavigateTo("/event/" + EventOb.Id, true);
            }

        }

        private void ParticipantDeleted()
        {
            NavigationManager.NavigateTo("/event/" + EventOb.Id, true);
        }

        protected override void OnParametersSet()
        {
            EventOb = EventService.getEventById(Id);
            Participant = new Participant();
            ParticipantInEvent = new ParticipantInEvent();
            Participants = new List<Participant>();
            PaymentMethods = new List<PaymentMethod>();
            ParticipantInEvents = new List<ParticipantInEvent>();
            Participants = ParticipantService.getParticipants();
            PaymentMethods = PaymentMethodService.getPaymentMethods();
            ParticipantInEvents = ParticipantInEventService.GetAllRelatedToEventId(Id).ToList<ParticipantInEvent>();
            numberOfParticipants = util.CountParticipants(EventOb);
        }
    }
}