using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class ShipInfo
    {
        public const char WallChar = 'W';
        public const char FloorChar = ' ';
        public const char ConveyorChar = 'C';
        public const char ConveyorStartChar = 'S';
        public const char ConveyorEndChar = 'E';

        public static List<string> ShipStructures = new List<string>()
        {
            "WWWWWWWWWW",
            "W S      W",
            "W C      W",
            "W C      W",
            "W C      W",
            "W CCCCCC W",
            "W      C W",
            "W      C W",
            "W      C W",
            "W      C W",
            "W CCCCCC W",
            "W C      W",
            "W C      W",
            "W CCCCCCCE",
            "W        W",
            "WWWWWWWWWW"
        };

        public static int Width { get; set; }
        public static int Height { get; set; }

    }
}
