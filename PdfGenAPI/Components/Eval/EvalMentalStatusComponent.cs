using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Eval
{
    public class EvalMentalStatusComponent : IComponent
    {
        private EvalProgModel _data;

        private List<string> _titles = new()
        {
            "Appearance:",
            "Behavior:",
            "Affect:",
            "Speech:",
            "Thought Process:",
            "Thought Content:",
            "Hallucination:",
            "Delusion:",
            "Self Perception:",
            "Orientation:",
            "Memory:",
            "Cognitive:",
            "Judgment:",
        };
        private uint _rowCount = 0;
        private uint _padding = 0;

        public EvalMentalStatusComponent(EvalProgModel data)
        {
            _data = data;
        }

        public EvalMentalStatusComponent(EvalProgModel data, uint padding)
        {
            _padding = padding;
            _data = data;
        }

        public void Compose(IContainer container)
        {
            List<string> listOfProps = GetProps(_data);
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
                    .Row(++_rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(_padding + 5)
                    .Text("MENTAL STATUS EXAM")
                    .Underline()
                    .Bold()
                    .FontSize(12);
                for (int i = 0; i < listOfProps.Count; ++i)
                {
                    table
                        .Cell()
                        .Row(++_rowCount)
                        .Column(1)
                        .ColumnSpan(2)
                        .PaddingTop(_padding)
                        .Text(_titles[i])
                        .Bold();
                    table
                        .Cell()
                        .Row(_rowCount)
                        .Column(3)
                        .ColumnSpan(9)
                        .PaddingTop(_padding)
                        .Text(listOfProps[i]);
                }
                //Risk Factor
                table
                    .Cell()
                    .Row(++_rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(_padding)
                    .Text("RISK FACTORS (stressors) that may adversely affect psychosocial status:")
                    .Bold();
                table
                    .Cell()
                    .Row(++_rowCount)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(_padding)
                    .Text(_data.RiskFactor);
            });
        }

        private List<string> GetProps(EvalProgModel model)
        {
            return new List<string>
            {
                model.Appearance ?? "",
                model.Behavior ?? "",
                model.Affect ?? "",
                model.Speech ?? "",
                model.ThoughtProcess ?? "",
                model.ThoughtContent ?? "",
                model.Hallucination ?? "",
                model.Delusion ?? "",
                model.SelfPerception ?? "",
                model.Orientation ?? "",
                model.Memory ?? "",
                model.Cognitive ?? "",
                model.Judgment ?? "",
            };
        }
    }
}
