using Assets.Enums;
using Assets.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Models
{
    public class SubShipInfo
    {
        public SubShipDesignInfo SubShipDesignData { get; set; }
        public GameObject SubShipGameObject { get; set; }
        public Alliances Alliance { get; set; }

        public decimal MaxHealth { get; set; }
        public decimal MaxArmor { get; set; }
        public decimal MaxAttack { get; set; }
        public decimal MaxAttackSpeed { get; set; }
        public decimal MaxFlySpeed { get; set; }
        public decimal CurrentHealth { get; set; }
    }
}
