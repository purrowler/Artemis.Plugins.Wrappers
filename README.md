# Artemis.Plugins Wrappers

Plugin for Artemis capable of capturing RGB lighting from 
* [Logitech Lightsync supported games](https://www.pcgamingwiki.com/wiki/RGB_lighting_middleware#Logitech_G_Lightsync)
* [Razer Chroma supported games](https://www.pcgamingwiki.com/wiki/RGB_lighting_middleware#Razer_Chroma_RGB)
* [LightFX/AlienFX supported games](https://www.pcgamingwiki.com/wiki/RGB_lighting_middleware#Alienware_AlienFX)

# Installation
* [Download](https://nightly.link/purrowler/Artemis.Plugins.Wrappers/workflows/build/master?preview) the plugin and import it into Artemis. 
* Let Artemis install the prerequisite.

# Usage
* Create a layer with the respective layer brush.
* Open any Lightsync supported game.
## LightFx
* Put the respective `x64\Artemis.Wrappers.LightFx.dll` or `x86\Artemis.Wrappers.LightFx.dll` into the games folder (Example for Guild Wars 2: `(...)\Guild Wars 2\bin64\Artemis.Wrappers.LightFx.dll`) for it to work.
* If connection to the wrapper is successfull, Debugger log should show `[INF] [Artemis.Plugins.Wrappers.LightFx.Services.LightFxWrapperListenerService] LightFx wrapper reader connected.`after starting the game.

# Troubleshooting
* Make sure Artemis writes the name of the game to the log.
* If it does not work, submit an issue

# Credits
* https://github.com/Archomeda/lightfx-extender
* https://github.com/antonpup/Aurora

