using CookiesCookbookKrystyna.DataAccess;
using CookiesCookbookKrystyna.Recipes;

public class RecipesRepository : IRecipesRepository
{

    private readonly IStringsRepository _stringsRepository;
    private const string SEPARATOR = ",";

    public RecipesRepository(IStringsRepository stringsRepository)
    {
        _stringsRepository = stringsRepository;
    }

    public IEnumerable<Recipe> Read(string filePath)
    {
        var recipes = new List<Recipe>();
        List<string> allRecipesAsStrings = _stringsRepository.Read(filePath).ToList<string>();

        foreach (var s in allRecipesAsStrings)
        {
            var recipeIngredientsStringArr = s.Split(SEPARATOR);
            var ingredients = recipeIngredientsStringArr.Select(stringId => IngredientsRegister.GetById(int.Parse(stringId)));
            var recipe = new Recipe(ingredients);
            recipes.Add(recipe);
        }
        return recipes;
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var allRecipesAsStrings = new List<string>();

        foreach (var r in allRecipes)
        {
            var ingredients = r.Ingredients.Select(i => i.Id);
            allRecipesAsStrings.Add(string.Join(SEPARATOR, ingredients));
        }

        _stringsRepository.Write(filePath, allRecipesAsStrings);
    }
}