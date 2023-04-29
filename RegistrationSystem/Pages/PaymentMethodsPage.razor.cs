
using Microsoft.AspNetCore.Components;
using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Pages
{
    public partial class PaymentMethodsPage
    {

        private void Save()
            {
                if (PaymentMethod.Name != null)
                {
                    PaymentMethodService.addPaymentMethod(PaymentMethod);
                    NavigationManager.NavigateTo("/payment", true);
                }
            }

        private PaymentMethod PaymentMethod { get; set; }

        private List<PaymentMethod> PaymentMethods { get; set; }

        private void PaymentDeleted()
        {
            NavigationManager.NavigateTo("/payment", true);
        }

        protected override void OnParametersSet()
            {
            PaymentMethod = new PaymentMethod();
            PaymentMethods = new List<PaymentMethod>();
            PaymentMethods = PaymentMethodService.getPaymentMethods().ToList();
            }    
    }
}