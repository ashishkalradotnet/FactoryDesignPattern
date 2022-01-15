using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CaliforniaPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Cheese CreateCheese()
        {
            return new GoatCheese();
        }

        public override Clams CreateClam()
        {
            return new CalamariClams();
        }

        public override Dough CreateDough()
        {
            return new VeryThinCrustDough();
        }

        public override Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public override Sauce CreateSauce()
        {
            return new BruschettaSauce();
        }

        public override Veggies[] CreateVeggies()
        {
            Veggies[] veggies = { new RedPepper() };
            return veggies;
        }
    }
}
