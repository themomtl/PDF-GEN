using System.Net;
using GenPDF.Exceptions;

namespace PdfGenAPI.Exceptions;

public class NoteNotFoundExeption : CustomException
{
    public NoteNotFoundExeption(string message, HttpStatusCode statusCode = HttpStatusCode.NotFound)
        : base(message, statusCode) { }
}
