using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternFromYouTubeChannel.Services.Payment
{
    public interface IPaymentService
    {
        void ProcessPayment(string buyerName);
    }
}
