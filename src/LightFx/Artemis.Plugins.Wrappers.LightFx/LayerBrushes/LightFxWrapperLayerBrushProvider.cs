using Artemis.Core;
using Artemis.Core.LayerBrushes;

namespace Artemis.Plugins.Wrappers.LightFx.LayerBrushes
{
    [PluginFeature(AlwaysEnabled = true)]
    public class LightFxWrapperLayerBrushProvider : LayerBrushProvider
    {
        public override void Enable()
        {
            RegisterLayerBrushDescriptor<LightFxWrapperLayerBrush>("LightFX Wrapper Layer", "Allows you to have LightFX/AlienFX lighting on all devices.", "Robber");
        }

        public override void Disable()
        {
        }
    }
}
