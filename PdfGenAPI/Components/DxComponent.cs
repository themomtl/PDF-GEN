using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GenPDF.Components
{
    public class DxComponent : IComponent
    {
        private List<string> Dxs;

        public DxComponent(List<string> dxs)
        {
            Dxs = dxs;
        }

        public void Compose(IContainer container)
        {
            container.Text(text =>
            {
                text.Span("DX: \n").Bold();
                foreach (var dx in Dxs)
                {
                    text.Span($"{dx} \n");
                }
            });
        }
    }
}
