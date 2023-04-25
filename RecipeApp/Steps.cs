using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Steps
    {
        public string Description { get; set; } //creating properties for the description variable.

        public Steps(string description) //creating a constructor for the Steps class.
        {
            this.Description = description;
        }
    }
}
