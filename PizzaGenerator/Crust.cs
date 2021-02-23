using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaGenerator
{
    class Crust : IIngredient
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int PricePerTopping { get; set; }

        public Crust()
        {

        }

        public Crust(string name, int price, int pricePerTopping)
        {
            Name = name;
            Price = price;
            PricePerTopping = pricePerTopping;
        }

        public List<Crust> ListOfCrusts(List<Crust> crusts)
        {
            crusts.Add(new Crust("American Pan", 10, 2));
            crusts.Add(new Crust("Detroit Crunch", 10, 2));
            crusts.Add(new Crust("Thin & Square", 10, 2));
            crusts.Add(new Crust("Sicilian Half Sheet", 15, 4));

            return crusts;
        }
    }
}
