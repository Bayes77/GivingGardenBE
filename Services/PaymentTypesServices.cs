using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Services
{
    public class PaymentTypesServices : IPaymentTypesServices
    {
        private readonly IPaymentTypeServices _paymentTypesRepository;
        public PaymentTypesServices(IPaymentTypeServices paymentTypesRepository)
        {
            _paymentTypesRepository = paymentTypesRepository;
        }

        public async Task<PaymentTypes> CreatePaymentType(PaymentTypes paymentType)
        {
           return await _paymentTypesRepository.CreatePaymentType(paymentType);
        }

        public async Task<PaymentTypes> DeletePaymentType(int id)
        {
            return await _paymentTypesRepository.DeletePaymentType(id);
        }

        public async Task<List<PaymentTypes>> GetAllPaymentTypes()
        {
           return await _paymentTypesRepository.GetAllPaymentTypes();
        }

        public async Task<PaymentTypes> GetPaymentTypeById(int id)
        {
            return await _paymentTypesRepository.GetPaymentTypeById(id);
        }

        public async Task<PaymentTypes> UpdatePaymentType(int id, PaymentTypes paymentType)
        {
          return await _paymentTypesRepository.UpdatePaymentType(id, paymentType);
        }
    }
}
