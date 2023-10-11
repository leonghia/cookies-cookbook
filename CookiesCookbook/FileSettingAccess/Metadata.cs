using CookiesCookbookKrystyna.DataAccess;

public class Metadata
{
    public IStringsRepository StringsRepository { get; }
    public string FilePath { get; }

    public Metadata(IStringsRepository stringsRepository, string filePath)
    {
        StringsRepository = stringsRepository;
        FilePath = filePath;
    }
}
