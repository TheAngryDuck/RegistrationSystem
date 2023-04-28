using RegistrationSystem.Data.Entity;
using RegistrationSystem.Data.Interface;

namespace RegistrationSystem.Data.Service
{
    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly IPaymentMethodRepository _paymentMethodRepository;

        public PaymentMethodService(IPaymentMethodRepository paymentMethodRepository)
        {
            _paymentMethodRepository = paymentMethodRepository;
        }
        public void addPaymentMethod(PaymentMethod paymentMethod)
        {
            _paymentMethodRepository.Add(paymentMethod);
        }

        public IEnumerable<PaymentMethod> getPaymentMethods()
        {
            return _paymentMethodRepository.GetAll();
        }

        public void removePaymentMethod(PaymentMethod paymentMethod)
        {
            _paymentMethodRepository.Remove(paymentMethod);
        }

        public void updatePaymentMethod(PaymentMethod paymentMethod)
        {
            _paymentMethodRepository.Update(paymentMethod);
        }
    }
}
