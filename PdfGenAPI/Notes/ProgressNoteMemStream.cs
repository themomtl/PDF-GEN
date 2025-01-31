using GenPDF.Components.ProgressNote;
using GenPDF.Models;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GenPDF.Notes
{
    internal class ProgressNoteMemStream : IProgressNoteMemStream
    {
        public MemoryStream GetStream(EvalProgModel data)
        {
            
            var pdf = QuestPDF
                .Fluent.Document.Create(container =>
                {
                    container.Page(page =>
                    {
                        page.Size(PageSizes.Letter);
                        page.PageColor(Colors.White);
                        page.DefaultTextStyle(x => x.FontSize(10));
                        page.Margin(1, Unit.Centimetre);
                        //Header
                        page.Header()
                            .AlignCenter()
                            .Component(new ProgressNoteHeaderComponent(data));

                        page.Content()
                            .AlignCenter()
                            .PaddingTop(10)
                            .Component(new ProgressNoteBodyComponent(data));
                    });
                })
                .GeneratePdf();

            MemoryStream ms = new MemoryStream(pdf);
            return ms;
            
        }
    }
}

public interface IProgressNoteMemStream
{
    MemoryStream GetStream(EvalProgModel data);
}
