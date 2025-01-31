using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Eval
{
    public class EvalTreatmentPlanComponent : IComponent
    {
        public EvalProgModel _data;
        private uint rowNum = 0;

        //list of treatment plan ti
        private List<string> _titels = new()
        {
            "Therapeutic Goals:",
            "Objectives (Prevention) :",
            "Objectives (Treatment) :",
            "Modalities Recommended:",
            "Recommendations:",
            "Recommendations Notes:",
        };

        private readonly byte[] noCheck = File.ReadAllBytes(
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "img/checkbox-unchecked-svgrepo-com.png"
            )
        );

        private readonly byte[] yesCheck = File.ReadAllBytes(
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "img/checkbox-check-svgrepo-com.png"
            )
        );

        public EvalTreatmentPlanComponent(EvalProgModel data)
        {
            _data = data;
        }

        public void Compose(IContainer container)
        {
            var props = GetProps(_data);

            container.Table(table =>
            {
                table.ColumnsDefinition(column =>
                {
                    for (int i = 0; i < 12; i++)
                    {
                        column.RelativeColumn();
                    }
                });

                //Treatment Plan
                table
                    .Cell()
                    .Row(++rowNum)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text("TREATMENT PLAN")
                    .Underline()
                    .Bold()
                    .FontSize(12);
                for (int i = 0; i < props.Count; i++)
                {
                    table
                        .Cell()
                        .Row(++rowNum)
                        .Column(1)
                        .ColumnSpan(3)
                        .PaddingTop(5)
                        .Text(_titels[i])
                        .Bold();
                    table.Cell().Row(rowNum).Column(4).ColumnSpan(8).PaddingTop(5).Text(props[i]);
                }

                table
                    .Cell()
                    .Row(++rowNum)
                    .Column(1)
                    .ColumnSpan(3)
                    .PaddingTop(5)
                    .Text("Frequency:")
                    .Bold();
                table
                    .Cell()
                    .Row(rowNum)
                    .Column(4)
                    .ColumnSpan(8)
                    .PaddingTop(5)
                    .Text(_data.Frequency);

                //Family session/ Group Session
                table
                    .Cell()
                    .Row(rowNum)
                    .Column(6)
                    .ColumnSpan(6)
                    .PaddingTop(5)
                    .Text("Family Session ")
                    .Bold();
                if (_data.SesFam == "Yes")
                {
                    table
                        .Cell()
                        .Row(rowNum)
                        .Column(7)
                        .ColumnSpan(1)
                        .PaddingTop(5)
                        .PaddingLeft(10)
                        .AlignCenter()
                        .Height(12)
                        .Image(yesCheck);
                }
                else
                {
                    table
                        .Cell()
                        .Row(rowNum)
                        .Column(7)
                        .ColumnSpan(1)
                        .PaddingTop(5)
                        .PaddingLeft(10)
                        .AlignCenter()
                        .Height(12)
                        .Image(noCheck);
                }
                table
                    .Cell()
                    .Row(rowNum)
                    .Column(9)
                    .ColumnSpan(3)
                    .PaddingTop(5)
                    .Text("Group Session")
                    .Bold();
                if (_data.SesGroup == "Yes")
                {
                    table
                        .Cell()
                        .Row(rowNum)
                        .Column(10)
                        .ColumnSpan(1)
                        .PaddingTop(5)
                        .PaddingLeft(10)
                        .AlignCenter()
                        .Height(12)
                        .Image(yesCheck);
                }
                else
                {
                    table
                        .Cell()
                        .Row(rowNum)
                        .Column(10)
                        .ColumnSpan(1)
                        .PaddingTop(5)
                        .PaddingLeft(10)
                        .AlignCenter()
                        .Height(12)
                        .Image(noCheck);
                }
                //session summary
                table
                    .Cell()
                    .Row(++rowNum)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text("Session Summary")
                    .Bold();
                table.Cell().Row(++rowNum).Column(1).ColumnSpan(12).Text(_data.Notes);
            });
        }

        private List<string> GetProps(EvalProgModel model)
        {
            return new List<string>
            {
                model.Goals ?? "",
                model.Prevention ?? "",
                model.Treatment ?? "",
                model.Modalities ?? "",
                model.Recommendations ?? "",
                model.RecoNotes ?? "",
            };
        }
    }
}
