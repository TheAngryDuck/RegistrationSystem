using RegistrationSystem.Data.Entity;
using RegistrationSystem.Data.Interface;

namespace RegistrationSystem.Data.Repository
{
    public class PaymentMethodRepository : GenericRepository<PaymentMethod>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(RegistrationSystemContext context) : base(context) 
        {
        }
    }
}