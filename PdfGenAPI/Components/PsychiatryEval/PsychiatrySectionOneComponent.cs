using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatrySectionOneComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        uint rowCount = 0;
        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (var i = 0; i < 12; i++)
                {
                    column.RelativeColumn();
                }
            });

            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .Text(text =>
                {
                    text.Span($"Chief Complaint: ").Bold();
                    text.Span(_data.Complaints);
                });
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .Text(text =>
                {
                    text.Span($"Information Source: ").Bold();
                    text.Span(_data.Source);
                });
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .Text(text =>
                {
                    text.Span($"Allergies: ").Bold();
                    text.Span(_data.Allergies);
                });
        });
    }
}
