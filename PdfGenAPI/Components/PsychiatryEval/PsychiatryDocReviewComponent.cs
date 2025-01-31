using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryDocReviewComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        uint columns = 12;
        uint rows = 0;
        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (int i = 0; i < columns; i++)
                {
                    column.RelativeColumn();
                }
            });
            table
                .Cell()
                .Row(++rows)
                .Column(1)
                .ColumnSpan(columns)
                .PaddingLeft(5)
                .PaddingTop(5)
                .Text("Documents Reviewed")
                .Bold();
            if (_data.DocReview == "1")
            {
                table
                    .Cell()
                    .Row(++rows)
                    .Column(1)
                    .ColumnSpan(columns)
                    .PaddingLeft(5)
                    .PaddingTop(5)
                    .Text(text =>
                    {
                        text.Span($"{_data.DocRevName} - ").Bold();
                        text.Span($"{_data.DocFindings} ");
                    });
            }
            if (_data.DocReviewDoc == true)
            {
                table
                    .Cell()
                    .Row(++rows)
                    .Column(1)
                    .ColumnSpan(columns)
                    .PaddingLeft(5)
                    .PaddingTop(5)
                    .Text(text =>
                    {
                        text.Span($"{_data.DocRevNameDoc} - ").Bold();
                        text.Span($"{_data.DocRevFingingsDoc} ");
                    });
            }
        });
    }
}
