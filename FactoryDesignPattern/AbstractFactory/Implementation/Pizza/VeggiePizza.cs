using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(string name,PizzaIngredientFactory ingredientFactory):base(ingredientFactory)
        {
            Name = name;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }
    }
}
