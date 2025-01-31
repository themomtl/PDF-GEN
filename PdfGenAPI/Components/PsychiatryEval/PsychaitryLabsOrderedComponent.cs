using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychaitryLabsOrderedComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        uint rowCount = 0;
        uint rows = 12;
        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (int i = 0; i < rows; i++)
                {
                    column.RelativeColumn();
                }
            });
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(rows)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .Padding(5)
                .Text("Labs Ordered")
                .Bold();

            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(3)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .Padding(5)
                .Text(_data.LabsOrderedOne);
            table
                .Cell()
                .Row(rowCount)
                .Column(4)
                .ColumnSpan(3)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .Padding(5)
                .Text(_data.LabsOrderedTwo);
            table
                .Cell()
                .Row(rowCount)
                .Column(7)
                .ColumnSpan(3)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .Padding(5)
                .Text(_data.LabsOrderedThree);
            table
                .Cell()
                .Row(rowCount)
                .Column(10)
                .ColumnSpan(3)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .Padding(5)
                .Text(_data.LabsOrderedFour);
        });
    }
}
