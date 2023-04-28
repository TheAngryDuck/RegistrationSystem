using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Components
{
    public partial class ParticipantList
    {
        [Parameter]
        public IEnumerable<ParticipantInEvent>? participantInEvents { get; set; }

        [Parameter]
        public EventCallback OnParticipantRemoved { get; set; }

        private void ParticipantRemoved()
        {
            OnParticipantRemoved.InvokeAsync();
        }

    }
}