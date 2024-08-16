namespace NilsInfinite.Engineering.Models.MaterialPropertiesManager;
public record Material
{
    public string? Name { get; init; }
    public double ThermalConductivity { get; init; }
    public double SpecificHeatCapacity { get; init; }
    public double Density { get; init; }
    public double Viscosity { get; init; }
    public double ThermalExpansionCoefficient { get; init; }
};