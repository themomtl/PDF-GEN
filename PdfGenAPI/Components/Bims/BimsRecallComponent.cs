using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Bims
{
    public class BimsRecallComponent : IComponent
    {
        private readonly byte[] noCheck = File.ReadAllBytes(
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "img/checkbox-unchecked-svgrepo-com.png"
            )
        );

        private readonly byte[] yesCheck = File.ReadAllBytes(
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "img/checkbox-check-svgrepo-com.png"
            )
        );

        private readonly BimsModel _data;

        public BimsRecallComponent(BimsModel data)
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
                    for (int i = 0; i < 4; i++)
                    {
                        column.RelativeColumn();
                    }
                });
                var imageHeight = 15;
                table.Cell().Row(++rowCount).Column(1).ColumnSpan(4).Text("Recall").Underline();
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(4)
                    .PaddingTop(5)
                    .PaddingBottom(5)
                    .Text(
                        "Ask resident: Let’s go back to the earlier question. What were the three words that i asked you to repeat? If unable to remember a word, give cue (something to wear; a color; a piece of furniture)"
                    )
                    .Italic();

                switch (_data.QRecallFirst)
                {
                    case "0. No- could not recall":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall first word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;

                    case "1. Yes, after cueing":

                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall first word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;
                    case "2. Yes, no cue":
                    case "2. Yes, no cue required":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall first word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;
                    default:
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall first word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;
                }
                switch (_data.QRecallSecond)
                {
                    case "0. No - Could not recall":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall second word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;

                    case "1. Yes, after cueing":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall second word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;
                    case "2. Yes, no cue":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall second word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;
                    default:
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall second word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;
                }
                switch (_data.QRecallThird)
                {
                    case "0. No - could not recall":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall third word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;

                    case "1. Yes, after cueing":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall third word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;
                    case "2. Yes, no cue":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall third word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;
                    default:
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(1)
                            .ColumnSpan(1)
                            .Text("Able to recall third word")
                            .Bold();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("0. No - Could not recall");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(3)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("1. Yes, after cueing");
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(imageHeight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(15)
                            .Text("2. Yes, no cue");
                        break;
                }

                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(4)
                    .PaddingTop(10)
                    .Element(container =>
                    {
                        container
                            .ShowEntire()
                            .Column(column =>
                            {
                                column.Item().Text(text => text.Span("Summary Score:").Underline());
                                column
                                    .Item()
                                    .Text(text =>
                                    {
                                        text.Span(
                                                "Add scores for each question and fill in total score (00-15)    "
                                            )
                                            .Bold();
                                        text.Span(_data.SummaryScore)
                                            .Underline()
                                            .Bold()
                                            .FontSize(13);
                                    });
                                column.Item().Component(new SignatureComponent(_data));
                            });
                    });
            });
        }
    }
}
