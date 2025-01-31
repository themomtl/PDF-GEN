using GenPDF.Components;
using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.Abs;

public class AbsBodyComponent(EvalProgModel data) : IComponent
{
    private EvalProgModel _data = data;

    public void Compose(IContainer container)
    {
        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (int i = 0; i < 12; i++)
                {
                    column.RelativeColumn();
                }
            });
            table
                .Cell()
                .Row(1)
                .Column(1)
                .ColumnSpan(12)
                .Text(text =>
                {
                    text.Span("Absence Note: \n").Bold();
                    text.Span($"{_data.Notes}");
                });
            table.Cell().Row(2).Column(1).ColumnSpan(12).Component(new SignatureComponent(_data));
        });
    }
}
