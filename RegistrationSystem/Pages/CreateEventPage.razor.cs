using Microsoft.AspNetCore.Components;
using RegistrationSystem.Utils;
using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystem.Pages
{
    public partial class CreateEventPage
    {
        private void Save()
        {
            if (util.ValidateEvent(EventOb))
            {
                EventService.addEvent(EventOb);
                NavigationManager.NavigateTo("/", true);
            }
        }

        private void BackToLanding()
        {
            NavigationManager.NavigateTo("/", true);
        }

        private Event EventOb { get; set; }

        protected override void OnParametersSet()
        {
            EventOb = new Event();
            EventOb.Date = DateTime.Now;
        }
    }
}