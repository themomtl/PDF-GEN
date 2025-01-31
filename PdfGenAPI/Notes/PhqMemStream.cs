using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using GenPDF.Components.Eval;
using GenPDF.Components.Phq;
using GenPDF.Components.ProgressNote;
using GenPDF.Models;
using Newtonsoft.Json;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GenPDF.Notes
{
    public class PhqMemStream : IPhqMemStream
    {
        public MemoryStream GetStream(PhqModel data)
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
                        page.Header().AlignCenter().Component(new PhqHeaderComponent(data));

                        page.Content()
                            .AlignCenter()
                            .PaddingTop(10)
                            .Component(new PhqBodyComponent(data));
                    });
                })
                .GeneratePdf();

            MemoryStream ms = new MemoryStream(pdf);
            return ms;
            
        }
    }
}

public interface IPhqMemStream
{
    MemoryStream GetStream(PhqModel data);
}
