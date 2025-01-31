using GenPDF.Utils;
using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.Aims;

public class AimsHeaderComponent(AimsModel data) : IComponent
{
    private AimsModel _data = data;

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
                    text.Span("ABNORMAL INVOLUNTARY MOVEMENT SCALE (AIMS)").Bold();
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
                .AlignCenter()
                .Text(text =>
                {
                    text.Span("Facility: ").Bold();
                    text.Span(_data.Facility);
                });
            table
                .Cell()
                .Row(3)
                .Column(8)
                .ColumnSpan(4)
                .Text(text =>
                {
                    text.Span("Aims Date: ").Bold();
                    text.Span(_data.AimsDate);
                });

            // Line
            table
                .Cell()
                .Row(4)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(5)
                .LineHorizontal(1)
                .LineColor(Colors.Grey.Darken1);
        });
    }
}
