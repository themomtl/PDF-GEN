using PdfGenAPI.Components.PsychiatryEval;
using PdfGenAPI.Models;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Notes;

public class PsychiatryEvalMemStream : IPsychiatryEvalMemStream
{
    public MemoryStream GetStream(PsychiatryEvalModel data)
    {
        var pdf = Document
            .Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.Letter);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10));
                    page.Margin(1, Unit.Centimetre);
                    //Header
                    page.Header().AlignCenter().Component(new PsychiatryEvalHeaderComponent(data));

                    page.Content()
                        .AlignCenter()
                        .PaddingTop(10)
                        .Component(new PsychiatryEvalBodyComponent(data));
                });
            })
            .GeneratePdf();

       

        MemoryStream ms = new MemoryStream(pdf);
        return ms;
    }
}

public interface IPsychiatryEvalMemStream
{
    public MemoryStream GetStream(PsychiatryEvalModel data);
}
