using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Enums
{
    public enum SubShipTypes
    {
        Unassigned,
        Kamikaze, // a ship that runs into other ships and explodes
        Zephyr, // a fast ship that has fast medium range projectiles, 
        Pitfaller, // a ship that drops traps on the ground for other ships
        Beamer, // a ship that has beam weapons that stay active as long as there is an enemy in range
        Sniper, // a ship that specializes in staying in the back and fires a projectile from afar
        Marauder, // a ship that gets close to other ships and fires small projectiles, tanky hull
        Cannoner, // a ship that fires a powerful laser cannon
        Holder, // a ship that holds other ships in their beam
        Support, // a ship that buffs other ships or heals them
    }
}
