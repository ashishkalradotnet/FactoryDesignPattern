using FactoryDesignPatternFromYouTubeChannel.Models.OnlineStores;
using FactoryDesignPatternFromYouTubeChannel.Scripts;
using FactoryDesignPatternFromYouTubeChannel.Services.Accelerators;
using FactoryDesignPatternFromYouTubeChannel.Services.Payment;
using FactoryDesignPatternFromYouTubeChannel.Services.Shipping;
using System;

namespace FactoryDesignPatternFromYouTubeChannel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup dependencies.
            IPaymentService paymentService = new BasicPaymentService();
            IShippingService shippingService = new FedexShippingService();
            OrderAccelerationService accelerationService = new OrderAccelerationService();
            IOnlineStoreFactory onlineStoreFactory = new FastOnlineStoreFactory(paymentService, shippingService,accelerationService);

            // Setup scripts.
            CreateOnlineStoreScript createScript = new CreateOnlineStoreScript(onlineStoreFactory);
            UpdateOnlineStoreScript updateScript = new UpdateOnlineStoreScript(onlineStoreFactory);

            // Execute create script.
            IOnlineStore store = createScript.Run();
            store.OrderItem("Ashish", "Motherboard");

            // Execute update script.
            store = updateScript.Run();
            store.OrderItem("Ashish", "CPU");
        }
    }
}
