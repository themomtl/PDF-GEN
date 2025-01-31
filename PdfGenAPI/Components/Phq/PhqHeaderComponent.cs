using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Phq
{
    public class PhqHeaderComponent : IComponent
    {
        private PhqModel _model;

        public PhqHeaderComponent(PhqModel model)
        {
            _model = model;
        }

        void IComponent.Compose(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(column =>
                {
                    for (var i = 0; i < 12; i++)
                    {
                        column.RelativeColumn();
                    }
                    ;
                });
                table
                    .Cell()
                    .Row(1)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingBottom(15)
                    .Text("Patient Health Questionnaire (PHQ-9)")
                    .Bold()
                    .FontSize(15)
                    .AlignCenter();
                //left
                table
                    .Cell()
                    .Row(2)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("Patiant Name: ").Bold();
                        text.Span(_model.PatientName);
                    });
                table
                    .Cell()
                    .Row(3)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("Date of Birth: ").Bold();
                        text.Span(_model.DOB);
                    });
                //right
                table
                    .Cell()
                    .Row(2)
                    .Column(8)
                    .ColumnSpan(4)
                    .Text(text =>
                    {
                        text.Span("Facility: ").Bold();
                        text.Span(_model.Facility);
                    });
                table
                    .Cell()
                    .Row(3)
                    .Column(8)
                    .ColumnSpan(4)
                    .Text(text =>
                    {
                        text.Span("Date: ").Bold();
                        text.Span(_model.Date);
                    });
                //line
                table
                    .Cell()
                    .Row(4)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .LineHorizontal(1)
                    .LineColor(Colors.Grey.Darken1);
            });
        }
    }
}
