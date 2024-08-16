using Microsoft.Extensions.DependencyInjection;
using NilsInfinite.Engineering.Interfaces;
using NilsInfinite.Engineering.Modules;

namespace NilsInfinite.Engineering.Test;
[TestClass]
internal class Hooks
{
    internal static IServiceProvider? ServiceProvider { get; private set; }

    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext context)
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddTransient<IThermalDesign, ThermalDesign>();
        ServiceProvider = serviceCollection.BuildServiceProvider();
    }
}
