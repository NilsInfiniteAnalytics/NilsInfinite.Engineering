using NilsInfinite.Engineering.Models.MaterialPropertiesManager;

namespace NilsInfinite.Engineering.Interfaces;
public interface IMaterialPropertiesManager
{
    public Material GetMaterialProperties(string materialName);
}