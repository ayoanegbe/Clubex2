namespace Clubex2.Interfaces
{
    public interface IFileService
    {
        bool SaveFile(List<IFormFile> files, string subDirectory);
        (string fileType, byte[] archiveData, string archiveName) FetechFiles(string subDirectory);
        string SizeConverter(long bytes);
    }
}
