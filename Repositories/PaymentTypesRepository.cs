using GivingGardenBE.Data;
using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;
using GivingGardenBE.Services;
using Microsoft.EntityFrameworkCore;

namespace GivingGardenBE.Repositories
{
    public class PaymentTypesRepository : IPaymentTypeServices
    {
        private readonly GivingGardenBEDbContext _context;
        public PaymentTypesRepository(GivingGardenBEDbContext context)
        {
            _context = context;
        }

        public async Task<List<PaymentTypes>> GetAllPaymentTypes()
        {
            return await _context.PaymentTypes.ToListAsync();
        }

        public async Task<PaymentTypes> CreatePaymentType(PaymentTypes paymentType)
        {
            _context.PaymentTypes.Add(paymentType);
            await _context.SaveChangesAsync();
            return paymentType;
        }

        public async Task<PaymentTypes> DeletePaymentType(int id)
        {
            var paymentType = await _context.PaymentTypes.FindAsync(id);
            if (paymentType == null)
            {
                return null;
            }
            _context.PaymentTypes.Remove(paymentType);
            await _context.SaveChangesAsync();
            return paymentType;
        }

        public async Task<PaymentTypes> GetPaymentTypeById(int id)
        {
            return await _context.PaymentTypes.FindAsync(id);
        }

        public async Task<PaymentTypes> UpdatePaymentType(int id, PaymentTypes paymentType)
        {
            var exsistingPaymentType = _context.PaymentTypes.Find(id);
            if (exsistingPaymentType == null)
            {
                return null;
            }
            exsistingPaymentType.PaymentTypeName = paymentType.PaymentTypeName;
            await _context.SaveChangesAsync();
            return exsistingPaymentType;
        }
    }
    

    
}
