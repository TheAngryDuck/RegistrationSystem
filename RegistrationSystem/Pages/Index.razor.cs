
using Microsoft.AspNetCore.Components;
using RegistrationSystemDataLayer.Entity;

namespace RegistrationSystem.Pages
{
    public partial class Index
    {
        private List<Event>? futureEvents { get; set; }

        private List<Event>? pastEvents { get; set; }

        private void EventDeleted()
        {
            NavigationManager.NavigateTo("/", true);
        }

        protected override void OnInitialized()
        {
            futureEvents = new List<Event>();
            pastEvents = new List<Event>();
            var events = EventService.getEvents();
            foreach (var e in events)
            {
                if (DateTime.Compare(e.Date, DateTime.Now) < 0)
                {
                    pastEvents.Add(e);
                }
                else
                {
                    futureEvents.Add(e);
                }
            }
        }
    }
}
