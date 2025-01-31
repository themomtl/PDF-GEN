using GenPDF.Components;
using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval.SubComponents;

public class LastSubComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        uint rowCount = 0;
        uint colCount = 12;
        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (int i = 0; i < colCount; i++)
                {
                    column.RelativeColumn();
                }
            });
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(6)
                .PaddingTop(5)
                .PaddingRight(5)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .Component(new PsychiatryGdrComponent(_data));
            table
                .Cell()
                .Row(rowCount)
                .Column(7)
                .ColumnSpan(6)
                .PaddingTop(5)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .Component(new PsychiatryDangerComponent(_data));
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(6)
                .PaddingTop(5)
                .ShowEntire()
                .Component(new PsychiatryTelehealthComponent(_data));

            table
                .Cell()
                .Row(rowCount)
                .Column(7)
                .ColumnSpan(6)
                .ShowEntire()
                .Component(new SignatureWithTextComponent(_data));
        });
    }
}
