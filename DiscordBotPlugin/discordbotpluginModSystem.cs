using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;

namespace DiscordBotPlugin
{
    public class DiscordBotPluginModSystem : ModSystem
    {
        // Called on server and client
        public override void Start(ICoreAPI api)
        {
            Mod.Logger.Notification("Hello from template mod: " + Lang.Get("discordbotplugin:hello"));
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            api.Event.PlayerDeath += this.PlayerDeathDelegate;
            Mod.Logger.Notification("Hello from template mod server side");
        }

        public void PlayerDeathDelegate(IServerPlayer byPlayer, DamageSource damageSource)
        {
            Mod.Logger.Notification("Hello from template mod client side SOMEONE DIED");
        }
    }
}
