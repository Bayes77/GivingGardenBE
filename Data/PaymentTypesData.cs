using GivingGardenBE.Models;

namespace GivingGardenBE.Data
{
    public class PaymentTypesData
    {
        public static List<PaymentTypes> PaymentTypes = new()
        {
            new() { Id = 1, PaymentTypeName = "Mastercard", },
            new() { Id = 2, PaymentTypeName = "PayPal", },
            new() { Id = 3, PaymentTypeName = "Visa",  },
            new() { Id = 4, PaymentTypeName = "Cryptocurrency",  },
            new() { Id = 5, PaymentTypeName = "Debit",  },
        };
    }
}
