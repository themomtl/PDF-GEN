using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.Aims;

public class AimsFacialComponent(AimsModel data) : IComponent
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
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(36)
                .AlignCenter()
                .Text(
                    "INSTRUCTIONS: COMPLETE THE EXAMINATION PROCEDURE BEFORE ENTERING THESE RATINGS."
                )
                .Bold();
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(36)
                .AlignCenter()
                .Text(
                    "0. None, normal - 1. Minimal (maybe extreme normal)- 2. Mild - 3. Moderate - 4. Severe"
                );

            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(24)
                .Text("Facial and Oral Movements")
                .Bold();
            table.Cell().Row(rowCount).Column(26).ColumnSpan(2).AlignCenter().Text("0").Bold();
            table.Cell().Row(rowCount).Column(28).ColumnSpan(2).AlignCenter().Text("1").Bold();
            table.Cell().Row(rowCount).Column(30).ColumnSpan(2).AlignCenter().Text("2").Bold();
            table.Cell().Row(rowCount).Column(32).ColumnSpan(2).AlignCenter().Text("3").Bold();
            table.Cell().Row(rowCount).Column(34).ColumnSpan(2).AlignCenter().Text("4").Bold();

            table
                .Cell()
                .Row(++rowCount)
                .Column(2)
                .ColumnSpan(24)
                .Text(
                    "1. Muscles of Facial Expression e.g., movements of forehead, eyebrows, periorbital area, cheeks; include frowning, blinking, smiling, grimacing"
                );
            switch (_data.FacialMuscales)
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
            table
                .Cell()
                .Row(++rowCount)
                .Column(2)
                .ColumnSpan(24)
                .Text("2. Lips and Perioral Area (e.g., puckering, pouting, smacking)");
            switch (_data.FacialLips)
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
            table
                .Cell()
                .Row(++rowCount)
                .Column(2)
                .ColumnSpan(24)
                .Text("3. Jaw e.g., biting, clenching, chewing, mouth opening, lateral movement");
            switch (_data.FacialJaw)
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
            table
                .Cell()
                .Row(++rowCount)
                .Column(2)
                .ColumnSpan(24)
                .Text(
                    "4. Rate only increases in movement both in and out of mouth, NOT inability to sustain movement"
                );
            switch (_data.FacialTongue)
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
