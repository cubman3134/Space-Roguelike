using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Handlers
{
    public class SubShipHandler : MonoBehaviour
    {
        public GameObject SubShip;
        public SubShipInfo SubShipData;

        public void Start()
        {
            SubShip = gameObject;
            SubShipData = SubShip.GetComponent<SubShipInfo>();
        }

        public void Update()
        {
            if (SubShipData.CurrentHealth <= 0)
            {
                // todo send message of death if hero
                Destroy(SubShip);
                return;
            }

        }
    }
}
