using GivingGardenBE.Models;

namespace GivingGardenBE.Interfaces
{
    public interface IPaymentTypeServices
    {
        Task<List<PaymentTypes>> GetAllPaymentTypes();
        Task<PaymentTypes> GetPaymentTypeById(int id);
        Task<PaymentTypes> UpdatePaymentType(int id, PaymentTypes paymentType);
        Task<PaymentTypes> DeletePaymentType(int id);
        Task<PaymentTypes> CreatePaymentType(PaymentTypes paymentType);
        
    }
}
