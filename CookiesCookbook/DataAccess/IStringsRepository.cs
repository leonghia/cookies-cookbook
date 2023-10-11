namespace CookiesCookbookKrystyna.DataAccess
{
    public interface IStringsRepository
    {
        IEnumerable<string> Read(string filePath);
        void Write(string filePath, List<string> strings);
    }
}