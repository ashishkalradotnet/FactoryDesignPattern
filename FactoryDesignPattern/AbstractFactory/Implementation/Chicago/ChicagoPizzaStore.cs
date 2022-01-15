using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            if (type.Equals("cheese", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new CheesePizza("Chicago Cheese Pizza", ingredientFactory);
            }
            else if (type.Equals("pepperoni", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new PepperoniPizza("Chicago Pepperoni Pizza", ingredientFactory);
            }
            else if (type.Equals("clam", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new ClamPizza("Chicago Clam Pizza", ingredientFactory);
            }
            else if (type.Equals("veggie", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new VeggiePizza("Chicago Veggie Pizza", ingredientFactory);
            }

            return pizza;
        }
    }
}
