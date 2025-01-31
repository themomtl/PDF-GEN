using PdfGenAPI.Components.Aims;
using PdfGenAPI.Models;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Notes;

public class AimsMemStream : IAimsMemStream
{
    public MemoryStream GetStream(AimsModel data)
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
                    page.Header().AlignCenter().Component(new AimsHeaderComponent(data));
                    page.Content()
                        .AlignCenter()
                        .PaddingTop(10)
                        .Component(new AimsBodyComponent(data));
                });
            })
            .GeneratePdf();

        MemoryStream ms = new MemoryStream(pdf);
        return ms;

        
    }
}

public interface IAimsMemStream
{
    MemoryStream GetStream(AimsModel data);
}
