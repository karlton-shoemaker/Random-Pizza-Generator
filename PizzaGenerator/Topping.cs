using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaGenerator
{
    class Topping : IIngredient
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Topping(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public Topping()
        {

        }

        public List<Topping> ListOfToppings(List<Topping> toppings)
        {
            toppings.Add(new Topping("Hickory Smoked Bacon", 2));
            toppings.Add(new Topping("Cup and Char Pepperoni", 2));

            return toppings;
        }
    }
}
