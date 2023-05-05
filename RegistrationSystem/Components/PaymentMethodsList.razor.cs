
using Microsoft.AspNetCore.Components;
using RegistrationSystemDataLayer.Entity;
using RegistrationSystemDataLayer.Service;

namespace RegistrationSystem.Components
{
    public partial class PaymentMethodsList
    {
        [Parameter]
        public List<PaymentMethod>? PaymentMethods { get; set; }

        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public EventCallback OnMethodRemoved { get; set; }

        private void MethodRemoved()
        {
            OnMethodRemoved.InvokeAsync();
        }

        private void DeleteMethod()
        {
            OnMethodRemoved.InvokeAsync();
        }
    }
}