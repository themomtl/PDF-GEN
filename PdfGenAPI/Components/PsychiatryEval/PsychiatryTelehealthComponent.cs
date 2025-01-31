using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.PsychiatryEval;

public class PsychiatryTelehealthComponent(PsychiatryEvalModel data) : IComponent
{
    private PsychiatryEvalModel _data = data;

    public void Compose(IContainer container)
    {
        uint rowCount = 0;
        uint columns = 12;
        container.Table(table =>
        {
            table.ColumnsDefinition(column =>
            {
                for (int i = 0; i < columns; i++)
                {
                    column.RelativeColumn();
                }
            });
            if (_data.TeleHealth == "1" && (_data.SupcareFacId != 49 || _data.AppCo != "PA"))
            {
                if (Convert.ToDateTime(_data.ServiceDate) < new DateTime(2023, 6, 1))
                {
                    table
                        .Cell()
                        .Row(++rowCount)
                        .Column(1)
                        .ColumnSpan(columns)
                        .Text(
                            "Due to the COVID-19 outbreak: This session was performed via TeleHealth"
                        );
                }
                else
                {
                    table
                        .Cell()
                        .Row(++rowCount)
                        .Column(1)
                        .ColumnSpan(columns)
                        .Text(
                            "This session has been done via tele-medicine and patient consent has been obtained"
                        );
                }
            }
        });
    }
}
