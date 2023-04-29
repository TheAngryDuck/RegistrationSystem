using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;
using RegistrationSystem.Utils;

namespace RegistrationSystem.Pages
{
    public partial class EventPage
    {
        [Parameter]
        public Guid Id { get; set; }

        private Event eventOb { get; set; }

        private bool addNewParticipant { get; set; }

        private bool registerCompany { get; set; }

        private Participant participant { get; set; }

        private IEnumerable<Participant> participants { get; set; }

        private ParticipantInEvent participantInEvent { get; set; }

        private IEnumerable<PaymentMethod> paymentMethods { get; set; }

        private List<ParticipantInEvent> participantInEvents { get; set; }

        private int numberOfParticipants { get; set; }

        private EventUtils EventUtils { get; set; }

        private void SaveParticipant()
        {
            if (participant.IdCode != null && participant.Name != null && participant.FamilyName != null)
            {
                if (EventUtils.isValidIdCode(participant.IdCode))
                {
                    ParticipantService.addParticipant(participant);
                    addNewParticipant = false;
                    NavigationManager.NavigateTo("/event/" + eventOb.Id, true);
                }
            } else if(participant.RegistryCode != null && participant.Name != null)
                {
                ParticipantService.addParticipant(participant);
                addNewParticipant = false;
                NavigationManager.NavigateTo("/event/" + eventOb.Id, true);
            }
            
        }

        private void BackToLanding()
        {
            NavigationManager.NavigateTo("/", true);
        }

        private void SaveEntry()
        {
            if (participantInEvent.ParticipantId == Guid.Empty && participantInEvent.PaymentMethodId == Guid.Empty && participantInEvent.ParticipantCount > 0) 
            { 
                participantInEvent.EventId = eventOb.Id;
                ParticipantInEventService.addParticipantInEvent(participantInEvent);
                NavigationManager.NavigateTo("/event/" + eventOb.Id, true);
            }
            
        }

        private void EParticipantDeleted()
        {
            NavigationManager.NavigateTo("/event/" + eventOb.Id, true);
        }

        protected override void OnParametersSet()
        {
            eventOb = EventService.getEventById(Id);
            participant = new Participant();
            participantInEvent = new ParticipantInEvent();
            participants = new List<Participant>();
            paymentMethods = new List<PaymentMethod>();
            participantInEvents = new List<ParticipantInEvent>();
            participants = ParticipantService.getParticipants();
            paymentMethods = PaymentMethodService.getPaymentMethods();
            participantInEvents = ParticipantInEventService.GetAllRelatedToEventId(Id).ToList<ParticipantInEvent>();
            EventUtils = new EventUtils();
            numberOfParticipants = EventUtils.CountParticipants(eventOb);
        }
    }
}