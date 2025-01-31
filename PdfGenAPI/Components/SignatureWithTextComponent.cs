using GenPDF.Exceptions;
using GenPDF.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components
{
    internal class SignatureWithTextComponent(BaseNoteModel data) : IComponent
    {
        private byte[] _logo =
            data.Signature ?? throw new NoSignatureException("No signature found");
        private string _provider = data.Provider ?? throw new Exception("No provider found");
        private string _providerType = data.ProviderType; //?? throw new Exception("No provider type found");

        public void Compose(IContainer container)
        {
            container
                .PaddingTop(15)
                .ShowEntire()
                .Table(table =>
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
                        .Row(1)
                        .Column(2)
                        .ColumnSpan(11)
                        .AlignRight()
                        .PaddingRight(50)
                        .Text(text =>
                        {
                            text.Span(_provider);
                            text.Span(", " + _providerType);
                            table
                                .Cell()
                                .Row(2)
                                .Column(2)
                                .ColumnSpan(11)
                                .AlignRight()
                                .PaddingTop(5)
                                .PaddingBottom(5)
                                .Height(50)
                                .Image(_logo)
                                .FitArea();
                            table
                                .Cell()
                                .Row(3)
                                .Column(2)
                                .ColumnSpan(11)
                                .AlignRight()
                                .Text(
                                    "The above-signed certifies that the services recommended above are necessary for patient care"
                                );
                        });
                });
        }
    }
}
