using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Pages
{
    public partial class CreateEventPage
    {
        private void Save()
        {
            if (eventOb.Name != null && eventOb.Location != null) 
            {
                EventService.addEvent(eventOb);
                NavigationManager.NavigateTo("/", true);
            }
            
        }

        private void BackToLanding()
        {
            NavigationManager.NavigateTo("/", true);
        }

        private Event eventOb { get; set; }

        protected override void OnParametersSet()
        {
            eventOb = new Event();
            eventOb.Date = DateTime.Now;
        }
    }
}