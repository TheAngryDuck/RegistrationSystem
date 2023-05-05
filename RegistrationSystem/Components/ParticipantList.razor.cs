using Microsoft.AspNetCore.Components;
using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystem.Components
{
    public partial class ParticipantList
    {
        [Parameter]
        public List<ParticipantInEvent>? participantInEvents { get; set; }

        [Parameter]
        public EventCallback OnParticipantRemoved { get; set; }

        private void ParticipantRemoved()
        {
            OnParticipantRemoved.InvokeAsync();
        }

    }
}