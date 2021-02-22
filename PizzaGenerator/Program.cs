using System;
using System.Collections.Generic;

namespace PizzaGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStyle pizzaStyle = new PizzaStyle();
            Topping topping = new Topping();
            List<PizzaStyle> pizzaStyles = new List<PizzaStyle>();
            List<Topping> toppings = new List<Topping>();

            pizzaStyle.ListOfPizzaStyles(pizzaStyles);
            topping.ListOfToppings(toppings);

            List<IIngredient> pizza = new List<IIngredient>();
            pizza.Add(pizzaStyles[0]);
            pizza.Add(toppings[0]);

            foreach (var item in pizza)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
            }
        }
    }
}
