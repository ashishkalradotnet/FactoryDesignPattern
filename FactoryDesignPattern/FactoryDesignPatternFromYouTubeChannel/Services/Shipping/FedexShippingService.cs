using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternFromYouTubeChannel.Services.Shipping
{
    public class FedexShippingService : IShippingService
    {
        public void ProcessOrder(string buyerName, string itemName)
        {
            Console.WriteLine($"Processing order from {buyerName} for 1 {itemName} through Fedex shipping.");
        }
    }
}
