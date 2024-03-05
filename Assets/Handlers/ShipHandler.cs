using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Handlers
{
    public class ShipHandler : MonoBehaviour
    {
        public ShipHandler(List<ShipInfo> subShips)
        {
            SubShips = subShips;
        }

        public List<ShipInfo> SubShips = new List<ShipInfo>();
        public List<ShipInfo> SubShipsLeftToSpawn = new List<ShipInfo>();

        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
