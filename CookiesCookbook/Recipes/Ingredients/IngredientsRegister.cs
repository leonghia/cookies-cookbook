using CookiesCookbookKrystyna.Recipes.Ingredients;

public static class IngredientsRegister
{
    public static ICollection<Ingredient> All { get; } = new List<Ingredient>
    {
        new WheatFlour(),
        new SpeltFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamon(),
        new CocoaPowder()
    };

    public static Ingredient GetById(int id)
    {
        var results = All.Where<Ingredient>(i => i.Id == id);

        if (results.Count() > 1) throw new InvalidOperationException($"More than one ingredients have ID equal to {id}.");

        return results.First();
    }
}
