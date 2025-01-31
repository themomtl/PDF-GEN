using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryPlanComponent(PsychiatryEvalModel data) : IComponent
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
                //table.Cell().Row(++rows).ColumnSpan(12).BorderBottom(1).PaddingLeft(5).PaddingTop(5).Text("Current Assessment/Plan").Bold();

                table
                    .Cell()
                    .Row(++rows)
                    .ColumnSpan(12)
                    .PaddingLeft(5)
                    .PaddingTop(5)
                    .Text(_data.CondOnePlan);
                if (_data.CondTwoPlan != null && _data.CondTwoPlan != "")
                {
                    table
                        .Cell()
                        .Row(++rows)
                        .ColumnSpan(12)
                        .PaddingLeft(5)
                        .PaddingTop(5)
                        .Text(_data.CondTwoPlan);
                }
                if (_data.CondThreePlan != null && _data.CondThreePlan != "")
                {
                    table
                        .Cell()
                        .Row(++rows)
                        .ColumnSpan(12)
                        .PaddingLeft(5)
                        .PaddingTop(5)
                        .Text(_data.CondThreePlan);
                }
                if (_data.CondFourPlan != null && _data.CondFourPlan != "")
                {
                    table
                        .Cell()
                        .Row(++rows)
                        .ColumnSpan(12)
                        .PaddingLeft(5)
                        .PaddingTop(5)
                        .Text(_data.CondFourPlan);
                }
            });
        });
    }
}
