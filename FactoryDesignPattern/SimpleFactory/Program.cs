using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(pizzaFactory);

            Pizza pizza=store.OrderPizza("veggie");

            Console.WriteLine(pizza.getName());
        }
    }
}
