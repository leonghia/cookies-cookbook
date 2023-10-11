using System.Text.Json;

namespace CookiesCookbookKrystyna.DataAccess
{
    public class StringsJsonRepository : StringsRepository
    {
        protected override string StringsToText(List<string> strings) => JsonSerializer.Serialize(strings);

        protected override IEnumerable<string> TextToStrings(string filePath) => JsonSerializer.Deserialize<List<string>>(File.ReadAllText(filePath));
    }
}