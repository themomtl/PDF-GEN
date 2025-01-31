using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.Aims;

public class AimsCommentComponent(AimsModel data) : IComponent
{
    private AimsModel _data = data;

    public void Compose(IContainer container)
    {
        var height = 20;
        if (_data.Comment?.Length >= 150)
        {
            height = 50;
        }
        if (_data.Comment?.Length >= 450)
        {
            height = 150;
        }
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
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .Text("Comments")
                .Bold();
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .Height(height)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .Text(_data.Comment)
                .Bold();
        });
    }
}
