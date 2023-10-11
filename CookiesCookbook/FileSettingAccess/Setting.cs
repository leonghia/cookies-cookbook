public class Setting
{
    public FileFormat FileFormat { get; }
    public string FileName { get; }

    public Setting(FileFormat fileFormat, string fileName)
    {
        FileFormat = fileFormat;
        FileName = fileName;
    }   
}
