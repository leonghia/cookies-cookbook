﻿namespace CookiesCookbookKrystyna.Recipes.Ingredients
{
    public abstract class Ingredient
    {
        public abstract int Id { get; }
        public abstract string Name { get; }
        public virtual string PreparationInstructions { get; } = "Add to other ingredients.";

        public string Describe() => $"{Name}. {PreparationInstructions}";
        public override string ToString() => $"{Id}. {Name}";
    }
}
