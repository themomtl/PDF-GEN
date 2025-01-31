using GenPDF.Models;
using GenPDF.Utils;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.ProgressNote
{
    public class ProgressNoteHeaderComponent : IComponent
    {
        public EvalProgModel _data;

        public ProgressNoteHeaderComponent(EvalProgModel data)
        {
            _data = data;
        }

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
                        text.Span("Pyschological Services \n").Bold();
                        text.Span("     SupportiveCare \n").Bold();
                        text.Span("     PROGESS NOTE").Bold();
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
                        text.Span("Date Of Birth: ").Bold();
                        if (_data.DOB == null)
                        {
                            text.Span("N/A");
                        }
                        else
                        {
                            text.Span(_data.DOB);
                        }
                    });
                table
                    .Cell()
                    .Row(4)
                    .Column(1)
                    .ColumnSpan(6)
                    .Text(text =>
                    {
                        text.Span("      CPT Code: ").Bold();
                        text.Span(_data.CptCode);
                        if (_data.CptAddon != null)
                        {
                            text.Span($" - {_data.CptAddon}");
                        }
                    });

                //header rigth
                table
                    .Cell()
                    .Row(2)
                    .Column(8)
                    .ColumnSpan(4)
                    .Text(text =>
                    {
                        text.Span("          Facility: ").Bold();
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
                table
                    .Cell()
                    .Row(4)
                    .Column(7)
                    .ColumnSpan(5)
                    .Text(text =>
                    {
                        text.Span("    Start Time: ").Bold();
                        text.Span($"{_data.StartTime}");
                        text.Span("    End Time: ").Bold();
                        text.Span($"{_data.EndTime}");
                    });
                // Line
                table
                    .Cell()
                    .Row(5)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(10)
                    .LineHorizontal(1)
                    .LineColor(Colors.Grey.Darken1);
            });
        }
    }
}
