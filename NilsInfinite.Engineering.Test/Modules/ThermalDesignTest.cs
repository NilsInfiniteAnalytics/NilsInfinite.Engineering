using Microsoft.Extensions.DependencyInjection;
using NilsInfinite.Engineering.Interfaces;

namespace NilsInfinite.Engineering.Test.Modules;
[TestClass]
public class ThermalDesignTest
{
    private IThermalDesign? _thermalDesign;

    [TestInitialize]
    public void Initialize()
    {
        if (Hooks.ServiceProvider is null)
            throw new InvalidOperationException("Service provider not initialized.");
        _thermalDesign = Hooks.ServiceProvider.GetService<IThermalDesign>()
                         ?? throw new InvalidOperationException("Service not found.");
    }

    [TestMethod]
    public void CalculateLogMeanTemperatureDifference_ReturnsCorrectValue()
    {
        // Arrange
        const double hotInletTemperature = 380;
        const double coldInletTemperature = 300;
        const double hotOutletTemperature = 420;
        const double coldOutletTemperature = 344.7;
        const double expected = 77.6;

        // Act
        var actual = _thermalDesign!.CalculateLogMeanTemperatureDifference(
            hotInletTemperature,
            coldInletTemperature,
            hotOutletTemperature,
            coldOutletTemperature);

        // Assert
        var error = Math.Abs(expected - actual) / expected;
        Assert.IsTrue(error < 10-3);
    }
}
