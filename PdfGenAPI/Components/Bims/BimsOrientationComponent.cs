using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Bims
{
    public class BimsOrientationComponent(BimsModel data) : IComponent
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

        private readonly BimsModel _data = data;

        public void Compose(IContainer container)
        {
            uint rowCount = 0;
            container.Table(table =>
            {
                table.ColumnsDefinition(column =>
                {
                    for (int i = 0; i < 36; i++)
                    {
                        column.RelativeColumn();
                    }
                });
                //Year
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(36)
                    .PaddingBottom(3)
                    .Text("Temporal Orientation")
                    .Underline();
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(36)
                    .PaddingLeft(10)
                    .Text("Ask resident: Please tell me what year it is right now.")
                    .Italic();
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingLeft(10)
                    .Text("Able to report correct year")
                    .Bold();
                var imageHight = 15;
                switch (_data.QYearNow)
                {
                    case "0. Missed by > 5 years (or no answer)":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Missed by > 5 years (or no answer)");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Missed by 2-5 years");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("2. Missed by 1 year");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("3. Correct");
                        break;
                    case "1. Missed by 2-5 years":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Missed by > 5 years (or no answer)");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Missed by 2-5 years");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("2. Missed by 1 year");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("3. Correct");
                        break;
                    case "2. Missed by 1 year":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Missed by > 5 years (or no answer)");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Missed by 2-5 years");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("2. Missed by 1 year");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("3. Correct");
                        break;
                    case "3. Correct":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Missed by > 5 years (or no answer)");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Missed by 2-5 years");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("2. Missed by 1 year");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("3. Correct");
                        break;
                    default:
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Missed by > 5 years (or no answer)");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Missed by 2-5 years");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("2. Missed by 1 year");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("3. Correct");
                        break;
                }
                //month
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(36)
                    .PaddingLeft(10)
                    .Text("Ask resident: What month are we in right now?")
                    .Italic();
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingLeft(10)
                    .Text("Able to report correct month")
                    .Bold();
                ;
                switch (_data.QMonthNow)
                {
                    case "0. Missed by > 1 month (or no answer)":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Missed by > 1 month");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Missed by 2-5 years");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("2. Accurate within 5 days");

                        break;
                    case "1. Missed by 6 days to 1 month":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Missed by > 1 month");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Missed by 6 days to one month");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("2. Accurate within 5 days");

                        break;
                    case "2. Accurate within 5 days":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Missed by > 1 month");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Missed by 6 days to one month");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("2. Accurate within 5 days");

                        break;
                    default:
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Missed by > 1 month");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Missed by 6 days to one month");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("2. Accurate within 5 days");
                        break;
                }
                //Day
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(36)
                    .PaddingLeft(10)
                    .Text("Ask resident: What day of the week is today?")
                    .Italic();
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingLeft(10)
                    .Text("Able to report correct day of the week")
                    .Bold();
                ;
                switch (_data.QDayNow)
                {
                    case "0. Incorrect (or no answer)":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Incorrect, or no answer");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Correct");

                        break;
                    case "1. Correct":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Incorrect, or no answer");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Correct");

                        break;
                    default:
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(35)
                            .PaddingLeft(20)
                            .Text("0. Incorrect, or no answer");
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(imageHight)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(23)
                            .PaddingLeft(20)
                            .Text("1. Correct");
                        break;
                }
            });
        }
    }
}
