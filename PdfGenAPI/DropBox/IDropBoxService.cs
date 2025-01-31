namespace GenPDF.DropBox;

public interface IDropBoxService
{
    string DownloadImage(string state, string path, int serviceType);
    Task<string> UploadImage(string state, string base64string, string noteType, int serviceType);
}
