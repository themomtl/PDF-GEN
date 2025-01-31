using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.Aims;

public class AimsTrunkComponent(AimsModel data) : IComponent
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

    private AimsModel _data = data;

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

            table.Cell().Row(++rowCount).Column(1).ColumnSpan(24).Text("Trunk Movements").Bold();

            table
                .Cell()
                .Row(++rowCount)
                .Column(2)
                .ColumnSpan(24)
                .Text(
                    "7. Neck, shoulders, hips (e.g., rocking, twisting, squirming, pelvic gyrations)"
                );
            switch (_data.TrunkNeck)
            {
                case 0:
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(26)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(yesCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(28)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(30)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(32)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(34)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    break;
                case 1:
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(26)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(28)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(yesCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(30)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(32)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(34)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    break;
                case 2:
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(26)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(28)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(30)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(yesCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(32)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(34)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    break;
                case 3:
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(26)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(28)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(30)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(32)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(yesCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(34)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    break;
                case 4:
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(26)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(28)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(30)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(32)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(34)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(yesCheck);
                    break;
                default:
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(26)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(28)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(30)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(32)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    table
                        .Cell()
                        .Row(rowCount)
                        .Column(34)
                        .ColumnSpan(2)
                        .AlignCenter()
                        .Height(15)
                        .Image(noCheck);
                    break;
            }
        });
    }
}
