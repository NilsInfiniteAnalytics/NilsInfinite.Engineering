using NilsInfinite.Engineering.Interfaces;

namespace NilsInfinite.Engineering.Modules;
public class ThermalDesign : IThermalDesign
{
    /// <summary>
    /// <inheritdoc cref="IThermalDesign"/>
    /// </summary>
    public double CalculateLogMeanTemperatureDifference(
        double hotInletTemperature,
        double coldInletTemperature,
        double hotOutletTemperature,
        double coldOutletTemperature)
    {
        var temperatureDeltaOutlet = hotOutletTemperature - coldOutletTemperature;
        var temperatureDeltaInlet = hotInletTemperature - coldInletTemperature;
        if (temperatureDeltaInlet == 0 || temperatureDeltaOutlet == 0)
        {
            throw new ArgumentException("Inlet and outlet temperature differences must be non-zero.");
        }
        return (temperatureDeltaOutlet - temperatureDeltaInlet) / Math.Log(temperatureDeltaOutlet / temperatureDeltaInlet);
    }

}
