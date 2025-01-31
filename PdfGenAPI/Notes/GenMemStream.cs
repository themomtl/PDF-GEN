using GenPDF.Exceptions;
using GenPDF.Models;
//using Microsoft.Azure.Functions.Worker;
using PdfGenAPI.Exceptions;
using PdfGenAPI.Factories;
using PdfGenAPI.Models;
using PdfGenAPI.Notes;
using PdfGenAPI.Views;

namespace GenPDF.Notes
{
    public class GenMemStream(
        ContextFactory contextFactory,
        INoteFactory noteFactory,
        IAimsMemStream aimsMemStream,
        IEvalMemStream evalMemStream,
        IProgressNoteMemStream progressNoteMemStream,
        IPhqMemStream phqMemStream,
        IBimsMemStream bimsMemStream,
        IAbsMemStream absMemStream,
        IPsychiatryEvalMemStream psychiatryEvalMemStream
    )
    {
        private readonly ContextFactory _contextFactory = contextFactory;
        private readonly INoteFactory _noteFactory = noteFactory;

        
        private IEvalMemStream _evalMemStream = evalMemStream;
        private IProgressNoteMemStream _progressNoteMemStream = progressNoteMemStream;
        private IPhqMemStream _phqMemStream = phqMemStream;
        private IBimsMemStream _bimsMemStream = bimsMemStream;
        private IAbsMemStream _absMemStream = absMemStream;
        private IAimsMemStream _aimsMemStream = aimsMemStream;
        private IPsychiatryEvalMemStream _psychiatryEvalMemStream = psychiatryEvalMemStream;

        public async Task<MemoryStream?> Get(string state, string id, string type)
        {
            type = type.ToUpper();
            try
            {
                var model =
                    await _noteFactory.GetModel(state, id, type)
                    ?? throw new NoteNotFoundExeption("Note not found");

                return type switch
                {
                    "EVALUATION" => _evalMemStream.GetStream((EvalProgModel)model),
                    "FOLLOWUP" => _progressNoteMemStream.GetStream((EvalProgModel)model),
                    "PHQ9" => _phqMemStream.GetStream((PhqModel)model),
                    "BIMS" => _bimsMemStream.GetStream((BimsModel)model),
                    "ABSENT NOTE" => _absMemStream.GetStream((EvalProgModel)model),
                    "AIMS" => _aimsMemStream.GetStream((AimsModel)model),
                    "PSYCHEVAL" => _psychiatryEvalMemStream.GetStream((PsychiatryEvalModel)model),
                    _ => null,
                };
            }
            catch (NoSignatureException)
            {
                throw;
            }
            catch (NoteNotFoundExeption)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ServerTimeoutExeption(ex.Message);
            }
        }
        

     
    }
}
