using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Phq
{
    internal class PhqPartOneComponent : IComponent
    {
        private readonly PhqModel _data;
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

        private List<string> _questions = new List<string>()
        {
            "a. Little interest or pleasure in doing things",
            "b. Feeling down, depressed, or hopeless",
            "c. Trouble falling/staying asleep, sleeping too much",
            "d. Feeling tired or having little energy",
            "e. Poor appetite or overeating",
            "f. Feeling bad about yourself or that you are a failure or have let yourself or your family down",
            "g. Trouble concentrating on things, such as reading the newspaper or watching television.",
            "h. Moving or speaking so slowly that other people could have noticed. Or the opposite; being so fidgety or restless that you have been moving around a lot more than usual.",
            "i. Thoughts that you would be better off dead or of hurting yourself in some way.",
        };
        private readonly List<string> _answers;

        public PhqPartOneComponent(PhqModel data)
        {
            _data = data;
            _answers = new List<string>()
            {
                _data.Interest ?? "",
                _data.Down ?? "",
                _data.Sleep ?? "",
                _data.Energy ?? "",
                _data.Apettite ?? "",
                _data.Feel_bad ?? "",
                _data.Concentrate ?? "",
                _data.Slow_move ?? "",
                _data.Thoughts ?? "",
            };
        }

        public void Compose(IContainer container)
        {
            // set row dynamicly
            uint rowCount = 0;
            container.Table(table =>
            {
                table.ColumnsDefinition(column =>
                {
                    for (var i = 0; i < 8; i++)
                    {
                        column.RelativeColumn();
                    }
                });

                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(4)
                    .Text(
                        "1. Over the last 2 weeks, how often have you been bothered by any of the following problems?"
                    )
                    .FontSize(11)
                    .ExtraBold();
                table.Cell().Row(rowCount).Column(5).ColumnSpan(1).Text("Not at all").AlignCenter();
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(6)
                    .ColumnSpan(1)
                    .Text("Sevral days")
                    .AlignCenter();
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(7)
                    .ColumnSpan(1)
                    .Text("More than half the days")
                    .AlignCenter();
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(8)
                    .ColumnSpan(1)
                    .Text("Nearly every day")
                    .AlignCenter();
                for (var i = 0; i < _questions.Count; i++)
                {
                    table
                        .Cell()
                        .Row(++rowCount)
                        .Column(1)
                        .ColumnSpan(4)
                        .PaddingLeft(5)
                        .PaddingTop(5)
                        .Text(_questions[i]);
                    switch (_answers[i])
                    {
                        case "0. Not at all":
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(5)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(yesCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(6)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(7)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(8)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            break;
                        case "1. Several days":
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(5)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(6)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(yesCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(7)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(8)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            break;
                        case "2. More than half the days":
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(5)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(6)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(7)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(yesCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(8)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            break;
                        case "3. Nearly every day":
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(5)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(6)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(7)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(8)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(yesCheck);
                            break;
                        default:
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(5)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(6)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(7)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            table
                                .Cell()
                                .Row(rowCount)
                                .Column(8)
                                .ColumnSpan(1)
                                .PaddingTop(5)
                                .AlignCenter()
                                .Height(15)
                                .Image(noCheck);
                            break;
                    }
                }

                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(4)
                    .PaddingTop(5)
                    .Text(
                        "2. If you checked off any problem on this questionnaire so far, how difficult have these problems made it for you to do your work, take care of things at home, or get along with other people?"
                    )
                    .FontSize(11)
                    .ExtraBold();
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(5)
                    .ColumnSpan(1)
                    .PaddingTop(5)
                    .Text("Not difficult\n at all")
                    .AlignCenter();
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(6)
                    .ColumnSpan(1)
                    .PaddingTop(5)
                    .Text("Somewhat difficult")
                    .AlignCenter();
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(7)
                    .ColumnSpan(1)
                    .PaddingTop(5)
                    .Text("Very \ndifficult")
                    .AlignCenter();
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(8)
                    .ColumnSpan(1)
                    .PaddingTop(5)
                    .Text("Extremely difficult")
                    .AlignCenter();
                switch (_data.Difficult)
                {
                    case "0. Not difficult at all":
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(5)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(7)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        break;
                    case "1. Somewhat difficult":
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(5)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(7)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        break;
                    case "2. Very difficult":
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(5)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(7)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        break;
                    case "3. Extremely difficult":
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(5)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(7)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(yesCheck);
                        break;
                    default:
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(5)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(7)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .PaddingTop(35)
                            .AlignCenter()
                            .Height(15)
                            .Image(noCheck);
                        break;
                }

                //Often
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(5)
                    .PaddingTop(10)
                    .Text("How often do you feel lonely or isolated from those around you?")
                    .FontSize(11)
                    .Bold();
                table
                    .Cell()
                    .Row(rowCount)
                    .Column(6)
                    .ColumnSpan(2)
                    .PaddingTop(10)
                    .Text(_data.OftenLonely)
                    .FontSize(11)
                    .Bold();
            });
        }
    }
}
