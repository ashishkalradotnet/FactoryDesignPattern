using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternFromYouTubeChannel.Services.Payment
{
    public class BasicPaymentService : IPaymentService
    {
        public void ProcessPayment(string buyerName)
        {
            Console.WriteLine($"Processing payment for {buyerName}.");
        }
    }
}
