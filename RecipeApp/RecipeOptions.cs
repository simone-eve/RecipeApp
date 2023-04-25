using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class RecipeOptions
    {
        public void Menu() //creating the Menu method which will allow the user to input details about their recipe along with select how they alter it.
        {
            Console.WriteLine("\nWould you like to: \n1) Enter the Recipe Details \n2) View the Recipe \n3) Scale your Recipe " +
                "\n4) Reset Scale \n5) Delete Recipe \n6) Exit");
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch (menuChoice) //using a switch statement to ensure the users selected choice is run correctly.
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

        public void RecipeDetails() //creating a RecipeDetails method so that the user can input all relevant details about their recipe.
        {
            Console.WriteLine("\nPlease enter how many ingridients there are in your recipe:");
            int numIngredients = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++) //creating a loop so that the user can enter the same information for each recipe.
            {

                int ingredientOrderNum = i + 1;
                Console.WriteLine("Please enter ingridient number " + ingredientOrderNum + "s name:");
                string iName = Console.ReadLine();

                Console.WriteLine("Please enter the quantity of " + iName + " (i.e 5 for 5 spoons):");
                double iQuantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the unit of measurement used for " + iName + " (i.e tablespoons):");
                string iMeasurement = Console.ReadLine();

                RecipeLists.ingredientList.Add(new Ingredients(iName, iQuantity, iMeasurement)); //adding each piece of information that the user inputs into the list.

            }


            Console.WriteLine("\nHow many steps are there in your recipe?");
            int steps = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < steps; i++) //creating a loop so that the user can enter the same information for each recipe.
            {
                int stepNum = i + 1;
                Console.WriteLine("Please describe step number " + stepNum + ".");
                string stepDescription = Console.ReadLine();

                RecipeLists.stepList.Add(new Steps(stepDescription)); //adding each piece of information that the user inputs into the list.
            }

            Console.WriteLine("Recipe added!");

            Console.WriteLine("\n------------------------\n1)Menu \n2)Exit\n------------------------"); //enabling the user to exit the program or go back to the main method so that they can alter their data how they choose.
            int EndChoice = Convert.ToInt32(Console.ReadLine());
            if (EndChoice.Equals(1)) //using an if statement to send the user to whichever choice they make.
            {
                Menu();
            }
            else
            {
                System.Environment.Exit(0);
            }

        }





    }
}
