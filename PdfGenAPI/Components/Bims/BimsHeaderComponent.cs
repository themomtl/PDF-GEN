using GenPDF.Models;
using GenPDF.Utils;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Bims
{
    public class BimsHeaderComponent(BimsModel data) : IComponent
    {
        public BimsModel _data = data;

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
                        text.Span("   Pyschological Services \n").Bold();
                        text.Span("         SupportiveCare \n").Bold();
                        text.Span("PSYCHOSOCIAL EVALUATION").Bold();
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
                        text.Span("Date of birth: ").Bold();
                        text.Span(_data.DOB);
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
                        text.Span("Service Date: ").Bold();
                        text.Span(_data.ServiceDate);
                    });

                // Line
                table.Cell().Row(4).Column(1).ColumnSpan(12).PaddingTop(5).LineHorizontal(1);
            });
        }
    }
}
