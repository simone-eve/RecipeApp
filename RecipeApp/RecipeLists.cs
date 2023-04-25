using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class RecipeLists
    {  //creating a List for Ingredients and for Steps in order to save the data the user inputs.
        public static List<Ingredients> ingredientList = new List<Ingredients>();
        public static List<Steps> stepList = new List<Steps>();
    }
}
