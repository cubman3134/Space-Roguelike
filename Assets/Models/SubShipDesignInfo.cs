using Assets.Enums;
using Assets.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class SubShipDesignInfo : StructureBase
    {
        public SubShipDesignInfo(Sprite spriteData, SubShipTypes subShipType, decimal baseHealth, decimal baseArmor, decimal baseAttack, decimal baseAttackSpeed, decimal baseFlySpeed) : base(new ObservableCollection<SpellInfo>(), spriteData, baseAttackSpeed)
        {
            SubShipType = subShipType;
            BaseHealth = baseHealth;
            BaseArmor = baseArmor;
            BaseAttack = baseAttack;
            BaseFlySpeed = baseFlySpeed;
        }

        
        public SubShipTypes SubShipType { get; set; }
        public decimal BaseHealth { get; set; }
        public decimal BaseArmor { get; set;}
        public decimal BaseAttack { get; set; }
        public decimal BaseFlySpeed { get; set; }
    }
}
