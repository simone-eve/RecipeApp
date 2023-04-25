using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class RecipeOptions
    {
        public void Menu()
        {
            Console.WriteLine("\nWould you like to: \n1) Enter the Recipe Details \n2) View the Recipe \n3) Scale your Recipe " +
                "\n4) Reset Scale \n5) Delete Recipe \n6) Exit");
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice)
            {
                case 1:
                    RecipeDetails();
                    break;

                case 2:
                    ViewRecipe();
                    break;


                case 3:
                    ScaleRecipe();
                    break;

                case 4:
                    ConvertToOriginalQuantity();
                    break;

                case 5:
                    DeleteRecipe();
                    break;

                case 6:
                    System.Environment.Exit(0);
                    break;
            }



        }
    }
}
