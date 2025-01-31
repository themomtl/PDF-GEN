namespace GenPDF.Utils
{
    public class ConvertBase
    {
        public Byte[] Start(string base64)
        {
            byte[] imageBytes = Convert.FromBase64String(base64);

            return imageBytes;
        }
    }
}
