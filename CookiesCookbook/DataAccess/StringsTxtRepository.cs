namespace CookiesCookbookKrystyna.DataAccess
{
    public class StringsTxtRepository : StringsRepository
    {
        private static readonly string Separator = Environment.NewLine;

        protected override string StringsToText(List<string> strings) => string.Join(Separator, strings);

        protected override IEnumerable<string> TextToStrings(string filePath) => File.ReadAllText(filePath).Split(Separator);

    }
}