
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
            ParticipantService.updateParticipant(Participant);
        }

        private void BackToLanding()
        {
            NavigationManager.NavigateTo("/", true);
        }

        private Participant? Participant { get; set; }

        protected override void OnParametersSet()
        {
            Participant = ParticipantService.getParticipantById(Id);
        }
    }
}