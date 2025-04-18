using GivingGardenBE.Models;

namespace GivingGardenBE.Interfaces
{
    public interface IPaymentTypeServices
    {
        Task<List<PaymentTypes>> GetAllPaymentTypesAsync();
        Task<PaymentTypes> GetPaymentTypeByIdAsync(int id);
        Task<PaymentTypes> AddPaymentTypeAsync(PaymentTypes paymentType);
        Task<PaymentTypes> UpdatePaymentTypeAsync(int id, PaymentTypes paymentType);
        Task<PaymentTypes> DeletePaymentTypeAsync(int id);
        Task<PaymentTypes> GetPaymentTypeById(int id);
        Task<PaymentTypes> CreatePaymentType(PaymentTypes paymentType);
        Task<PaymentTypes> DeletePaymentType(int id);
    }
}
