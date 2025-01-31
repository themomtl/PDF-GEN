using PdfGenAPI.Components.PsychiatryEval.SubComponents;
using PdfGenAPI.Data;
using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryEvalBodyComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

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
                .Component(new PsychiatrySectionOneComponent(_data));
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(5)
                .BorderRight(1)
                .BorderLeft(1)
                .BorderColor(Colors.Grey.Darken1)
                .Component(new PsychiatryEvalHistoryComponent(_data));

            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(5)
                .ShowEntire()
                .Component(new PsychiatryPhysicalExamComponent(_data));

            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .ShowEntire()
                .PaddingTop(5)
                .Component(new PsychiatryRosComponent(_data));

            if (
                (_data.LabsOrderedOne != null && _data.LabsOrderedOne != "")
                || (_data.LabsOrderedTwo != null && _data.LabsOrderedTwo != "")
                || (_data.LabsOrderedThree != null && _data.LabsOrderedThree != "")
                || (_data.LabsOrderedFour != null && _data.LabsOrderedFour != "")
            )
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .ShowEntire()
                    .Component(new PsychaitryLabsOrderedComponent(_data));
            }
            if (_data.LabsReviewedOne != null && _data.LabsReviewedOne != "")
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingTop(5)
                    .Component(new PsychiatryEvalLabsReviewedComponent(_data));
            }

            if (_data.PhoneReview == "1" || _data.PhoneReviewDoc == true)
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .ShowEntire()
                    .Component(new PsychiatryCollabComponent(_data));
            }
            if (_data.DocReview == "1" || _data.DocReviewDoc == true)
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .ShowEntire()
                    .Component(new PsychiatryDocReviewComponent(_data));
            }
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(5)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .ShowEntire()
                .Component(new PsychiatryDiagnosisComponent(_data));

            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(5)
                .Border(1)
                .BorderColor(Colors.Grey.Darken1)
                .ShowEntire()
                .Element(container =>
                {
                    container
                        .ShowEntire()
                        .Column(column =>
                        {
                            if (_data.CondOneCourse != null && _data.CondOneCourse != "")
                            {
                                column.Item().Component(new PsychiatryCourseComponent(_data));
                            }
                            column.Item().Component(new PsychiatryPlanComponent(_data));
                        });
                });

            if (
                (_data.MedicationOne != null && _data.MedicationOne != "")
                || (_data.MedicationTwo != null && _data.MedicationTwo != "")
                || (_data.MedicationThree != null && _data.MedicationThree != "")
                || (_data.MedicationFour != null && _data.MedicationFour != "")
            )
            {
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .Component(new PsychiatryMedicationComponent(_data));
            }

            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .ShowEntire()
                .Component(new LastSubComponent(_data));
        });
    }
}
