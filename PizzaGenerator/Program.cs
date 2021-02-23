using System;
using System.Collections.Generic;

namespace PizzaGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //This section instantiates necessary instances of all classes and calls the methods that generate the lists of ingredients
            Crust crust = new Crust();
            Topping topping = new Topping();
            List<Crust> crusts = new List<Crust>();
            List<Topping> toppings = new List<Topping>();

            crust.ListOfCrusts(crusts);
            topping.ListOfToppings(toppings);

            //This section creates all the randomization of the ingredients
            //The while loop ensures that the same ingredient is not used twice
            Random random = new Random();
            int randomPizzaStyle = random.Next(crusts.Count);
            int randomTopping = random.Next(toppings.Count);
            int randomTopping2 = random.Next(toppings.Count);

            while (randomTopping == randomTopping2)
            {
                randomTopping2 = random.Next(toppings.Count);
            }

            //This section adds all of the randomly generated ingredients into one list that constitutes a pizza
            List<IIngredient> pizza = new List<IIngredient>();
            pizza.Add(crusts[randomPizzaStyle]);
            pizza.Add(toppings[randomTopping]);
            pizza.Add(toppings[randomTopping2]); 

            //This foreach loop accounts for the fact that the price per topping for the Sicilian Half Sheet size is different from the price per topping for all other sizes supported
            //It works by setting the price for all ingredients to the per topping price of 4, and then it resets the pizza base price to 15
            foreach (var ingredient in pizza)
            {
                if (ingredient.Name == "Sicilian Half Sheet")
                {
                    foreach (var toppingOnPizza in pizza)
                    {
                        toppingOnPizza.Price = 4;
                    }
                    ingredient.Price = 15;
                }
            }

            List<IIngredient> order = new List<IIngredient>();

            foreach (var item in pizza)
            {
                order.Add(item);
            }

            List<IIngredient> pizza2 = new List<IIngredient>();
            pizza2.Add(crusts[3]);
            pizza2.Add(toppings[5]);
            pizza2.Add(toppings[6]);

            foreach (var ingredient in pizza2)
            {
                if (ingredient.Name == "Sicilian Half Sheet")
                {
                    foreach (var toppingOnPizza in pizza2)
                    {
                        toppingOnPizza.Price = 4;
                    }
                    ingredient.Price = 15;
                }
            }

            foreach (var item in pizza2)
            {
                order.Add(item);
            }

            //This foreach loop displays which ingredients have been randomly selected and adds the price together
            int totalPrice = 0;
            foreach (var ingredient in order)
            {
                Console.WriteLine(ingredient.Name);
                //Console.WriteLine(ingredient.Price);
                totalPrice += ingredient.Price;
            }
            Console.WriteLine(totalPrice);
        }
    }
}
