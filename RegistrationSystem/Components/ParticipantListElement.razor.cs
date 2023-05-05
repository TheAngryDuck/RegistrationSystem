using Microsoft.AspNetCore.Components;
using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystem.Components
{
    public partial class ParticipantListElement
    {


        [Parameter]
        public ParticipantInEvent participant { get; set; }

        [Parameter]
        public EventCallback OnParticipantRemoved { get; set; }

        private void NavigateToParticipant()
        {
            NavigationManager.NavigateTo("/participant/" + participant.Participant.Id, false);
        }

        private void DeleteParticipant()
        {
            ParticipantInEventService.removeParticipantInEvent(participant);
            OnParticipantRemoved.InvokeAsync();
        }
    }
}