using CookiesCookbookKrystyna.Recipes;
using CookiesCookbookKrystyna.Recipes.Ingredients;

public interface IRecipesUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PrintExistingRecipes(List<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadingIngredientsFromUser();
}
