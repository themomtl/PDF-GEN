using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.Aims;

public class AimsDentalComponent(AimsModel data) : IComponent
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

            table.Cell().Row(++rowCount).Column(1).ColumnSpan(24).Text("Dental Status").Bold();
            table.Cell().Row(rowCount).Column(26).ColumnSpan(2).AlignCenter().Text("Yes").Bold();
            table.Cell().Row(rowCount).Column(28).ColumnSpan(2).AlignCenter().Text("No").Bold();

            table
                .Cell()
                .Row(++rowCount)
                .Column(2)
                .ColumnSpan(24)
                .Text("11. Current problems with teeth and/or dentures");
            switch (_data.DentalProblem?.ToUpper())
            {
                case "YES":
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
                    break;
                case "NO":
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
                    break;
            }

            table
                .Cell()
                .Row(++rowCount)
                .Column(2)
                .ColumnSpan(24)
                .Text("12. Does patient usually wear dentures");
            switch (_data.DentalDentures?.ToUpper())
            {
                case "YES":
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
                    break;
                case "NO":
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
                    break;
            }
        });
    }
}
