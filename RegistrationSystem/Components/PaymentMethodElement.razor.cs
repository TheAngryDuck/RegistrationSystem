
using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Components
{
    public partial class PaymentMethodElement
    {
        [Parameter]
        public PaymentMethod PaymentMethod { get; set; }

        [Parameter]
        public EventCallback OnParticipantRemoved { get; set; }

        private void DeleteMethod()
        {
            PaymentMethodService.removePaymentMethod(PaymentMethod);
            OnParticipantRemoved.InvokeAsync();
        }
    }
}