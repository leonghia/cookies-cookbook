using CookiesCookbookKrystyna.Recipes;
using CookiesCookbookKrystyna.Recipes.Ingredients;

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{

    public void Exit()
    {
        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(List<Recipe> allRecipes)
    {
        if (allRecipes.Count > 0)
        {
            Console.WriteLine("Existing recipes are:" + Environment.NewLine);

            for (var i = 0; i < allRecipes.Count; i++)
            {
                Console.WriteLine($"******{i + 1}******");
                Console.WriteLine(allRecipes[i]);
                Console.WriteLine();
            }
        }
    }

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookies recipe. Available ingredients are:");

        foreach (var ingredient in IngredientsRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }

    public IEnumerable<Ingredient> ReadingIngredientsFromUser()
    {
        var ingredients = new List<Ingredient>();
        bool shallStop = false;

        while (!shallStop)
        {
            Console.Write("Add an ingredient by its Id, or type anything else to finish: ");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int id))
            {
                var ingredient = IngredientsRegister.GetById(id);
                if (ingredient is not null) ingredients.Add(ingredient);
            }
            else shallStop = true;
        }

        return ingredients;
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}
