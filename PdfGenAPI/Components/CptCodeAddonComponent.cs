using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GenPDF.Components
{
    public class CptCodeAddonComponent : IComponent
    {
        private BaseNoteModel _data;

        public CptCodeAddonComponent(BaseNoteModel data)
        {
            _data = data;
        }

        public void Compose(IContainer container)
        {
            if (_data.CptAddon == "90785")
            {
                container
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .Padding(5)
                    .Text(text =>
                    {
                        text.Span("Required for 90785 complexity code\n")
                            .Bold()
                            .Italic()
                            .FontSize(10);

                        text.Span("Maladaptive Communication:  ");
                        text.Span($"{_data.Maladaptive}\n");

                        text.Span(
                            "Emotional/behavorial conditions \r\ninhibit implementation of treatment:  "
                        );
                        text.Span($"{_data.Emotional}\n");

                        text.Span("Sentinel even requires reporting:  ");
                        text.Span($"{_data.Sentinel}\n");

                        text.Span("Language expression difficulty requires: ");
                        text.Span($"{_data.Language}");
                    });
            }
            else
            {
                container.Text("");
            }
        }
    }
}
