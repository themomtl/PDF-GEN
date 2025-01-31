using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Eval
{
    internal class EvalSubAbuseComponent : IComponent
    {
        private EvalProgModel _data;

        private float boxHeight = 75;

        public EvalSubAbuseComponent(BaseNoteModel data)
        {
            _data = (EvalProgModel)data;
        }

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
                    .PaddingBottom(25)
                    .Text("Substance Abuse Screening and Counseling")
                    .AlignCenter()
                    .Bold()
                    .FontSize(15)
                    .Underline();

                //Alcohol
                table
                    .Cell()
                    .Row(2)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text("Alcohol Abuse")
                    .Bold()
                    .FontSize(10)
                    .Underline();
                table
                    .Cell()
                    .Row(3)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text(text =>
                    {
                        text.Span("Do you have a history of alcohol abuse? ");
                        if (_data.Alcohol == null)
                        {
                            text.Span("No").Bold();
                        }
                        text.Span(_data.Alcohol).Bold();
                    });
                table
                    .Cell()
                    .Row(4)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text(text =>
                    {
                        text.Span(
                            "How many times in the past year have you had 5 (for men) 4 (for women and all adults age 65 and older) or more drinks in a day? "
                        );
                        if (_data.AlcoholQ == null)
                        {
                            text.Span("N/A").Bold();
                        }
                        text.Span(_data.AlcoholQ).Bold();
                    });
                table
                    .Cell()
                    .Row(5)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text(text =>
                    {
                        text.Span("Time spent counseling patient (minutes) ");
                        if (_data.AlcoholTime == null)
                        {
                            text.Span("N/A").Bold();
                        }
                        text.Span(_data.AlcoholTime).Bold();
                    });
                table
                    .Cell()
                    .Row(6)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(10)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(2)
                    .Text(text =>
                    {
                        text.Span("Counseling session summary").Bold();
                    });

                table
                    .Cell()
                    .Row(7)
                    .Column(1)
                    .ColumnSpan(12)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(2)
                    .Height(boxHeight)
                    .Text(text =>
                    {
                        if (_data.AlcoholConv == null)
                        {
                            text.Span("N/A").Bold();
                        }
                        text.Span(_data.AlcoholConv).Bold();
                    });
                //Tabbaco
                table
                    .Cell()
                    .Row(8)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text("Tobbaco abuse")
                    .Bold()
                    .FontSize(10)
                    .Underline();
                table
                    .Cell()
                    .Row(9)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text(text =>
                    {
                        text.Span("Are you a tobbaco User? ");
                        if (_data.Tobbaco == null)
                        {
                            text.Span("No").Bold();
                        }
                        text.Span(_data.Tobbaco).Bold();
                    });
                table
                    .Cell()
                    .Row(10)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text(text =>
                    {
                        text.Span("Time spent counseling patient (minutes) ");
                        if (_data.TobbacoTime == null)
                        {
                            text.Span("N/A").Bold();
                        }
                        text.Span(_data.TobbacoTime).Bold();
                    });
                table
                    .Cell()
                    .Row(11)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(10)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(2)
                    .Text(text =>
                    {
                        text.Span("Counseling session summary").Bold();
                    });
                table
                    .Cell()
                    .Row(12)
                    .Column(1)
                    .ColumnSpan(12)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(2)
                    .Height(boxHeight)
                    .Text(text =>
                    {
                        if (_data.TobbacoConv == null)
                        {
                            text.Span("N/A").Bold();
                        }
                        text.Span(_data.TobbacoConv).Bold();
                    });
                //Drugs
                table
                    .Cell()
                    .Row(13)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text("Drug abuse")
                    .Bold()
                    .FontSize(10)
                    .Underline();
                table
                    .Cell()
                    .Row(14)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text(text =>
                    {
                        text.Span("Do you have a history of substance abuse? ");
                        if (_data.Substance == null)
                        {
                            text.Span("No").Bold();
                        }
                        text.Span(_data.Substance).Bold();
                    });
                table
                    .Cell()
                    .Row(15)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text(text =>
                    {
                        text.Span("How often have you used drugs or over the counter meds? ");
                        if (_data.SubstanceOften == null)
                        {
                            text.Span("N/A").Bold();
                        }
                        text.Span(_data.SubstanceOften).Bold();
                    });
                table
                    .Cell()
                    .Row(16)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text(text =>
                    {
                        text.Span("Time spent counseling patient(minutes) ");
                        if (_data.SubstanceCounseling == null)
                        {
                            text.Span("N/A").Bold();
                        }
                        text.Span(_data.SubstanceCounseling).Bold();
                    });
                table
                    .Cell()
                    .Row(17)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(10)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(2)
                    .Text(text =>
                    {
                        text.Span("Counseling session summary").Bold();
                    });
                table
                    .Cell()
                    .Row(18)
                    .Column(1)
                    .ColumnSpan(12)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(2)
                    .Height(boxHeight)
                    .Text(text =>
                    {
                        if (_data.SubstanceConv == null)
                        {
                            text.Span("N/A").Bold();
                        }
                        text.Span(_data.SubstanceConv).Bold();
                    });
                table.Cell().PageBreak();
            });
        }
    }
}
