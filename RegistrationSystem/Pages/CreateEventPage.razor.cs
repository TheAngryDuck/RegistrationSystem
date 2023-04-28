using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;
using RegistrationSystem.Data.Service;

namespace RegistrationSystem.Pages
{
    public partial class CreateEventPage
    {
        private void Save()
        {
            EventService.addEvent(eventOb);
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