using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryEvalLabsReviewedComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        uint rows = 12;
        uint rowCount = 0;
        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (int i = 0; i < rows; i++)
                {
                    column.RelativeColumn();
                }
            });

            //table.Cell().Row(++rowCount).Column(1).ColumnSpan(rows).PaddingLeft(5).Text("Labs Reviewed").Bold();
            if (_data.LabsReviewedOne != null)
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(rows)
                    .PaddingLeft(5)
                    .Text("Labs Reviewed")
                    .Bold();
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(rows)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span($"{_data.LabsReviewedOne} - ").Bold();
                        text.Span($"Ordered by: ").Bold();
                        text.Span($"{_data.LabsOrderedOne ?? _data.Provider} ");
                        text.Span("Results Date: ").Bold();
                        text.Span(
                            $"{Convert.ToDateTime(_data.LabsReviewedOneDate).ToShortDateString()} "
                        );
                    });
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(rows)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span(_data.LabsReviewFindingsOne);
                    });
            }
            if (_data.LabsReviewedTwo != null)
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(rows)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span($"{_data.LabsReviewedTwo} - ").Bold();
                        text.Span($"Ordered by: ").Bold();
                        text.Span($"{_data.LabsOrderedTwo ?? _data.Provider} ");
                        text.Span("Results Date: ").Bold();
                        text.Span(
                            $"{Convert.ToDateTime(_data.LabsReviewedTwoDate).ToShortDateString()} "
                        );
                    });
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(rows)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span(_data.LabsReviewFindingsTwo);
                    });
            }
            if (_data.LabsReviewedThree != null)
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(rows)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span($"{_data.LabsReviewedThree} - ").Bold();
                        text.Span($"Ordered by: ").Bold();
                        text.Span(_data.LabsOrderedThree ?? _data.Provider);
                        text.Span("Results Date:").Bold();
                        text.Span(
                            Convert.ToDateTime(_data.LabsReviewedThreeDate).ToShortDateString()
                        );
                    });
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(rows)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span(_data.LabsReviewFindingsThree);
                    });
            }
            if (_data.LabsReviewedFour != null)
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(rows)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span($"{_data.LabsReviewedFour} - ").Bold();
                        text.Span($"Ordered by: ").Bold();
                        text.Span($"{_data.LabsOrderedFour ?? _data.Provider} ");
                        text.Span("Results Date: ").Bold();
                        text.Span(
                            $"{Convert.ToDateTime(_data.LabsReviewedFourDate).ToShortDateString()} "
                        );
                    });
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(rows)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span(_data.LabsReviewFindingsFour);
                    });
            }
        });
    }
}
