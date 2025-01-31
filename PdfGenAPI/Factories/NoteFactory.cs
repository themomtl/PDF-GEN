using GenPDF.Models;
using Microsoft.EntityFrameworkCore;
using PdfGenAPI.Data;
using PdfGenAPI.Views;

namespace PdfGenAPI.Factories;

public class NoteFactory(
    ContextFactory contextFactory,
    IEvalProgData evalProgData,
    IPhqData phqData,
    IBimsData bimsData,
    IAimsData aimsData,
    IPsychiatryEvalData psychiatryEvalData
) : INoteFactory
{
    private readonly ContextFactory _contextFactory = contextFactory;
    private readonly IEvalProgData _evalProgData = evalProgData;
    private readonly IPhqData _phqData = phqData;
    private readonly IBimsData _bimsData = bimsData;
    private readonly IAimsData _aimsData = aimsData;
    private readonly IPsychiatryEvalData _psychiatryEvalData = psychiatryEvalData;

    public async Task<BaseNoteModel?> GetModel(string state, string id, string noteType)
    {
        noteType = noteType.ToUpper();
        DbContext dbContext = _contextFactory.GetContext(state);

        switch (noteType)
        {
            case "EVALUATION":
            case "FOLLOWUP":
            case "ABSENT NOTE":
                var note =
                    await dbContext.Set<EvalTable>().FirstOrDefaultAsync(r => r.UId == id)
                    ?? throw new Exception("Note not found");
                return _evalProgData.Get(note, state);
            case "PHQ9":
                var phqNote =
                    await dbContext.Set<PhqTable>().FirstOrDefaultAsync(r => r.Id == id)
                    ?? throw new Exception("Note not found");
                return _phqData.Get(phqNote, state);
            case "BIMS":
                var bimsNote =
                    await dbContext.Set<BimsTable>().FirstOrDefaultAsync(r => r.Id == id)
                    ?? throw new Exception("Note not found");
                return _bimsData.Get(bimsNote, state);
            case "AIMS":
                var aimsNote =
                    await dbContext.Set<AimsTable>().FirstOrDefaultAsync(r => r.AimsId == id)
                    ?? throw new Exception("Note not found");
                return _aimsData.Get(aimsNote, state);
            case "PSYCHEVAL":
                var psychEval =
                    await dbContext
                        .Set<PsychiatryEvalTable>()
                        .FirstOrDefaultAsync(r => r.NoteId == id)
                    ?? throw new Exception("Note not found");
                return _psychiatryEvalData.Get(psychEval, state);
            default:
                return null;
        }
    }
}
