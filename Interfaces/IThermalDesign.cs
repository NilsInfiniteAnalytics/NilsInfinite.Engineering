namespace NilsInfinite.Engineering.Interfaces;

public interface IThermalDesign
{
    /// <summary>
    /// <para>Calculate the log mean temperature difference for a heat exchanger.</para>
    ///
    /// Temperatures are in Kelvin.
    /// </summary>
    public double CalculateLogMeanTemperatureDifference(
        double hotInletTemperature,
        double coldInletTemperature,
        double hotOutletTemperature,
        double coldOutletTemperature);
}