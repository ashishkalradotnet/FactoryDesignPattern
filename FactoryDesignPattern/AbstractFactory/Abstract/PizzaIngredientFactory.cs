using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class PizzaIngredientFactory
    {
        public abstract Dough CreateDough();
        public abstract Sauce CreateSauce();
        public abstract Cheese CreateCheese();
        public abstract Veggies[] CreateVeggies();
        public abstract Pepperoni CreatePepperoni();
        public abstract Clams CreateClam();
    }
}
