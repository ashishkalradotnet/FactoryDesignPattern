using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternFromYouTubeChannel.Models.OnlineStores
{
    public interface IOnlineStore
    {
        string Name { get; }

        void OrderItem(string buyerName, string itemName);
    }
}
