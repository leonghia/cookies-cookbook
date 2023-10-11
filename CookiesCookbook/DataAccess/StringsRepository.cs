namespace CookiesCookbookKrystyna.DataAccess
{
    public abstract class StringsRepository : IStringsRepository
    {
        public IEnumerable<string> Read(string filePath) => File.Exists(filePath) ? TextToStrings(filePath) : new List<string>();
        protected abstract IEnumerable<string> TextToStrings(string filePath);
        public void Write(string filePath, List<string> strings) => File.WriteAllText(filePath, StringsToText(strings));
        protected abstract string StringsToText(List<string> strings);
    }
}