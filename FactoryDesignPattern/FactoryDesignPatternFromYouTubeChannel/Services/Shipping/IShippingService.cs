using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternFromYouTubeChannel.Services.Shipping
{
    public interface IShippingService
    {
        void ProcessOrder(string buyerName, string itemName);
    }
}
