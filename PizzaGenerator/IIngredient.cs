using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaGenerator
{
    interface IIngredient
    {
        string Name { get; set; }
        int Price { get; set; }
    }
}
