
using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Components
{
    public partial class EventList
    {
        [Parameter]
        public List<Event>? Events { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public bool IsFutureList { get; set; }

        [Parameter]
        public EventCallback OnEventDeleted { get; set; }

        private void EventDeleted()
        {
            OnEventDeleted.InvokeAsync();
        }
    }
}