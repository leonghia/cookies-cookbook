using CookiesCookbookKrystyna.Recipes;

public interface IRecipesRepository
{
    IEnumerable<Recipe> Read(string filePath);
    void Write(string filePath, List<Recipe> allRecipes);
}
