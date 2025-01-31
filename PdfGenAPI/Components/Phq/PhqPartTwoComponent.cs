using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Phq
{
    public class PhqPartTwoComponent : IComponent
    {
        private PhqModel _data;

        public PhqPartTwoComponent(PhqModel data)
        {
            _data = data;
        }

        public void Compose(IContainer container)
        {
            uint rowCount = 0;
            container.Table(table =>
            {
                table.ColumnsDefinition(column =>
                {
                    for (var i = 0; i < 24; i++)
                    {
                        column.RelativeColumn();
                    }
                });
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(24)
                    .PaddingTop(15)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .Padding(2)
                    .Text(
                        "PHQ-9* Questionnaire for Depression Scoring and Interpretation Guide For physician use only"
                    )
                    .AlignCenter()
                    .Bold()
                    .FontSize(12);

                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(4)
                    .PaddingTop(10)
                    .AlignCenter()
                    .Text(text =>
                    {
                        text.Span("Not at all (x0)").FontSize(12);
                        text.Span($"  {_data.Sc_1}").ExtraBold().FontSize(12);
                    });
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(5)
                    .ColumnSpan(5)
                    .PaddingTop(10)
                    .AlignCenter()
                    .Text(text =>
                    {
                        text.Span("Sevral days(x1)").FontSize(12);
                        text.Span($"  {_data.Sc_2}").ExtraBold().FontSize(12);
                    });
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(10)
                    .ColumnSpan(8)
                    .PaddingTop(10)
                    .AlignCenter()
                    .Text(text =>
                    {
                        text.Span("More than half the days(x2)").FontSize(12);
                        text.Span($"  {_data.Sc_3}").ExtraBold().FontSize(12);
                    });
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(18)
                    .ColumnSpan(6)
                    .PaddingTop(10)
                    .AlignCenter()
                    .Text(text =>
                    {
                        text.Span("Nearly every day(x3)").FontSize(12);
                        text.Span($"  {_data.Sc_4}").ExtraBold().FontSize(12);
                    });
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(24)
                    .PaddingTop(10)
                    .Text(text =>
                    {
                        text.Span("Total Score  ").FontSize(12).Bold();
                        text.Span($"{_data.Sc_total}").ExtraBold().FontSize(12).Underline();
                    });
                // Interprate
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(24)
                    .PaddingTop(10)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .Padding(2)
                    .Text("Interpreting PHQ-9 Scores Actions Based on PH9 Score")
                    .AlignCenter()
                    .Bold()
                    .FontSize(12);
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(24)
                    .PaddingTop(5)
                    .Text(
                        "Minimal depression - (0-4) Mild depression - (5-9) Moderate depression - (10-14) "
                    );
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(24)
                    .PaddingTop(5)
                    .Text("Moderately severe depression - (15-19) Severe depression - (20-27)");

                //Score action
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(24)
                    .PaddingTop(5)
                    .Text("Score - Action")
                    .Bold();
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(24)
                    .Text("< 4 The score suggests the patient may not need depression treatment.");
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(24)
                    .Text(
                        "> 5-14 Physician uses clinical judgment about treatment, based on patient's duration of symptoms and functional impairement"
                    );
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(24)
                    .Text(
                        ">15 Warrants treatment for depression, using antidepressant, psychotherapy and/or a combination of treatment."
                    );
            });
        }
    }
}
