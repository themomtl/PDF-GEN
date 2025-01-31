using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace GenPDF.Components.Eval
{
    internal class EvalCompTraumaComponent : IComponent
    {
        private EvalProgModel _data;
        private uint _rowNum;
        private List<string> _prevTitle = new()
        {
            "a. Mental disorder?",
            "b. Psychosocial adjustment difficulty?",
            "c. History of trauma?",
        };
        private List<string> _haveHadTitle = new()
        {
            "a. Life-threatening illness?",
            "b. Serious accident?",
        };
        private List<string> _haveBeenTitle = new()
        {
            "a. Physically assaulted?",
            "b. Physically threatened?",
            "c. Sexually threatened?",
            "d. Sexually assaulted?",
        };
        private List<string> _lines345Title = new()
        {
            "3. Have you ever been in a situation that was extremely frightening?",
            "4. Have you witnessed any extremely frightening situations?",
            "5. Do you have a close relationship with someone who experienced \r\nany extremely frightening situations?",
        };
        private List<string> _feltTitle = new()
        {
            "a. Decreased social interaction or withdrawn?",
            "b. Angry?",
            "c. Persistent negative mood state?",
        };

        public EvalCompTraumaComponent(EvalProgModel data)
        {
            _data = data;
        }

        void IComponent.Compose(IContainer container)
        {
            List<string> prevDocProps = GetPrevDocProps(_data);
            List<string> haveHadProps = GetHaveHadProps(_data);
            List<string> haveBeenProps = GetHaveBeenProps(_data);
            List<string> lines345Props = Get345Props(_data);
            List<string> feltProps = GetFeltProps(_data);
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
                    .Row(++_rowNum)
                    .ColumnSpan(12)
                    .AlignCenter()
                    .Text("Comprehensive Trauma Screening")
                    .Bold()
                    .FontSize(18)
                    .Underline();
                //section 1
                table
                    .Cell()
                    .Row(++_rowNum)
                    .ColumnSpan(12)
                    .PaddingTop(10)
                    .Text(
                        "Section I: The following questions should be completed by the Facility Social Worker using information from the Resident’s Medical Records."
                    )
                    .FontSize(11)
                    .FontColor(Colors.Grey.Darken2)
                    .Bold();
                //part 1
                table
                    .Cell()
                    .Row(++_rowNum)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text("1. Does the Resident have a previously documented diagnosis of:")
                    .FontColor(Colors.Grey.Darken2)
                    .Bold();
                for (int i = 0; i < prevDocProps.Count; i++)
                {
                    table
                        .Cell()
                        .Row(++_rowNum)
                        .Column(1)
                        .ColumnSpan(4)
                        .PaddingLeft(10)
                        .PaddingTop(5)
                        .Text(_prevTitle[i])
                        .FontColor(Colors.Grey.Medium);
                    table
                        .Cell()
                        .Row(_rowNum)
                        .Column(6)
                        .ColumnSpan(6)
                        .PaddingTop(5)
                        .Text(prevDocProps[i])
                        .Bold();
                }
                //part 2
                table
                    .Cell()
                    .Row(++_rowNum)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text("2. Post-Traumatic Stress Disorder?")
                    .FontColor(Colors.Grey.Darken2)
                    .Bold();
                table
                    .Cell()
                    .Row(_rowNum)
                    .Column(6)
                    .ColumnSpan(6)
                    .PaddingTop(5)
                    .Text(_data.TrPostTrauma)
                    .Bold();
                //section 2
                table
                    .Cell()
                    .Row(++_rowNum)
                    .ColumnSpan(12)
                    .PaddingTop(10)
                    .Text(
                        "Section II: The following questions should asked to the Resident verbally when completing\r\nthe Initial Psycho Social Assessment upon Admission"
                    )
                    .FontSize(11)
                    .FontColor(Colors.Grey.Darken2)
                    .Bold();
                //part 1
                table
                    .Cell()
                    .Row(++_rowNum)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text("1. Have you ever had a:")
                    .FontColor(Colors.Grey.Darken2)
                    .Bold();
                for (int i = 0; i < haveHadProps.Count; i++)
                {
                    table
                        .Cell()
                        .Row(++_rowNum)
                        .Column(1)
                        .ColumnSpan(4)
                        .PaddingLeft(10)
                        .PaddingTop(5)
                        .Text(_haveHadTitle[i])
                        .FontColor(Colors.Grey.Medium);
                    table
                        .Cell()
                        .Row(_rowNum)
                        .Column(6)
                        .ColumnSpan(6)
                        .PaddingTop(5)
                        .Text(haveHadProps[i])
                        .Bold();
                }
                //part 2
                table
                    .Cell()
                    .Row(++_rowNum)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text("2. Have you even been:")
                    .FontColor(Colors.Grey.Darken2)
                    .Bold();
                for (int i = 0; i < haveBeenProps.Count; i++)
                {
                    table
                        .Cell()
                        .Row(++_rowNum)
                        .Column(1)
                        .ColumnSpan(4)
                        .PaddingLeft(10)
                        .PaddingTop(5)
                        .Text(_haveBeenTitle[i])
                        .FontColor(Colors.Grey.Medium);
                    table
                        .Cell()
                        .Row(_rowNum)
                        .Column(6)
                        .ColumnSpan(6)
                        .PaddingTop(5)
                        .Text(haveBeenProps[i])
                        .Bold();
                }
                //Parts 3 4 5
                for (int i = 0; i < lines345Props.Count; i++)
                {
                    table
                        .Cell()
                        .Row(++_rowNum)
                        .Column(1)
                        .ColumnSpan(7)
                        .PaddingTop(5)
                        .Text(_lines345Title[i])
                        .FontColor(Colors.Grey.Darken2)
                        .Bold();
                    table
                        .Cell()
                        .Row(_rowNum)
                        .Column(9)
                        .ColumnSpan(3)
                        .PaddingTop(5)
                        .Text(lines345Props[i])
                        .Bold();
                }
                //part 6
                table
                    .Cell()
                    .Row(++_rowNum)
                    .ColumnSpan(12)
                    .PaddingTop(5)
                    .Text(
                        "6. Have you recently felt any of the following due to any of the situations just asked about"
                    )
                    .FontColor(Colors.Grey.Darken2)
                    .Bold();
                for (int i = 0; i < feltProps.Count; i++)
                {
                    table
                        .Cell()
                        .Row(++_rowNum)
                        .Column(1)
                        .ColumnSpan(4)
                        .PaddingLeft(10)
                        .PaddingTop(5)
                        .Text(_feltTitle[i])
                        .FontColor(Colors.Grey.Medium);
                    table
                        .Cell()
                        .Row(_rowNum)
                        .Column(6)
                        .ColumnSpan(6)
                        .PaddingTop(5)
                        .Text(feltProps[i])
                        .Bold();
                }
                //Summary
                table
                    .Cell()
                    .Row(++_rowNum)
                    .Column(1)
                    .ColumnSpan(12)
                    .PaddingTop(10)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(2)
                    .Text(text =>
                    {
                        text.Span("Counseling session summary")
                            .Bold()
                            .FontColor(Colors.Grey.Darken2);
                    });
                table
                    .Cell()
                    .Row(++_rowNum)
                    .Column(1)
                    .ColumnSpan(12)
                    .Border(1)
                    .BorderColor(Colors.Grey.Darken1)
                    .PaddingLeft(2)
                    .Height(75)
                    .Text(text =>
                    {
                        if (_data.TrSummary == null || _data.TrSummary == "")
                        {
                            text.Span("N/A").Bold();
                        }
                        text.Span(_data.TrSummary).Bold();
                    });
            });
        }

        private List<string> GetPrevDocProps(EvalProgModel model)
        {
            return new List<string>
            {
                model.TrMental ?? "",
                model.TrPsych ?? "",
                model.TrHistory ?? "",
            };
        }

        private List<string> GetHaveHadProps(EvalProgModel model)
        {
            return new List<string> { model.TrIllness ?? "", model.TrAccident ?? "" };
        }

        private List<string> GetHaveBeenProps(EvalProgModel model)
        {
            return new List<string>
            {
                model.TrAssault ?? "",
                model.TrThreat ?? "",
                model.TrSexAssault ?? "",
                model.TrSexThreat ?? "",
            };
        }

        private List<string> Get345Props(EvalProgModel model)
        {
            return new List<string>
            {
                model.TrFright ?? "",
                model.TrFrightWitness ?? "",
                model.TrFrightRel ?? "",
            };
        }

        private List<string> GetFeltProps(EvalProgModel model)
        {
            return new List<string>
            {
                model.TrWithdrawn ?? "",
                model.TrAngry ?? "",
                model.TrMood ?? "",
            };
        }
    }
}
