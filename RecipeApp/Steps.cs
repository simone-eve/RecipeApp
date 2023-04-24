using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class Steps
    {
        public string Description { get; set; }

        public Steps(string description)
        {
            this.Description = description;
        }
    }
}
