using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using PlayerRolesExpansion.Roles ;

namespace PlayerRolesExpansion
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "PlayerRolesExpansion";
        public override string Author => "dzarenafixers^moncef50g";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(9, 5, 0);

        public static Plugin Instance { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
             base.OnEnabled();
        }

        public override void OnDisabled()
        {
             Instance = null;
            base.OnDisabled();
        }
    }
}