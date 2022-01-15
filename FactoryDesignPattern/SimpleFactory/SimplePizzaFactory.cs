using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("pepperoni", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("clam", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new ClamPizza();
            }
            else if (type.Equals("veggie", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new VeggiePizza();
            }
            return pizza;
        }
    }
}
