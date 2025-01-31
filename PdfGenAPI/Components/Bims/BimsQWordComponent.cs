using GenPDF.Models;
using QuestPDF.Fluent;

namespace GenPDF.Components.Bims
{
    internal class BimsQWordComponent : QuestPDF.Infrastructure.IComponent
    {
        private readonly BimsModel _data;
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

        public BimsQWordComponent(BimsModel data)
        {
            _data = data;
        }

        public void Compose(QuestPDF.Infrastructure.IContainer container)
        {
            uint rowCount = 0;
            container.Table(table =>
            {
                table.ColumnsDefinition(column =>
                {
                    for (int i = 0; i < 12; i++)
                    {
                        column.RelativeColumn();
                    }
                });
                //Header
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(10)
                    .PaddingBottom(10)
                    .Text("Brief Interview for Mental Status (BIMS)")
                    .Bold()
                    .AlignCenter()
                    .FontSize(15);
                //first Question
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text("Repetition of Three Words")
                    .Underline();
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingLeft(10)
                    .PaddingTop(3)
                    .Text(
                        "Ask resident: I am going to say three words for you to remember. Please repeat the words after I have said all three."
                    )
                    .Italic();
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingLeft(10)
                    .Text("The words are: sock, blue and bed")
                    .Italic();
                //answer
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingLeft(10)
                    .PaddingTop(5)
                    .Text("Number of words repeated after first attempt")
                    .Bold();
                var hightOfImage = 15;
                switch (_data.QNumberOfWords)
                {
                    case "0. None":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(yesCheck);

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("0.None")
                            .AlignRight();

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("1.One")
                            .AlignRight();

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("2.Two")
                            .AlignRight();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("3.Three")
                            .AlignRight();
                        break;
                    case "1. One":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("0.None")
                            .AlignRight();

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(yesCheck);

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("1.One")
                            .AlignRight();

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("2.Two")
                            .AlignRight();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("3.Three")
                            .AlignRight();
                        break;
                    case "2. Two":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("0.None")
                            .AlignRight();

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("1.One")
                            .AlignRight();

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("2.Two")
                            .AlignRight();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("3.Three")
                            .AlignRight();
                        break;
                    case "3. Three":
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("0.None")
                            .AlignRight();

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("1.One")
                            .AlignRight();

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("2.Two")
                            .AlignRight();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(yesCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("3.Three")
                            .AlignRight();
                        break;
                    default:
                        table
                            .Cell()
                            .Row(++rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(2)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("0.None")
                            .AlignRight();

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(4)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("1.One")
                            .AlignRight();

                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(6)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("2.Two")
                            .AlignRight();
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .Height(hightOfImage)
                            .Image(noCheck);
                        table
                            .Cell()
                            .Row(rowCount)
                            .Column(8)
                            .ColumnSpan(1)
                            .PaddingLeft(10)
                            .Text("3.Three")
                            .AlignRight();
                        break;
                }
            });
        }
    }
}
