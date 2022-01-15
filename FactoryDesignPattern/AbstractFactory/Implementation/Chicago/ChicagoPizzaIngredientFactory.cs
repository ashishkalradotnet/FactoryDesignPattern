using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public override Clams CreateClam()
        {
            return new FrozenClams();
        }

        public override Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public override Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public override Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public override Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new Garlic(), new RedPepper() };
            return veggies;
        }
    }
}
