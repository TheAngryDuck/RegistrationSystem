
using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Components
{
    public partial class EventList
    {
        [Parameter]
        public List<Event>? events { get; set; }

        [Parameter]
        public string title { get; set; }

        [Parameter]
        public bool isFutureList { get; set; }

        [Parameter]
        public EventCallback OnEventDeleted { get; set; }

        private void EventDeleted()
        {
            OnEventDeleted.InvokeAsync();
        }
    }
}