using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryDiagnosisComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        uint columns = 12;
        uint rows = 0;
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
                .Row(++rows)
                .Column(1)
                .ColumnSpan(12)
                .BorderBottom(1)
                .BorderColor(Colors.Grey.Darken1)
                .PaddingTop(5)
                .PaddingLeft(5)
                .Text("Diagnosis")
                .Bold();

            if (_data.DxCode != null && _data.DxCode != "")
            {
                table
                    .Cell()
                    .Row(++rows)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span($"{_data.DxCode} - \n").Bold();
                        text.Span($"Severity: ").Bold();
                        text.Span($"{_data.Dx1Severity} - ");
                        //status
                        if (_data.Dx1Status == null || _data.Dx1Status == "")
                        {
                            text.Span($"{_data.Temp113} - ");
                        }
                        else
                        {
                            text.Span($"{_data.Dx1Status} - ");
                        }
                        //risk
                        if (_data.Dx1risk == null || _data.Dx1risk == "")
                        {
                            text.Span($"{_data.Temp114}");
                        }
                        else
                        {
                            text.Span($"{_data.Dx1risk} - ");
                        }
                    });
            }
            if (_data.DxCode2 != null && _data.DxCode2 != "")
            {
                table
                    .Cell()
                    .Row(++rows)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span($"{_data.DxCode2} - \n").Bold();
                        text.Span($"Severity: ").Bold();
                        text.Span($"{_data.Dx2Severity} - ");
                        //status
                        if (_data.Dx2Status == null || _data.Dx2Status == "")
                        {
                            text.Span($"{_data.Temp115} - ");
                        }
                        else
                        {
                            text.Span($"{_data.Dx2Status} - ");
                        }
                        //risk
                        if (_data.Dx2risk == null || _data.Dx2risk == "")
                        {
                            text.Span($"{_data.Temp116}");
                        }
                        else
                        {
                            text.Span($"{_data.Dx2risk}");
                        }
                    });
            }
            if (_data.DxCode3 != null && _data.DxCode3 != "")
            {
                table
                    .Cell()
                    .Row(++rows)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span($"{_data.DxCode3} - \n").Bold();
                        text.Span($"Severity: ").Bold();
                        text.Span($"{_data.Dx3Severity} - ");
                        //status
                        if (_data.Dx3Status == null || _data.Dx3Status == "")
                        {
                            text.Span($"{_data.Temp117} - ");
                        }
                        else
                        {
                            text.Span($"{_data.Dx3Status} - ");
                        }
                        //risk
                        if (_data.Dx3risk == null || _data.Dx3risk == "")
                        {
                            text.Span($"{_data.Temp118}");
                        }
                        else
                        {
                            text.Span($"{_data.Dx3risk}");
                        }
                    });
            }
            if (_data.DxCode4 != null && _data.DxCode4 != "")
            {
                table
                    .Cell()
                    .Row(++rows)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .PaddingLeft(5)
                    .Text(text =>
                    {
                        text.Span($"{_data.DxCode4} - \n").Bold();
                        text.Span($"Severity: ").Bold();
                        text.Span($"{_data.Dx4Severity} - ");
                        //status
                        if (_data.Dx4Status == null || _data.Dx4Status == "")
                        {
                            text.Span($"{_data.Temp119}");
                        }
                        else
                        {
                            text.Span($"{_data.Dx4Status} - ");
                        }
                        //risk
                        if (_data.Dx4risk == null || _data.Dx4risk == "")
                        {
                            text.Span($"{_data.Temp120}");
                        }
                        else
                        {
                            text.Span($"{_data.Dx4risk}");
                        }
                    });
            }
        });
    }
}
