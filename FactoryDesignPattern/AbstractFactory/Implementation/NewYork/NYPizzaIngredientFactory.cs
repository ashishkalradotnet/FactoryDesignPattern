using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public override Clams CreateClam()
        {
            return new FreshClams();
        }

        public override Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public override Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public override Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public override Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
