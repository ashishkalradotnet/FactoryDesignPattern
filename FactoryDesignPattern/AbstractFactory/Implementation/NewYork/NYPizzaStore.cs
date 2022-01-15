using System;
using System.Collections.Generic;
using System.Linq;
namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("cheese", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new CheesePizza("NewYork Cheese Pizza", ingredientFactory);
            }
            else if (type.Equals("pepperoni", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new PepperoniPizza("NewYork Pepperoni Pizza", ingredientFactory);
            }
            else if (type.Equals("clam", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new ClamPizza("NewYork Clam Pizza", ingredientFactory);
            }
            else if (type.Equals("veggie", StringComparison.CurrentCultureIgnoreCase))
            {
                pizza = new VeggiePizza("NewYork Veggie Pizza", ingredientFactory);
            }

            return pizza;
        }
    }
}
