using FactoryDesignPatternFromYouTubeChannel.Services.Payment;
using FactoryDesignPatternFromYouTubeChannel.Services.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternFromYouTubeChannel.Models.OnlineStores
{
    public class BasicOnlineStoreFactory : IOnlineStoreFactory
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public BasicOnlineStoreFactory(IPaymentService paymentService, IShippingService shippingService)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public IOnlineStore CreateOnlineStore(string name)
        {
            return new BasicOnlineStore(name, _paymentService, _shippingService);
        }
    }
}
