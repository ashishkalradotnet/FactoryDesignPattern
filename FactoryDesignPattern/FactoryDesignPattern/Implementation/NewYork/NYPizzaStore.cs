using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {           
            Pizza pizza = null;

            if (type.Equals("cheese", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type.Equals("pepperoni", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new NYStylePepperoniPizza();
            }
            else if (type.Equals("clam", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new NYStyleClamPizza();
            }
            else if (type.Equals("veggie", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new NYStyleVeggiePizza();
            }

            return pizza;
        }
    }
}
