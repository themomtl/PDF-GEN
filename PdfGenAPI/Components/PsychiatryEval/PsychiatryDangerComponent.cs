using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryDangerComponent(PsychiatryEvalModel data) : IComponent
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
        uint rowCount = 0;
        uint columns = 24;

        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (int i = 0; i < columns; i++)
                {
                    column.RelativeColumn();
                }
            });
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(5)
                .PaddingTop(5)
                .PaddingLeft(5)
                .Text("Aims N/A")
                .FontColor(Colors.Grey.Darken1);

            table
                .Cell()
                .Row(rowCount)
                .Column(6)
                .ColumnSpan(2)
                .PaddingTop(5)
                .PaddingLeft(1)
                .Height(15)
                .Image(_data.NpAims?.ToUpper() == "N/A" ? yesCheck : noCheck);
            table
                .Cell()
                .Row(rowCount)
                .Column(9)
                .ColumnSpan(15)
                .PaddingTop(5)
                .PaddingLeft(5)
                .Text(text =>
                {
                    text.Span("Date completed: ").FontColor(Colors.Grey.Darken1);
                    text.Span(
                            _data.AimsDate == null
                                ? ""
                                : Convert.ToDateTime(_data.AimsDate).ToShortDateString()
                        )
                        .FontColor(Colors.Grey.Darken1);
                });

            table
                .Cell()
                .Row(++rowCount)
                .Column(8)
                .ColumnSpan(8)
                .PaddingTop(5)
                .LineHorizontal(1)
                .LineColor(Colors.Grey.Darken1);
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(16)
                .Padding(7)
                .Text(text =>
                {
                    text.Span("At this time is Patient is considered a danger to self/others?")
                        .FontColor(Colors.Grey.Darken1);
                });
            table
                .Cell()
                .Row(rowCount)
                .Column(16)
                .ColumnSpan(2)
                .PaddingTop(15)
                .Text("No")
                .AlignRight();
            table
                .Cell()
                .Row(rowCount)
                .Column(18)
                .ColumnSpan(1)
                .PaddingTop(15)
                .Image(
                    (_data.Danger?.ToUpper() == "NO" || _data.Danger?.ToUpper() == "YES")
                        ? yesCheck
                        : noCheck
                );
            table
                .Cell()
                .Row(rowCount)
                .Column(20)
                .ColumnSpan(3)
                .PaddingTop(15)
                .Text("Danger")
                .FontColor(Colors.Red.Darken4);
            table
                .Cell()
                .Row(rowCount)
                .Column(23)
                .ColumnSpan(1)
                .PaddingTop(15)
                .Image(
                    (
                        _data.Danger?.ToUpper() == "ISDANGER"
                        || _data.Danger?.ToUpper() == "IS DANGER"
                    )
                        ? yesCheck
                        : noCheck
                );
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(17)
                .Padding(7)
                .Text(text =>
                {
                    text.Span("Patient would benefit from continued behavioral health?")
                        .FontColor(Colors.Grey.Darken1);
                });
            table
                .Cell()
                .Row(rowCount)
                .Column(16)
                .ColumnSpan(2)
                .PaddingTop(15)
                .Text("Yes")
                .AlignRight();
            table
                .Cell()
                .Row(rowCount)
                .Column(18)
                .ColumnSpan(1)
                .PaddingTop(15)
                .Image(_data.ContSrvce?.ToUpper() == "YES" ? yesCheck : noCheck);
            table
                .Cell()
                .Row(rowCount)
                .Column(20)
                .ColumnSpan(3)
                .PaddingTop(15)
                .Text("No")
                .AlignRight();
            table
                .Cell()
                .Row(rowCount)
                .Column(23)
                .ColumnSpan(1)
                .PaddingTop(15)
                .Image(_data.ContSrvce?.ToUpper() == "NO" ? yesCheck : noCheck);
        });
    }
}
