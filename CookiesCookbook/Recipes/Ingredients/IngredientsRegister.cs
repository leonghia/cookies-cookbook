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

    public static Ingredient GetById(int id) => All.FirstOrDefault<Ingredient>(i => i.Id == id, null);
}
