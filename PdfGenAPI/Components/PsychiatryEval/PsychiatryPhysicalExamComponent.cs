using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryPhysicalExamComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

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
                .PaddingTop(5)
                .Text(text =>
                {
                    text.Span("Physical Exam:           ").Bold();
                    text.Span($"{_data.PhysicallExam}");
                });
        });
    }
}
