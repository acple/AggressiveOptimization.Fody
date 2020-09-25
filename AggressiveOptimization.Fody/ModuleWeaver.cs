using System.Collections.Generic;
using System.Linq;
using Fody;

namespace AggressiveOptimization.Fody
{
    public class ModuleWeaver : BaseModuleWeaver
    {
        public override void Execute()
        {
            var methods = this.ModuleDefinition.GetTypes()
                .Where(type => !type.IsEnum)
                .SelectMany(type => type.Methods)
                .Where(method => method.HasBody);

            var optimization = new AggressiveOptimization();

            foreach (var method in methods)
                optimization.AddAggressiveOptimizationFlag(method);
        }

        public override IEnumerable<string> GetAssembliesForScanning()
            => Enumerable.Empty<string>();
    }
}
