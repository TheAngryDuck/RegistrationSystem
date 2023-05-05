using RegistrationSystemDataLayer.Entity;
using RegistrationSystemDataLayer.Interface;

namespace RegistrationSystemDataLayer.Repository
{
    public class PaymentMethodRepository : GenericRepository<PaymentMethod>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(RegistrationSystemContext context) : base(context) { }
    }
}