namespace GenPDF.Exceptions
{
    public class NoSignatureException : CustomException
    {
        public NoSignatureException(string message)
            : base(message, System.Net.HttpStatusCode.BadRequest) { }
    }
}
