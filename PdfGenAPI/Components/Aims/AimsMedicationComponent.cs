using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.Aims;

public class AimsMedicationComponent(AimsModel data) : IComponent
{
    private AimsModel _data = data;

    public void Compose(IContainer container)
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
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .Text("CURRENT MEDICATIONS AND TOTAL MG/DAY")
                .Bold();
            if (_data.MedicationOne != null)
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("Medication One: ").Bold();
                        text.Span(_data.MedicationOne);
                        text.Span(" Dosage: ").Bold();
                        text.Span(_data.MedicationOneDosage);
                    });
            }
            if (_data.MedicationTwo != null)
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("Medication Two: ").Bold();
                        text.Span(_data.MedicationTwo);
                        text.Span(" Dosage: ").Bold();
                        text.Span(_data.MedicationTwoDosage);
                    });
            }
            if (_data.MedicationThree != null)
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("Medication Three: ").Bold();
                        text.Span(_data.MedicationThree);
                        text.Span(" Dosage: ").Bold();
                        text.Span(_data.MedicationThreeDosage);
                    });
            }
            ;
        });
    }
}
