using GenPDF.Utils;
using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryEvalHeaderComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (var i = 0; i < 12; i++)
                {
                    column.RelativeColumn();
                }
            });
            table.Cell().Row(1).Column(1).ColumnSpan(12).Height(40).Image(Logo.GetLogo());
            table
                .Cell()
                .Row(1)
                .Column(2)
                .ColumnSpan(10)
                .AlignCenter()
                .Height(40)
                .Text(text =>
                {
                    text.Span("PSYCHIATRIC EVALUATION & CONSULTATION").Bold();
                });
            table
                .Cell()
                .Row(1)
                .Column(10)
                .ColumnSpan(2)
                .AlignCenter()
                .Height(40)
                .Text(text =>
                {
                    text.Span("Page ");
                    text.CurrentPageNumber();
                    text.Span(" of ");
                    text.TotalPages();
                });

            //haeder left
            table
                .Cell()
                .Row(2)
                .Column(1)
                .ColumnSpan(6)
                .Text(text =>
                {
                    text.Span("Patient Name: ").Bold();
                    text.Span(_data.PatientName);
                });
            table
                .Cell()
                .Row(3)
                .Column(1)
                .ColumnSpan(6)
                .Text(text =>
                {
                    text.Span("Provider: ").Bold();
                    text.Span(_data.Provider);
                });

            //header rigth
            table
                .Cell()
                .Row(2)
                .Column(7)
                .ColumnSpan(5)
                .Text(text =>
                {
                    text.Span("Facility: ").Bold();
                    text.Span(_data.Facility);
                });
            table
                .Cell()
                .Row(3)
                .Column(7)
                .ColumnSpan(5)
                .Text(text =>
                {
                    text.Span("Service Date: ").Bold();
                    text.Span(_data.ServiceDate);
                });
            if (_data.EndTime != null)
            {
                table
                    .Cell()
                    .Row(4)
                    .Column(7)
                    .ColumnSpan(5)
                    .Text(text =>
                    {
                        text.Span($"Start Time:{_data.StartTime} - End time:{_data.EndTime}")
                            .Bold();
                    });
            }
            table
                .Cell()
                .Row(4)
                .Column(1)
                .ColumnSpan(6)
                .Text(text =>
                {
                    text.Span("CptCode: ").Bold();
                    text.Span(_data.CptCode);
                    text.Span(" - ");
                    text.Span(_data.CptAddon);
                });

            // Line
            table
                .Cell()
                .Row(5)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(5)
                .LineHorizontal(1)
                .LineColor(Colors.Grey.Darken1);
        });
    }
}
