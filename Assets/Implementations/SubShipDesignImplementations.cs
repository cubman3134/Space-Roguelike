using Assets.Enums;
using Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Implementations
{
    public class SubShipDesignImplementations
    {
        public static SubShipDesignInfo BeamerDesignData = new SubShipDesignInfo(SpriteImplementations.BeamerShipSprite, SubShipTypes.Beamer, 100, 100, 100, 100, 100);
        public static SubShipDesignInfo CannonerDesignData = new SubShipDesignInfo(SpriteImplementations.CannonerShipSprite, SubShipTypes.Cannoner, 100, 100, 100, 100, 100);
        public static SubShipDesignInfo HolderDesignData = new SubShipDesignInfo(SpriteImplementations.HolderShipSprite, SubShipTypes.Holder, 100, 100, 100, 100, 100);
        public static SubShipDesignInfo KamikazeDesignData = new SubShipDesignInfo(SpriteImplementations.KamikazeShipSprite, SubShipTypes.Kamikaze, 100, 100, 100, 100, 100);
        public static SubShipDesignInfo MarauderDesignData = new SubShipDesignInfo(SpriteImplementations.MarauderShipSprite, SubShipTypes.Marauder, 100, 100, 100, 100, 100);
        public static SubShipDesignInfo PitfallerDesignData = new SubShipDesignInfo(SpriteImplementations.PitfallerShipSprite, SubShipTypes.Pitfaller, 100, 100, 100, 100, 100);
        public static SubShipDesignInfo SniperDesignData = new SubShipDesignInfo(SpriteImplementations.SniperShipSprite, SubShipTypes.Sniper, 100, 100, 100, 100, 100);
        public static SubShipDesignInfo SupportDesignData = new SubShipDesignInfo(SpriteImplementations.SupportShipSprite, SubShipTypes.Support, 100, 100, 100, 100, 100);
        public static SubShipDesignInfo ZephyrDesignData = new SubShipDesignInfo(SpriteImplementations.ZephyrShipSprite, SubShipTypes.Zephyr, 100, 100, 100, 100, 100);
    }
}
