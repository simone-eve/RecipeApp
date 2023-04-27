using RecipeApp;

//created an object in order to call the menu from my methods class.
RecipeOptions recipe = new RecipeOptions();

//Opening message to the user, creates a welcoming environment so they are encouraged to use the app.
Console.WriteLine("Welcoming to Recipes Galore! An app where you can store all your favourite recipes. \nLet us begin. ");

recipe.RecipeName();

//calling the menu to start the program.
recipe.Menu();