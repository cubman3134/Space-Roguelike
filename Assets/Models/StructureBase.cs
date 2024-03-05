using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Models
{
    public abstract class StructureBase
    {
        public StructureBase(ObservableCollection<SpellInfo> spells, Sprite spriteData, decimal baseAttackSpeed)
        {
            Spells = spells;
            SpriteData = spriteData;
            BaseAttackSpeed = baseAttackSpeed;
        }

        public ObservableCollection<SpellInfo> Spells { get; set; }
        public Sprite SpriteData { get; set; }
        public decimal BaseAttackSpeed { get; set; }
    }
}
