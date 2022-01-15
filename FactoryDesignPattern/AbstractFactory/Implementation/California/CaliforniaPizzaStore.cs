using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new CaliforniaPizzaIngredientFactory();

            if (type.Equals("cheese", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new CheesePizza("California Cheese Pizza", ingredientFactory);
            }
            else if (type.Equals("pepperoni", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new PepperoniPizza("California Pepperoni Pizza", ingredientFactory);
            }
            else if (type.Equals("clam", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new ClamPizza("California Clam Pizza", ingredientFactory);
            }
            else if (type.Equals("veggie", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new VeggiePizza("California Veggie Pizza", ingredientFactory);
            }

            return pizza;
        }
    }
}
