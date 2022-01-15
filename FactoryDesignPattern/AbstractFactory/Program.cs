using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new CaliforniaPizzaStore();

            Pizza pizza = nyStore.OrderPizza("Cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}");

            pizza = chicagoStore.OrderPizza("Cheese");
            Console.WriteLine($"Joel ordered a {pizza.GetName()}");
        }
    }
}
