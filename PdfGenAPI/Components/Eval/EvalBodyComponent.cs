using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Eval
{
    public class EvalBodyComponent(EvalProgModel data) : IComponent
    {
        private EvalProgModel _data = data;
        private uint _rowCount = 0;

        public void Compose(IContainer container)
        {
            int wordCount = 300; /*GetCharCount(_data);*/
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
                    .Row(++_rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .Component(new DxComponent(_data.DxCodes));
                table
                    .Cell()
                    .Row(++_rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("Service:").Bold();
                        text.Span($"{_data.Service}");
                    });
                table
                    .Cell()
                    .Row(++_rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("REASON FOR REFERRAL:").Bold();
                        text.Span($"{_data.Reason}");
                    });
                if (wordCount > 300)
                {
                    table
                        .Cell()
                        .Row(++_rowCount)
                        .ColumnSpan(12)
                        .Component(new EvalMentalStatusComponent(_data, 5));
                    table.Cell().Row(++_rowCount).PageBreak();
                    table
                        .Cell()
                        .Row(++_rowCount)
                        .ColumnSpan(12)
                        .Component(new EvalOverallRatingComponent(_data, 5));
                }
                else
                {
                    table
                        .Cell()
                        .Row(++_rowCount)
                        .ColumnSpan(12)
                        .Component(new EvalMentalStatusComponent(_data));
                    table
                        .Cell()
                        .Row(++_rowCount)
                        .ColumnSpan(12)
                        .Component(new EvalOverallRatingComponent(_data));
                }
                table
                    .Cell()
                    .Row(++_rowCount)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Component(new CptCodeAddonComponent(_data));
                table.Cell().Row(++_rowCount).PageBreak();
                table
                    .Cell()
                    .Row(++_rowCount)
                    .ColumnSpan(12)
                    .Component(new EvalSubAbuseComponent(_data));
                table
                    .Cell()
                    .Row(++_rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .AlignCenter()
                    .Element(container =>
                    {
                        container.Column(column =>
                        {
                            column.Item().Component(new EvalTreatmentPlanComponent(_data));
                            column.Item().Component(new SignatureWithTextComponent(_data));
                        });
                    });
                table.Cell().Row(++_rowCount).PageBreak();
                table
                    .Cell()
                    .Row(++_rowCount)
                    .ColumnSpan(12)
                    .Component(new EvalCompTraumaComponent(_data));
            });
        }
        // private static int GetCharCount(EvalProgModel _data)
        // {
        //     int count = 0;
        //     count += _data.ThoughtProcess.Length;
        //     count += _data.ThoughtContent.Length;
        //     count += _data.Hallucination.Length;
        //     count += _data.Delusion.Length;
        //     count += _data.SelfPerception.Length;
        //     count += _data.Orientation.Length;
        //     count += _data.Memory.Length;
        //     count += _data.Cognitive.Length;
        //     count += _data.Appearance.Length;
        //     count += _data.Behavior.Length;
        //     count += _data.Affect.Length;
        //     count += _data.Speech.Length;
        //     count += _data.Judgment.Length;
        //     count += _data.RiskFactor.Length;
        //     return count;
        // }
    }
}
