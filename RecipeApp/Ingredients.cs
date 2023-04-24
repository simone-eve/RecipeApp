using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Ingredients
    {
        public string Name { get; set; }

        public double Quantity { get; set; }

        public string unitOfMeasurement { get; set; }

        public Ingredients(string name, double quantity, string unitOfMeasurement)
        {
            Name = name;
            Quantity = quantity;
            this.unitOfMeasurement = unitOfMeasurement;
        }
    }
}
