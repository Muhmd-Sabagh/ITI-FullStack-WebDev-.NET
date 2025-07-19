using CarAPI.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAPITests.Fake
{
    internal class FakePaymentService : IPaymentService
    {
        public string Pay(double amount)
        {
            return $"{amount} is succesfully paid";
        }
    }
}
