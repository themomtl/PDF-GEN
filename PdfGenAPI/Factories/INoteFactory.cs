using GenPDF.Models;

namespace PdfGenAPI.Factories;

public interface INoteFactory
{
    Task<BaseNoteModel?> GetModel(string state, string id, string type);
}
