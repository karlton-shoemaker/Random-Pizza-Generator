using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaGenerator
{
    class PizzaStyle : IIngredient
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public PizzaStyle()
        {

        }

        public PizzaStyle(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public List<PizzaStyle> ListOfPizzaStyles(List<PizzaStyle> pizzaStyles)
        {
            pizzaStyles.Add(new PizzaStyle("American Pan", 10));
            pizzaStyles.Add(new PizzaStyle("Detroit Crunch", 10));
            pizzaStyles.Add(new PizzaStyle("Thin & Square", 10));

            return pizzaStyles;
        }
    }
}
