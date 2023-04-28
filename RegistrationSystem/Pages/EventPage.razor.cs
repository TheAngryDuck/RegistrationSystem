using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Pages
{
    public partial class EventPage
    {
        [Parameter]
        public Guid Id { get; set; }

        private Event eventOb { get; set; }

        protected override void OnParametersSet()
        {
            eventOb = EventService.getEventById(Id);
        }
    }
}