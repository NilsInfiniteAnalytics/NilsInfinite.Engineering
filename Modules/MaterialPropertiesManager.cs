using Microsoft.ApplicationInsights.Channel;
using Microsoft.Extensions.Logging;
using NilsInfinite.Engineering.Models.MaterialPropertiesManager;

namespace NilsInfinite.Engineering.Modules;
public class MaterialPropertiesManager(ILogger logger, ITelemetry telemetry)
{
    private readonly ILogger _logger = logger;
    private readonly ITelemetry _telemetry = telemetry;

    public Material GetMaterialProperties(string materialName)
    {
        return new Material
        {
            Name = materialName,
            ThermalConductivity = 0.5,
            SpecificHeatCapacity = 1000,
            Density = 1000,
            Viscosity = 0.001,
            ThermalExpansionCoefficient = 0.00001
        };
    }
}
