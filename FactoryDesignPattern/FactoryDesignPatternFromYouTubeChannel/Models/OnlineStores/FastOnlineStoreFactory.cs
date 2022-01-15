using FactoryDesignPatternFromYouTubeChannel.Services.Accelerators;
using FactoryDesignPatternFromYouTubeChannel.Services.Payment;
using FactoryDesignPatternFromYouTubeChannel.Services.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternFromYouTubeChannel.Models.OnlineStores
{
    public class FastOnlineStoreFactory : IOnlineStoreFactory
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;
        private readonly OrderAccelerationService _accelerationStore;

        public FastOnlineStoreFactory(IPaymentService paymentService,
            IShippingService shippingService,
            OrderAccelerationService accelerationStore)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
            _accelerationStore = accelerationStore;
        }

        public IOnlineStore CreateOnlineStore(string name)
        {
            return new FastOnlineStore(name, _paymentService, _shippingService, _accelerationStore);
        }
    }
}
