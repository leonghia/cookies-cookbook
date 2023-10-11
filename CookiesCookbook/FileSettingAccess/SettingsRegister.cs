using CookiesCookbookKrystyna.DataAccess;

public static class SettingsRegister
{
    public static IDictionary<FileFormat, Metadata> All { get; } = new Dictionary<FileFormat, Metadata>
    {
        { FileFormat.Json, new Metadata(new StringsJsonRepository(), ".json") },
        { FileFormat.Txt, new Metadata(new StringsTxtRepository(), ".txt") }
    };
}
