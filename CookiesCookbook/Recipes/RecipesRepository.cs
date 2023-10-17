using CookiesCookbookKrystyna.DataAccess;
using CookiesCookbookKrystyna.Recipes;
using CookiesCookbookKrystyna.Recipes.Ingredients;

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
        List<string> allRecipesAsStrings = _stringsRepository.Read(filePath).ToList<string>();     

        return allRecipesAsStrings
            .Select<string, Recipe>(s => new Recipe(s.Split(SEPARATOR)
                .Select(stringId => IngredientsRegister.GetById(int.Parse(stringId)))));
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {

        var allRecipesAsStrings = allRecipes
            .Select<Recipe, string>(r => string
                .Join(SEPARATOR, r.Ingredients
                    .Select(i => i.Id)))
            .ToList<string>();

        _stringsRepository.Write(filePath, allRecipesAsStrings);
    }
}