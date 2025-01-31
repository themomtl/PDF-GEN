using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryGdrComponent(PsychiatryEvalModel data) : IComponent
{
    private readonly byte[] noCheck = File.ReadAllBytes(
        Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "img/checkbox-unchecked-svgrepo-com.png"
        )
    );

    private readonly byte[] yesCheck = File.ReadAllBytes(
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img/checkbox-check-svgrepo-com.png")
    );

    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        uint columns = 12;
        uint rowCount = 0;
        uint paddingTop = 5;
        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (int i = 0; i < columns; i++)
                {
                    column.RelativeColumn();
                }
            });
            switch (_data.GDR?.ToUpper())
            {
                case "INDICATED":
                    table
                        .Cell()
                        .Row(++rowCount)
                        .Column(1)
                        .ColumnSpan(3)
                        .PaddingTop(paddingTop)
                        .Text("GDR: Indicated")
                        .FontColor(Colors.Grey.Darken1);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(4)
                        .ColumnSpan(1)
                        .PaddingTop(paddingTop)
                        .Height(15)
                        .Image(yesCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(5)
                        .ColumnSpan(3)
                        .PaddingTop(paddingTop)
                        .Text("Not Indicated")
                        .FontColor(Colors.Grey.Darken1);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(8)
                        .ColumnSpan(1)
                        .PaddingTop(paddingTop)
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(9)
                        .ColumnSpan(3)
                        .PaddingTop(paddingTop)
                        .Text("In Progress")
                        .FontColor(Colors.Grey.Darken1);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(12)
                        .ColumnSpan(1)
                        .PaddingTop(paddingTop)
                        .Height(15)
                        .Image(noCheck);
                    break;
                case "NOT INDICATED":
                    table
                        .Cell()
                        .Row(++rowCount)
                        .Column(1)
                        .ColumnSpan(3)
                        .PaddingTop(paddingTop)
                        .Text("GDR: Indicated")
                        .FontColor(Colors.Grey.Darken1);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(4)
                        .ColumnSpan(1)
                        .PaddingTop(paddingTop)
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(5)
                        .ColumnSpan(3)
                        .PaddingTop(paddingTop)
                        .Text("Not Indicated")
                        .FontColor(Colors.Grey.Darken1);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(8)
                        .ColumnSpan(1)
                        .PaddingTop(paddingTop)
                        .Height(15)
                        .Image(yesCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(9)
                        .ColumnSpan(3)
                        .PaddingTop(paddingTop)
                        .Text("In Progress")
                        .FontColor(Colors.Grey.Darken1);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(12)
                        .ColumnSpan(1)
                        .PaddingTop(paddingTop)
                        .Height(15)
                        .Image(noCheck);
                    break;
                case "IN PROGRESS"
                or "INPROGRESS":
                    table
                        .Cell()
                        .Row(++rowCount)
                        .Column(1)
                        .ColumnSpan(3)
                        .PaddingTop(paddingTop)
                        .Text("GDR: Indicated")
                        .FontColor(Colors.Grey.Darken1);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(4)
                        .ColumnSpan(1)
                        .PaddingTop(paddingTop)
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(5)
                        .ColumnSpan(3)
                        .PaddingTop(paddingTop)
                        .Text("Not Indicated")
                        .FontColor(Colors.Grey.Darken1);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(8)
                        .ColumnSpan(1)
                        .PaddingTop(paddingTop)
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(9)
                        .ColumnSpan(3)
                        .PaddingTop(paddingTop)
                        .Text("In Progress")
                        .FontColor(Colors.Grey.Darken1);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(12)
                        .ColumnSpan(1)
                        .PaddingTop(paddingTop)
                        .Height(15)
                        .Image(yesCheck);
                    break;
            }
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .Padding(5)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .MinHeight(100)
                .Text(_data.GdrText)
                .FontColor(Colors.Grey.Darken1);
        });
    }
}
