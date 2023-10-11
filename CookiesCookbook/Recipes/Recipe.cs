using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookiesCookbookKrystyna.Recipes.Ingredients;

namespace CookiesCookbookKrystyna.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredient> Ingredients { get; }
        public Recipe(IEnumerable<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        }

        public override string ToString()
        {
            var output = new List<string>();
            foreach (var i in Ingredients)
            {
                output.Add(i.Describe());
            }
            return string.Join(Environment.NewLine, output);
        }
    }
}
