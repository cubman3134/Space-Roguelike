using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Models
{
    public class MachineInfo : StructureBase
    {
        public MachineInfo(ObservableCollection<SpellInfo> spells, Sprite spriteData, decimal baseAttackSpeed) : base(spells, spriteData, baseAttackSpeed)
        {
            
        }
    }
}
