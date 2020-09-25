using Mono.Cecil;

namespace AggressiveOptimization.Fody
{
    public class AggressiveOptimization
    {
        public void AddAggressiveOptimizationFlag(MethodDefinition method)
            => method.ImplAttributes |= (MethodImplAttributes)0x0200;
    }
}
