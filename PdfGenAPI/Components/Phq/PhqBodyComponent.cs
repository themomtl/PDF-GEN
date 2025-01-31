using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Phq
{
    public class PhqBodyComponent : IComponent
    {
        public PhqModel _data;

        public PhqBodyComponent(PhqModel data)
        {
            _data = data;
        }

        public void Compose(IContainer container)
        {
            uint row = 0;

            container.Table(table =>
            {
                table.ColumnsDefinition(column =>
                {
                    for (var i = 0; i < 12; i++)
                    {
                        column.RelativeColumn();
                    }
                });
                table.Cell().Row(++row).ColumnSpan(12).Component(new PhqPartOneComponent(_data));
                table
                    .Cell()
                    .Column(1)
                    .ColumnSpan(12)
                    .Row(++row)
                    .Element(container =>
                    {
                        container
                            .ShowEntire()
                            .Column(column =>
                            {
                                column.Item().Component(new PhqPartTwoComponent(_data));
                                column.Item().Component(new SignatureComponent(_data));
                            });
                    });
            });
        }
    }
}
