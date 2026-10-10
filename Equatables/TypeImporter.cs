using Microsoft.CodeAnalysis;
using Ourogen.Templates;

namespace Loathesoft.Equatables
{
    [Generator]
    internal class TypeImporter : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context) =>
            context.RegisterPostInitializationOutput(Import);

        private static void Import(IncrementalGeneratorPostInitializationContext context)
        {
            context.AddEmbeddedAttributeDefinition();
            context.AddSource("Loathesoft.Equatables.EquatableArray", EquatableArrayRenderer.Render());
            context.AddSource("Loathesoft.Equatables.EnumerableExtensions", EnumerableExtensionsRenderer.Render());
            context.AddSource("Loathesoft.Equatables.HashCode", HashCodeRenderer.Render());
        }
    }
}