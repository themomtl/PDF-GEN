using GenPDF.Components.Eval;
using GenPDF.Models;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GenPDF.Notes
{
    public class EvalMemStream : IEvalMemStream
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
                        page.Header().AlignCenter().Component(new EvalHeaderComponent(data));

                        page.Content()
                            .AlignCenter()
                            .PaddingTop(10)
                            .Component(new EvalBodyComponent(data));
                    });
                })
                .GeneratePdf();

            MemoryStream ms = new MemoryStream(pdf);
            return ms;
            
        }
    }
}

public interface IEvalMemStream
{
    public MemoryStream GetStream(EvalProgModel data);
}
