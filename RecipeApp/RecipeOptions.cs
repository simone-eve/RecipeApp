using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    internal class RecipeOptions
    {
        int scaleNumber = 0;
        int EndChoice = 0;
        string recipeName = "";
        public void RecipeName()
        {
            Console.WriteLine("PLease enter your recipes name:");
            recipeName = Console.ReadLine(); 
        
        }

        public void Menu() //creating the Menu method which will allow the user to input details about their recipe along with select how they alter it.
        {
            int menuChoice = 0;
            do
            {
                try //using a try-catch statement to ensure that the application does not fail if the user inputs the wrong data.
                {
                    Console.ForegroundColor = ConsoleColor.Magenta; //adding colour to text.
                    Console.WriteLine("\n------------------------"); //creating a break to make the applicaation look more organised.
                    Console.ResetColor();

                    Console.WriteLine("Would you like to: \n1) Enter the Recipe Details \n2) View the Recipe \n3) Scale your Recipe " +
                    "\n4) Reset Scale \n5) Delete Recipe \n6) Exit");
                    menuChoice = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n------------------------");
                    Console.ResetColor();
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid quantity.\n");
                }
            } while (menuChoice == 0);

            
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
            double iQuantity = 0;
            int steps = 0;
            int numIngredients = 0;

            do
            {
                try //using a try-catch statement to ensure that the application does not fail if the user inputs the wrong data.
                {
                    Console.WriteLine("\nPlease enter how many ingridients there are in your recipe:");
                    numIngredients = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < numIngredients; i++) //creating a loop so that the user can enter the same information for each recipe.
                    {

                        int ingredientOrderNum = i + 1;
                        Console.WriteLine("Please enter ingridient number " + ingredientOrderNum + "s name:");
                        string iName = Console.ReadLine();

                        do
                        {
                            try
                            {
                                Console.WriteLine("Please enter the quantity of " + iName + " (i.e 5 for 5 spoons):");
                                iQuantity = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("\nPlease enter a valid quantity.\n");
                            }
                        } while (iQuantity == 0);

                        Console.WriteLine("Please enter the unit of measurement used for " + iName + " (i.e tablespoons):");
                        string iMeasurement = Console.ReadLine();

                        RecipeLists.ingredientList.Add(new Ingredients(iName, iQuantity, iMeasurement)); //adding each piece of information that the user inputs into the list.
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid quantity.\n");
                }
            } while (iQuantity == 0);
            
            do
            {
                try
                {
                    Console.WriteLine("\nHow many steps are there in your recipe?");
                    steps = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < steps; i++) //creating a loop so that the user can enter the same information for each recipe.
                    {
                        int stepNum = i + 1;
                        Console.WriteLine("Please describe step number " + stepNum + ".");
                        string stepDescription = Console.ReadLine();

                        RecipeLists.stepList.Add(new Steps(stepDescription)); //adding each piece of information that the user inputs into the list.
                    }

                    Console.WriteLine("\nRecipe details added!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid quantity\n");
                }
            } while (steps ==0);

            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;  //adding colour to text.
                    Console.WriteLine("\n------------------------");  //creating a break to make the applicaation look more organised.
                    Console.ResetColor();
                    Console.WriteLine("1)Menu \n2)Exit");  //enabling the user to exit the program or go back to the main method so that they can alter their data how they choose.
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("------------------------");
                    Console.ResetColor();

                    EndChoice = Convert.ToInt32(Console.ReadLine());
                    if (EndChoice.Equals(1)) //using an if statement to send the user to whichever choice they make.
                    {
                        Menu();
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid quantity.\n");
                }
            } while (EndChoice == 0);
            

        }


        void ViewRecipe() //creating a ViewRecipe method so that all the data the user inputs can be displayed.
        {
            Console.WriteLine(recipeName);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n------------------------");  //creating a break to make the applicaation look more organised.
            Console.ResetColor();

            Console.WriteLine("Ingredients: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n------------------------");  //creating a break to make the applicaation look more organised.
            Console.ResetColor();
            foreach (var viewIngredient in RecipeLists.ingredientList) //using a foreach loop so that each ingredient in the list can be displayed.   //code attribution: C# Foreach: what it is, How it works, Syntax and Example Code, https://www.simplilearn.com/tutorials/asp-dot-net-tutorial/csharp-foreach#:~:text=The%20foreach%20loop%20in%20C%23%20uses%20the%20%27in%27%20keyword%20to,variable%20changes%20in%20every%20iteration.
            {
                Console.WriteLine("Name: " + viewIngredient.Name + "\nQuantity: " + viewIngredient.Quantity
                    + " " + viewIngredient.unitOfMeasurement + "\n");
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------");
            Console.ResetColor();


            Console.WriteLine("\nSteps: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------");
            Console.ResetColor();
            foreach (var viewStep in RecipeLists.stepList) //using a foreach loop so that each step in the list can be displayed.
            {
                Console.WriteLine("- " + viewStep.Description);
            }
             Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("------------------------");


            do //using a try-catch statement to ensure that the application does not fail if the user inputs the wrong data.
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n------------------------");  //creating a break to make the applicaation look more organised.
                    Console.ResetColor();
                    Console.WriteLine("1)Menu \n2)Exit");  //enabling the user to exit the program or go back to the main method so that they can alter their data how they choose.
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("------------------------");
                    Console.ResetColor();

                    EndChoice = Convert.ToInt32(Console.ReadLine());
                    if (EndChoice.Equals(1)) //using an if statement to send the user to whichever choice they make.
                    {
                        Menu();
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid quantity.\n");
                }
            } while (EndChoice == 0);

        }

        void ScaleRecipe() //creating a ScaleRecipe method so that the quantities of each ingredient can be scaled according to the users input.
        {
            do
            {
                try
                {
                    Console.WriteLine("\nPlease select the number of the scaling choice: \n1) 0.5(half) \n2) 2(double) " +
                "\n3) 3(Triple)");
                    scaleNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid quantity.\n");
                }
            } while (scaleNumber == 0);
            

            switch (scaleNumber) //using a switch statement to correctly scale the quantities based on the users input.
            {
                case 1:
                    foreach (var scaleIngridient in RecipeLists.ingredientList) //using a foreach loop so that each ingredient in the list can be scaled.
                    {
                        scaleIngridient.Quantity = scaleIngridient.Quantity / 2; //scaling the recipe.
                    }
                    Console.WriteLine("\nIngredients scaled!");
                    break;


                case 2:
                    foreach (var scaleIngridient in RecipeLists.ingredientList)
                    {
                        scaleIngridient.Quantity = scaleIngridient.Quantity * 2;
                    }
                    Console.WriteLine("\nIngredients scaled!");
                    break;


                case 3:
                    foreach (var scaleIngridient in RecipeLists.ingredientList)
                    {
                        scaleIngridient.Quantity = scaleIngridient.Quantity * 3;
                    }
                    Console.WriteLine("\nIngredients scaled!");
                    break;
            }

            do //using a try-catch statement to ensure that the application does not fail if the user inputs the wrong data.
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n------------------------");  //creating a break to make the applicaation look more organised.
                    Console.ResetColor();
                    Console.WriteLine("1)Menu \n2)Exit");  //enabling the user to exit the program or go back to the main method so that they can alter their data how they choose.
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("------------------------");
                    Console.ResetColor();

                    EndChoice = Convert.ToInt32(Console.ReadLine());
                    if (EndChoice.Equals(1)) //using an if statement to send the user to whichever choice they make.
                    {
                        Menu();
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid quantity.\n");
                }
            } while (EndChoice == 0);
        }

        void ConvertToOriginalQuantity() //creating a ConvertToOriginalQuantity method so that the quantities of each ingredient can be scaled back to the original input.
        {
            switch (scaleNumber)
            {
                case 1:
                    foreach (var scaleIngredient in RecipeLists.ingredientList) //using a foreach loop so that each ingredient in the list can be de-scaled.
                    {
                        scaleIngredient.Quantity = scaleIngredient.Quantity * 2; //de-scaling the recipe.

                    }
                    Console.WriteLine("\nQuantity reverted.");
                    break;


                case 2:
                    foreach (var scaleIngredient in RecipeLists.ingredientList)
                    {
                        scaleIngredient.Quantity = scaleIngredient.Quantity / 2;
                    }
                    Console.WriteLine("\nQuantity reverted.");
                    break;


                case 3:
                    foreach (var scaleIngredient in RecipeLists.ingredientList)
                    {
                        scaleIngredient.Quantity = scaleIngredient.Quantity / 3;
                    }
                    Console.WriteLine("\nQuantity reverted.");
                    break;
            }

            do //using a try-catch statement to ensure that the application does not fail if the user inputs the wrong data.
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n------------------------");  //creating a break to make the applicaation look more organised.
                    Console.ResetColor();
                    Console.WriteLine("1)Menu \n2)Exit");  //enabling the user to exit the program or go back to the main method so that they can alter their data how they choose.
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("------------------------");
                    Console.ResetColor();

                    EndChoice = Convert.ToInt32(Console.ReadLine());
                    if (EndChoice.Equals(1)) //using an if statement to send the user to whichever choice they make.
                    {
                        Menu();
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid quantity.\n");
                }
            } while (EndChoice == 0);
        }

        void DeleteRecipe() //creating a DeleteRecipe method to clear the data inputed into the lists.
        {
            int deleteChoice = 0;
            do
            {
                try
                {
                    Console.WriteLine("\nPlease confirm you would like to delete your Recipe: \n1) Yes \n2) No"); //prompting the user whether they are sure they would like to delete the recipe.
                    deleteChoice = Convert.ToInt32(Console.ReadLine());

                    if (deleteChoice.Equals(1))
                    {
                        RecipeLists.ingredientList.Clear(); //clearing the lists       //code attribution: C# List.Clear() – Remove All Element from List, https://www.tutorialkart.com/c-sharp-tutorial/c-sharp-list-clear/
                        RecipeLists.stepList.Clear();
                        recipeName = recipeName.Remove(0);
                        Console.WriteLine("\nRecipe Deleted!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid quantity.\n");
                }
            } while (deleteChoice == 0);

            do //using a try-catch statement to ensure that the application does not fail if the user inputs the wrong data.
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n------------------------");  //creating a break to make the applicaation look more organised.
                    Console.ResetColor();
                    Console.WriteLine("1)Menu \n2)Exit");  //enabling the user to exit the program or go back to the main method so that they can alter their data how they choose.
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("------------------------");
                    Console.ResetColor();

                    EndChoice = Convert.ToInt32(Console.ReadLine());
                    if (EndChoice.Equals(1)) //using an if statement to send the user to whichever choice they make.
                    {
                        Menu();
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nPlease enter a valid quantity.\n");
                }
            } while (EndChoice == 0);

        }





















        }
}
