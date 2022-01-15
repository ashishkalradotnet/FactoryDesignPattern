using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {                        
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("Cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}");

            pizza = chicagoStore.OrderPizza("Cheese");
            Console.WriteLine($"Joel ordered a {pizza.GetName()}");
        }
    }
}
