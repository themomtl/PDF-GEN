using GenPDF.Components.Abs;
using GenPDF.Models;
using PdfGenAPI.Components.Abs;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Notes;

public class AbsMemStream : IAbsMemStream
{
    public MemoryStream GetStream(EvalProgModel data)
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
                    page.Header().AlignCenter().Component(new AbsHeaderComponent(data));
                    page.Content()
                        .AlignCenter()
                        .PaddingTop(10)
                        .Component(new AbsBodyComponent(data));
                });
            })
            .GeneratePdf();

        MemoryStream ms = new MemoryStream(pdf);
        return ms;
        
    }
}

public interface IAbsMemStream
{
    MemoryStream GetStream(EvalProgModel data);
}
