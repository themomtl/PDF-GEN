using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryCourseComponent(PsychiatryEvalModel data) : IComponent
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
                    .ColumnSpan(12)
                    .BorderBottom(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(5)
                    .PaddingTop(5)
                    .Text("Current Assessment/Plan")
                    .Bold();

                table
                    .Cell()
                    .Row(++rows)
                    .ColumnSpan(12)
                    .PaddingLeft(5)
                    .PaddingTop(5)
                    .Text(_data.CondOneCourse);
                if (_data.CondTwoCourse != null && _data.CondTwoCourse != "")
                {
                    table
                        .Cell()
                        .Row(++rows)
                        .ColumnSpan(12)
                        .PaddingLeft(5)
                        .PaddingTop(5)
                        .Text(_data.CondTwoCourse);
                }
                if (_data.CondThreeCourse != null && _data.CondThreeCourse != "")
                {
                    table
                        .Cell()
                        .Row(++rows)
                        .ColumnSpan(12)
                        .PaddingLeft(5)
                        .PaddingTop(5)
                        .Text(_data.CondThreeCourse);
                }
                if (_data.CondFourCourse != null && _data.CondFourCourse != "")
                {
                    table
                        .Cell()
                        .Row(++rows)
                        .ColumnSpan(12)
                        .PaddingLeft(5)
                        .PaddingTop(5)
                        .Text(_data.CondFourCourse);
                }
            });
        });
    }
}
