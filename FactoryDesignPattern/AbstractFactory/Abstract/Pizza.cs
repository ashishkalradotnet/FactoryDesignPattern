using System;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        protected readonly PizzaIngredientFactory _ingredientFactory;
        protected string Name { get; set; }
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }
        protected Veggies[] Veggies;
        protected Cheese Cheese;
        protected Pepperoni Pepperoni;
        protected Clams Clam;

        public Pizza(PizzaIngredientFactory pizzaIngredientFactory)
        {
            _ingredientFactory = pizzaIngredientFactory;
        }

        public abstract void Prepare();
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return Name;
        }
    }
}
