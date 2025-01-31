using GenPDF.Exceptions;
using GenPDF.Models;
using QuestPDF.Fluent;
using IComponent = QuestPDF.Infrastructure.IComponent;
using IContainer = QuestPDF.Infrastructure.IContainer;

namespace GenPDF.Components.ProgressNote
{
    public class ProgressNoteBodyComponent(EvalProgModel data) : IComponent
    {
        private EvalProgModel _data = data;

        public void Compose(IContainer container)
        {
            container.Table(table =>
            {
                table.ColumnsDefinition(colomns =>
                {
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                    colomns.RelativeColumn();
                });

                //report part of the page

                table.Cell().Row(1).ColumnSpan(12).Component(new DxComponent(_data.DxCodes));

                table.Cell().Row(2).ColumnSpan(12).Component(new CptCodeAddonComponent(_data));

                //symptoms row
                table
                    .Cell()
                    .Row(3)
                    .ColumnSpan(8)
                    .Text(text =>
                    {
                        text.Span("SYMPTOMS: (Symptoms that were focused on in this session)")
                            .Bold();
                    });
                table
                    .Cell()
                    .Row(4)
                    .Column(2)
                    .ColumnSpan(7)
                    .Text(text =>
                    {
                        text.Span("Psychological: ").Bold();
                        text.Span($"{_data.SymptomsPhysical} \n");

                        text.Span("Physical: ").Bold();
                        text.Span($"{_data.SymptomsPsych} \n");

                        text.Span("Dementia Risks: ").Bold();
                        text.Span($"{_data.DementiaRisks}");
                    });
                //func
                table
                    .Cell()
                    .Row(5)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span(
                                "FUNCTIONAL / BEHAVIORAL CHALLENGES: (Functional and Behavioral Challenges that were focused on in this session) \n"
                            )
                            .Bold();
                        text.Span($"{_data.Functional}");
                    });
                //stressors/changes
                table
                    .Cell()
                    .Row(6)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span(
                                "STRESSORS/CHANGES IN MENTAL STATUS: (Stressors, or changes in mental status that may affect functioning) \n"
                            )
                            .Bold();
                        text.Span($"{_data.StressorsChanges}");
                    });
                //therapeutic
                table
                    .Cell()
                    .Row(7)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("THERAPEUTIC GOALS WORKED ON IN THIS SESSION:\n").Bold();
                        text.Span($"{_data.Therapeutic}");
                    });
                table
                    .Cell()
                    .Row(8)
                    .Column(2)
                    .ColumnSpan(11)
                    .Text(text =>
                    {
                        text.Span("Objectives (Preventive) WORKED ON IN THIS SESSION:\n").Bold();
                        text.Span($"{_data.FuObjPrevention}");
                    });
                table
                    .Cell()
                    .Row(9)
                    .Column(2)
                    .ColumnSpan(11)
                    .Text(text =>
                    {
                        text.Span("Objectives (Treatment) WORKED ON IN THIS SESSION:\n").Bold();
                        text.Span($"{_data.FuObjTreatment}");
                    });
                //Specific Psychotherapeutics
                table
                    .Cell()
                    .Row(10)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("SPECIFIC PSYCHOTHERAPEUTIC INTERVENTIONS:\n").Bold();
                        text.Span($"{_data.Psychotherapeutic}");
                    });
                table
                    .Cell()
                    .Row(11)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("RESULTS OF PSYCHOTHERAPY:\n").Bold();
                        text.Span($"{_data.Result}");
                    });
                table
                    .Cell()
                    .Row(12)
                    .Column(2)
                    .ColumnSpan(11)
                    .Text(text =>
                    {
                        text.Span("Improved: ").Bold();
                        text.Span($"{_data.Improved} \n");
                        text.Span("Improved: ").Bold();
                        text.Span($"{_data.Identified} \n");
                        text.Span("Improved: ").Bold();
                        text.Span($"{_data.Reduced} \n");
                    });
                table
                    .Cell()
                    .Row(13)
                    .Column(1)
                    .ColumnSpan(12)
                    .Text(text =>
                    {
                        text.Span("DISPOSITION / RATIONALE FOR CONTINUED TREATMENT:\n").Bold();
                        text.Span($"{_data.Disposition}");
                    });

                table
                    .Cell()
                    .Row(14)
                    .Column(1)
                    .ColumnSpan(12)
                    .AlignCenter()
                    .Element(container =>
                    {
                        container
                            .ShowEntire()
                            .Column(column =>
                            {
                                column
                                    .Item()
                                    .Text(text =>
                                    {
                                        text.Span(
                                                "Summarize Progress and plan: (Include significant developments since last session, session gains, additional recommendations, comments)\n"
                                            )
                                            .Bold();
                                        text.Span($"{_data.Notes} \n");
                                    });
                                if (_data.TeleHealth == "1")
                                {
                                    column
                                        .Item()
                                        .Text(text =>
                                        {
                                            text.Span(
                                                "This session has been done via telemedicine \nand patient consent has been \nobtained"
                                            );
                                        });
                                }
                                column.Item().Component(new SignatureWithTextComponent(_data));
                            });
                    });
            });
        }
    }
}
