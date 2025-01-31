using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Bims
{
    internal class BimsBodyComponent : IComponent
    {
        private readonly BimsModel _data;

        public BimsBodyComponent(BimsModel data)
        {
            _data = data;
        }

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
                    .Component(new BimsQWordComponent(_data));
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(10)
                    .Component(new BimsOrientationComponent(_data));
                table
                    .Cell()
                    .Row(++rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(10)
                    .Component(new BimsRecallComponent(_data));
            });
        }
    }
}
