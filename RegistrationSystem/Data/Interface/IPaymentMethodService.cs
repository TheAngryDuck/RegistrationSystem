using RegistrationSystem.Data.Entity;

namespace RegistrationSystem.Data.Interface
{
    public interface IPaymentMethodService
    {
        IEnumerable<PaymentMethod> getPaymentMethods();
        public void addPaymentMethod(PaymentMethod paymentMethod);
        public void removePaymentMethod(PaymentMethod paymentMethod);
        public void updatePaymentMethod(PaymentMethod paymentMethod);
    }
}
