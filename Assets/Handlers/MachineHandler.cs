using Assets.Models;
using System.Collections;
using UnityEngine;

namespace Assets.Handlers
{
    public class MachineHandler : MonoBehaviour
    {
        public GameObject SubShip;
        public SubShipInfo SubShipData;

        public void Start()
        {
            SubShip = gameObject;
            SubShipData = SubShip.GetComponent<SubShipInfo>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}