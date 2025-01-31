using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryMedicationComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        uint columns = 12;
        uint rowCount = 0;

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
                .ColumnSpan(12)
                .BorderBottom(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingLeft(5)
                .PaddingTop(5)
                .Text("Medication Change/Refill")
                .Bold();
            //
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(3)
                .BorderBottom(1)
                .PaddingLeft(5)
                .BorderRight(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingTop(5)
                .Text(_data.MedicationOne);
            table
                .Cell()
                .Row(rowCount)
                .Column(4)
                .ColumnSpan(3)
                .BorderBottom(1)
                .PaddingLeft(5)
                .BorderRight(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingTop(5)
                .Text(_data.MedicationTwo);
            table
                .Cell()
                .Row(rowCount)
                .Column(7)
                .ColumnSpan(3)
                .BorderBottom(1)
                .PaddingLeft(5)
                .BorderRight(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingTop(5)
                .Text(_data.MedicationThree);
            table
                .Cell()
                .Row(rowCount)
                .Column(10)
                .ColumnSpan(3)
                .BorderBottom(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingLeft(5)
                .PaddingTop(5)
                .Text(_data.MedicationFour);
            //
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(3)
                .BorderBottom(1)
                .PaddingLeft(5)
                .BorderRight(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingTop(5)
                .Text(text =>
                {
                    text.Span($"{_data.Temp109} - ");
                    if (
                        _data.MedicationOneDosageChange == null
                        || _data.MedicationOneDosageChange == ""
                    )
                    {
                        text.Span($"{_data.MedicationOneDosage}");
                    }
                    else
                    {
                        text.Span($"{_data.MedicationOneDosageChange}");
                    }
                });
            table
                .Cell()
                .Row(rowCount)
                .Column(4)
                .ColumnSpan(3)
                .BorderBottom(1)
                .PaddingLeft(5)
                .BorderRight(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingTop(5)
                .Text(text =>
                {
                    text.Span($"{_data.Temp110} - ");
                    if (
                        _data.MedicationTwoDosageChange == null
                        || _data.MedicationTwoDosageChange == ""
                    )
                    {
                        text.Span($"{_data.MedicationTwoDosage}");
                    }
                    else
                    {
                        text.Span($"{_data.MedicationTwoDosageChange}");
                    }
                });
            table
                .Cell()
                .Row(rowCount)
                .Column(7)
                .ColumnSpan(3)
                .BorderBottom(1)
                .PaddingLeft(5)
                .BorderRight(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingTop(5)
                .Text(text =>
                {
                    text.Span($"{_data.Temp111} - ");
                    if (
                        _data.MedicationThreeDosageChange == null
                        || _data.MedicationThreeDosageChange == ""
                    )
                    {
                        text.Span($"{_data.MedicationThreeDosage}");
                    }
                    else
                    {
                        text.Span($"{_data.MedicationThreeDosageChange}");
                    }
                });
            table
                .Cell()
                .Row(rowCount)
                .Column(10)
                .ColumnSpan(3)
                .BorderBottom(1)
                .PaddingLeft(5)
                .BorderRight(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingTop(5)
                .Text(text =>
                {
                    text.Span($"{_data.Temp112} - ");
                    if (
                        _data.MedicationFourDosageChange == null
                        || _data.MedicationFourDosageChange == ""
                    )
                    {
                        text.Span($"{_data.MedicationFourDosage}");
                    }
                    else
                    {
                        text.Span($"{_data.MedicationFourDosageChange}");
                    }
                });
        });
    }
}
