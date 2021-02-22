using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaGenerator
{
    class PizzaStyle : IIngredient
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int PricePerTopping { get; set; }

        public PizzaStyle()
        {

        }

        public PizzaStyle(string name, int price, int pricePerTopping)
        {
            Name = name;
            Price = price;
            PricePerTopping = pricePerTopping;
        }

        public List<PizzaStyle> ListOfPizzaStyles(List<PizzaStyle> pizzaStyles)
        {
            pizzaStyles.Add(new PizzaStyle("American Pan", 10, 2));
            pizzaStyles.Add(new PizzaStyle("Detroit Crunch", 10, 2));
            pizzaStyles.Add(new PizzaStyle("Thin & Square", 10, 2));
            pizzaStyles.Add(new PizzaStyle("Sicilian Half Sheet", 15, 4));

            return pizzaStyles;
        }
    }
}
