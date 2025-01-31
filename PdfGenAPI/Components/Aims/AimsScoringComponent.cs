using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.Aims;

public class AimsScoringComponent : IComponent
{
    public void Compose(IContainer container)
    {
        uint rowCount = 0;
        container = container.Background(Colors.Grey.Lighten4);
        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (int i = 0; i < 36; i++)
                {
                    column.RelativeColumn();
                }
            });
            table.Cell().Row(++rowCount).Column(1).ColumnSpan(36).Text("SCORING:").FontSize(10);
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(36)
                .Text(
                    "\u2022Score the highest amplitude or frequency in a movement on the 0-4 scale, not the average;"
                );
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(36)
                .Text(
                    "\u2022Score Activated Movements the same way; do not lower those numbers as was proposed at one time;"
                );
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(36)
                .Text(
                    "\u2022A POSITIVE AIMS EXAMINATION IS A SCORE OF 2 IN TWO OR MORE MOVEMENTS or a SCORE OF 3 OR 4 IN A SINGLE MOVEMENT"
                );
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(36)
                .Text(
                    "\u2022Do not sum the scores: e.g. a patient who has scores 1 in four movements DOES NOT have a positive AIMS score of 4."
                );
        });
    }
}
