using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryEvalHistoryComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        uint rowCount = 0;
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
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingTop(2)
                .PaddingLeft(2)
                .Text(text =>
                {
                    text.Span("History of Present Illness").Bold();
                });
            foreach (var item in _data.HistoryList)
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(2)
                    .PaddingTop(2)
                    .BorderBottom(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(2)
                    .Text(text =>
                    {
                        text.Span($"{item.Date}");
                    });
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(3)
                    .ColumnSpan(10)
                    .PaddingTop(2)
                    .BorderBottom(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(2)
                    .Text(text =>
                    {
                        text.Span($"{item.Illness}");
                    });
            }
        });
    }
}
