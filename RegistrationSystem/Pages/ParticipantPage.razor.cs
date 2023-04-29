
using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Pages
{
    public partial class ParticipantPage
    {
        [Parameter]
        public Guid Id { get; set; }

        private void Save()
        {
            ParticipantService.updateParticipant(participant);
        }

        private void BackToLanding()
        {
            NavigationManager.NavigateTo("/", true);
        }

        private Participant participant { get; set; }

        protected override void OnParametersSet()
        {
            participant = ParticipantService.getParticipantById(Id);
        }
    }
}