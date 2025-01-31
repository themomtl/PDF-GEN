using GenPDF.Components;
using PdfGenAPI.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PdfGenAPI.Components.Aims;

public class AimsBodyComponent(AimsModel data) : IComponent
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
                .Component(new AimsMedicationComponent(_data));
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(10)
                .Component(new AimsFacialComponent(_data));
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(10)
                .Component(new AimsExtremComponent(_data));
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(10)
                .Component(new AimsTrunkComponent(_data));
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(10)
                .Component(new AimsScoringComponent());
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(10)
                .Component(new AimsOverallComponent(_data));
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(10)
                .Component(new AimsDentalComponent(_data));
            if (_data.Comment?.Length >= 450)
            {
                table.Cell().Row(++rowCount).Column(1).PageBreak();
            }
            table
                .Cell()
                .Row(++rowCount)
                .Column(1)
                .ColumnSpan(12)
                .PaddingTop(10)
                .Element(container =>
                {
                    container
                        .ShowEntire()
                        .Column(column =>
                        {
                            column.Item().Component(new AimsCommentComponent(_data));
                            column.Item().Component(new SignatureComponent(_data));
                        });
                });
        });
    }
}
