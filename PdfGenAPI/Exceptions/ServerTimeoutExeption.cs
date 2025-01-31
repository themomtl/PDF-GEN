using System.Net;

namespace GenPDF.Exceptions
{
    internal class ServerTimeoutExeption : CustomException
    {
        public ServerTimeoutExeption(
            string message,
            HttpStatusCode statusCode = HttpStatusCode.ServiceUnavailable
        )
            : base(message, statusCode) { }
    }
}
