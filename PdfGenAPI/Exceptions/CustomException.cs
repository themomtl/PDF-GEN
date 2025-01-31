using System.Net;

namespace GenPDF.Exceptions
{
    public class CustomException(
        string message,
        HttpStatusCode statusCode = HttpStatusCode.InternalServerError
    ) : Exception(message)
    {
        public HttpStatusCode StatusCode { get; set; } = statusCode;
    }
}
