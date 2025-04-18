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
        public async Task<PaymentTypes> AddPaymentTypeAsync(PaymentTypes paymentType)
        {
                return await _paymentTypesRepository.AddPaymentTypeAsync(paymentType);
        }

        public async Task<PaymentTypes> DeletePaymentTypeAsync(int id)
        {
            return await _paymentTypesRepository.DeletePaymentTypeAsync(id);    
        }

        public async Task<List<PaymentTypes>> GetAllPaymentTypesAsync()
        {
           return await _paymentTypesRepository.GetAllPaymentTypesAsync();
        }

        public async Task<PaymentTypes> GetPaymentTypeByIdAsync(int id)
        {
            return await _paymentTypesRepository.GetPaymentTypeByIdAsync(id);
        }

        public async Task<PaymentTypes> UpdatePaymentTypeAsync(int id, PaymentTypes paymentType)
        {
            return await _paymentTypesRepository.UpdatePaymentTypeAsync(id, paymentType);
        }
    }
}
