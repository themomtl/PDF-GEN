using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Data;

public class PsychiatryCollabComponent(PsychiatryEvalModel data) : IComponent
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

                table
                    .Cell()
                    .Row(++rows)
                    .Column(1)
                    .ColumnSpan(columns)
                    .PaddingLeft(5)
                    .PaddingTop(5)
                    .Text("Collaboration")
                    .Bold();
                if (_data.PhoneReview == "1")
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
                            text.Span($"{_data.PhoneWith} - ").Bold();
                            text.Span($"{_data.PhoneConversation} ");
                        });
                }
                if (_data.PhoneReviewDoc == true)
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
                            text.Span($"{_data.PhoneWithDoc} - ").Bold();
                            text.Span($"{_data.PhoneConvDoc} ");
                        });
                }
            });
        });
    }
}
