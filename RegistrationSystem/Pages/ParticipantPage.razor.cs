
using Microsoft.AspNetCore.Components;
using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystem.Pages
{
    public partial class ParticipantPage
    {
        [Parameter]
        public Guid Id { get; set; }

        private bool IsCompany { get; set; }

        private void Save()
        {
            if (valUtil.ValidateParticipant(Participant, IsCompany)) 
            {
                ParticipantService.updateParticipant(Participant);
            } 
        }

        private void BackToLanding()
        {
            NavigationManager.NavigateTo("/", true);
        }

        private Participant? Participant { get; set; }

        protected override void OnParametersSet()
        {
            Participant = ParticipantService.getParticipantById(Id);
            if (Participant.RegistryCode != null)
            { 
                IsCompany = true;
            }
        }
    }
}