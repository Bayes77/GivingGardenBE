using GivingGardenBE.Data;
using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;
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

        public async Task<PaymentTypes> AddPaymentTypeAsync(PaymentTypes paymentType)
        {
            var entityEntry = await _context.PaymentTypes.AddAsync(paymentType);
            await _context.SaveChangesAsync(); // Ensure changes are saved to the database
            return entityEntry.Entity; // Return the added PaymentTypes entity
        }

        public async Task<PaymentTypes> DeletePaymentTypeAsync(int id)
        {
            var paymentType = await _context.PaymentTypes.FindAsync(id);
            if (paymentType == null)
            {
                throw new Exception("Payment type not found");
            }
            _context.PaymentTypes.Remove(paymentType);
            await _context.SaveChangesAsync();
            return paymentType; 


        }

        public async Task<List<PaymentTypes>> GetAllPaymentTypesAsync()
        {
          return await _context.PaymentTypes.ToListAsync();
        }

        public async Task<PaymentTypes> GetPaymentTypeByIdAsync(int id)
        {
           return await _context.PaymentTypes.FindAsync(id);
        }

        public Task<PaymentTypes> UpdatePaymentTypeAsync(int id, PaymentTypes paymentType)
        {
           var exsistingPaymentType = _context.PaymentTypes.Find(id);
            if (exsistingPaymentType == null)
            {
                throw new Exception("Payment type not found");
            }
            exsistingPaymentType.PaymentTypeName = paymentType.PaymentTypeName;
            _context.SaveChanges();
            return Task.FromResult(exsistingPaymentType);
        }
      

    }
    

    
}
