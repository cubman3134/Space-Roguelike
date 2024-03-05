using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Implementations
{
    public class SpriteImplementations : MonoBehaviour
    {
        // SHIPS
        public static Sprite BeamerShipSprite = Resources.Load<Sprite>("Sprites/ShipSprites/BeamerSprite");
        public static Sprite CannonerShipSprite = Resources.Load<Sprite>("Sprites/ShipSprites/CannonerSprite");
        public static Sprite HolderShipSprite = Resources.Load<Sprite>("Sprites/ShipSprites/HolderSprite");
        public static Sprite KamikazeShipSprite = Resources.Load<Sprite>("Sprites/ShipSprites/KamikazeSprite");
        public static Sprite MarauderShipSprite = Resources.Load<Sprite>("Sprites/ShipSprites/MarauderSprite");
        public static Sprite PitfallerShipSprite = Resources.Load<Sprite>("Sprites/ShipSprites/PitfallerSprite");
        public static Sprite SniperShipSprite = Resources.Load<Sprite>("Sprites/ShipSprites/SniperSprite");
        public static Sprite SupportShipSprite = Resources.Load<Sprite>("Sprites/ShipSprites/SupportSprite");
        public static Sprite ZephyrShipSprite = Resources.Load<Sprite>("Sprites/ShipSprites/ZephyrSprite");

        // TILES
        public static Sprite ConveyorTileSprite = Resources.Load<Sprite>("Sprites/TileSprites/ConveyorSprite");
        public static Sprite GroundTileSprite = Resources.Load<Sprite>("Sprites/TileSprites/GroundSprite");
        public static Sprite WallTileSprite = Resources.Load<Sprite>("Sprites/TileSprites/WallSprite");
    }
}
