
using Microsoft.AspNetCore.Components;

namespace RegistrationSystem.Pages
{
    public partial class Index
    {
        private List<Data.Entity.Event>? futureEvents { get; set; }

        private List<Data.Entity.Event>? pastEvents { get; set; }

        private void EventDeleted()
        {
            NavigationManager.NavigateTo("/", true);
        }

        protected override void OnInitialized()
        {
            futureEvents = new List<Data.Entity.Event>();   
            pastEvents = new List<Data.Entity.Event>(); 

            //var eventOb = new Data.Entity.Event();
            //eventOb.Location = "Tallinn";
            //eventOb.Name = "eventFuture";
            //eventOb.Date = DateTime.Now;
            //eventOb.Date = eventOb.Date.AddYears(1);
            // EventService.addEvent(eventOb);
            var events = EventService.getEvents();
            foreach ( var e in events ) 
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
