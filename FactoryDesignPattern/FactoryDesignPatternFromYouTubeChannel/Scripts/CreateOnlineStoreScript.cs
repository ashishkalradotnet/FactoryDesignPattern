using FactoryDesignPatternFromYouTubeChannel.Models.OnlineStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternFromYouTubeChannel.Scripts
{
    public class CreateOnlineStoreScript
    {
        private readonly IOnlineStoreFactory _onlineStoreFactory;

        public CreateOnlineStoreScript(IOnlineStoreFactory onlineStoreFactory)
        {
            _onlineStoreFactory = onlineStoreFactory;
        }

        public IOnlineStore Run()
        {
            Console.Write("Enter your new online store's name: ");
            string storeName = Console.ReadLine();

            IOnlineStore store = _onlineStoreFactory.CreateOnlineStore(storeName);

            return store;
        }
    }
}
