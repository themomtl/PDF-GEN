using GenPDF.Components.Bims;
using GenPDF.Models;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GenPDF.Notes
{
    public class BimsMemStream : IBimsMemStream
    {
        public MemoryStream GetStream(BimsModel data)
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
                        page.Header().AlignCenter().Component(new BimsHeaderComponent(data));

                        page.Content()
                            .AlignCenter()
                            .PaddingTop(0)
                            .Component(new BimsBodyComponent(data));
                    });
                })
                .GeneratePdf();

            MemoryStream ms = new MemoryStream(pdf);
            return ms;
            
        }
    }
}

public interface IBimsMemStream
{
    MemoryStream GetStream(BimsModel data);
}
