using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternFromYouTubeChannel.Models.OnlineStores
{
    public interface IOnlineStoreFactory
    {
        IOnlineStore CreateOnlineStore(string name);
    }
}
