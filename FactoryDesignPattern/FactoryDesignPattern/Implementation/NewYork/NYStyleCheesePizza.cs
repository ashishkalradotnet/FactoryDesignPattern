using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class NYStyleCheesePizza:Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NewYork Cheese Pizza";            
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            Toppings = new List<string>();
            Toppings.Add("Grated Reggiano Cheese");
        }
    }
}
