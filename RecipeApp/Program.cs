using RecipeApp;

//created an object in order to call the Menu and RecipeName method from my methods class.
RecipeOptions recipe = new RecipeOptions();

//Opening message to the user, creates a welcoming environment so they are encouraged to use the app.
Console.WriteLine("Welcoming to Recipes Galore! An app where you can store all the details of your favourite recipe. \nLet us begin. ");

//calling the RecipeName method so that the user can input the name of the recipe and start the program
recipe.RecipeName();

