using Artemis.Core;
using Artemis.Core.LayerBrushes;
using Artemis.Plugins.Wrappers.LightFx.Services;
using RGB.NET.Core;
using SkiaSharp;
using System.Collections.Generic;
using System;

namespace Artemis.Plugins.Wrappers.LightFx.LayerBrushes
{
    public class LightFxWrapperLayerBrush : LayerBrush<LightFxWrapperLayerPropertyGroup>
    {
        private readonly LightFxWrapperListenerService _wrapperService;
        private readonly Dictionary<LedId, SKColor> _colors = new();

        public LightFxWrapperLayerBrush(LightFxWrapperListenerService wrapperService)
        {
            _wrapperService = wrapperService;
        }

        public override void EnableLayerBrush()
        {
            _wrapperService.Updated += OnWrapperServiceUpdated;
            _wrapperService.ClientDisconnected += OnWrapperServiceClientDisconnected;
        }

        public override void DisableLayerBrush()
        {
            _wrapperService.Updated -= OnWrapperServiceUpdated;
            _wrapperService.ClientDisconnected -= OnWrapperServiceClientDisconnected;
        }

        public override void Update(double deltaTime) { }

        public override void Render(SKCanvas canvas, SKRect bounds, SKPaint paint)
        {
            // For wrapper plugins that capture colors from games, we typically use a solid fill
            // with the main color from the wrapper service
            if (_wrapperService.Color != SKColor.Empty)
            {
                paint.Color = _wrapperService.Color;
                canvas.DrawRect(bounds, paint);
            }
            
            // If we have specific LED colors, we could render them as a gradient or pattern
            // but for simplicity, we'll use the main color for now
        }

        private void OnWrapperServiceUpdated(object sender, EventArgs e)
        {
            foreach (KeyValuePair<LedId, SKColor> kvp in _wrapperService.Colors)
            {
                _colors[kvp.Key] = kvp.Value;
            }
        }

        private void OnWrapperServiceClientDisconnected(object sender, EventArgs e)
        {
            _colors.Clear();
        }
    }
}
