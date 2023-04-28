using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Components
{
    public partial class EventListElement
    {

        [Parameter]
        public Event eventOb { get; set; }

        [Parameter]
        public EventCallback OnEventDeleted { get; set; }

        private void NavigateToEvent()
        {
            NavigationManager.NavigateTo("/event/" + eventOb.Id, false);
        }

        private void DeleteEvent() 
        {
            EventService.removeEvent(eventOb);
            OnEventDeleted.InvokeAsync();
        }
    }
}