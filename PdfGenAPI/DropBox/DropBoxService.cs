using Dropbox.Api;

namespace GenPDF.DropBox;

public class DropBoxService : IDropBoxService
{
    private readonly string app_key;
    private readonly string app_secret;
    private readonly string refresh_token;

    /

    private readonly DropboxClient dbx;

    
    public DropBoxService( 
    )
    {
        


        app_key = "...";
        app_secret = "...";
        refresh_token = "...";
        dbx = new(refresh_token, app_key, app_secret);
    }

    public string DownloadImage(string state, string path, int serviceType)
    {
        try
        {
            string filePath = string.Empty;
            if (serviceType == 1)
            {
                filePath = $"/{state.ToUpper()}/{path}";
            }
            else if (serviceType == 2)
            {
                filePath = $"/Psych_{state.ToUpper()}/{path}";
            }

            var response = dbx.Files.DownloadAsync(filePath).Result;

            if (response.Response.IsFile)
            {
                var fileContent = response.GetContentAsByteArrayAsync().Result;
                var fileName = Path.GetFileName(filePath);

                string base64String = Convert.ToBase64String(fileContent);
                return base64String;
            }
            else
            {
                throw new Exception("Requested item is not a file.");
            }
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
    }

    public Task<string> UploadImage(
        string state,
        string base64string,
        string noteType,
        int serviceType
    )
    {
        throw new NotImplementedException();
    }

    private string GenerateFilePath(int serviceType, string noteType, string state)
    {
        state = state.ToUpper();
        string filePath;
        if (serviceType == 2 && noteType == "aims")
        {
            filePath = $"...";
        }
        else if (serviceType == 2 && noteType != "aims")
        {
            filePath = $"...";
        }
        else if (serviceType == 1 && noteType == "phq9")
        {
            filePath = $"...";
        }
        else if (serviceType == 1 && noteType != "phq9")
        {
            filePath = $"...";
        }
        else
        {
            throw new Exception("service type or note type is invalid");
        }
        return $"/{filePath}/{Guid.NewGuid()}.png";
    }
}
