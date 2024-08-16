using System.ComponentModel;

namespace NilsInfinite.Engineering.Models.ThermalDesign;
public enum HeatExchangerFlowTypes
{
    [Description("Parallel flow heat exchanger")]
    Parallel,
    [Description("Counterflow heat exchanger")]
    Counterflow,
    [Description("Crossflow heat exchanger. Both fluids unmixed.")]
    SinglePassCrossflowBothUnmixed,
    [Description("Crossflow heat exchanger. Both fluids mixed.")]
    SinglePassCrossflowBothMixed,
    [Description("Crossflow heat exchanger. CMax fluid mixed, CMin unmixed.")]
    SinglePassCrossflowCMaxMixedCMinUnmixed,
    [Description("Crossflow heat exchanger. CMax fluid unmixed, CMin mixed.")]
    SinglePassCrossflowCMaxUnmixedCMinMixed,
}