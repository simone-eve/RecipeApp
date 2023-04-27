using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Ingredients
    {  
        //creating properties for the name, quantity and unitOfMeasurement variables.
        public string Name { get; set; }

        public double Quantity { get; set; }

        public string unitOfMeasurement { get; set; }

        public Ingredients(string name, double quantity, string unitOfMeasurement) //creating a constructor for the Ingredients class.
        {
            Name = name;
            Quantity = quantity;
            this.unitOfMeasurement = unitOfMeasurement;
        }
    }
}
