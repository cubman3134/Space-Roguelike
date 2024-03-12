using Assets.Enums;
using Assets.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Models
{
    public class SpellInfo
    {
        public SpellNames SpellName { get; set; }
        public DateTime LastCastTime { get; set; }
        public decimal SpellCooldown { get; set; }
        public decimal SpellModificationAmount { get; set; }
        public decimal SpellRange { get; set; }
        public decimal SpellDuration { get; set; }
        public decimal SpellEffectRefreshRate { get; set; }
        public SpellEffectTypes SpellEffectType { get; set; }
        public SpellProjectileTypes SpellProjectileType { get; set; }
        public SpellTargetTypes SpellTargetType { get; set; }
        public SpellTypes SpellType { get; set; }
        public SpellMovementTypes SpellMovementType { get; set; }
        public SpellBase SpellData { get; set; }
        public SpellInfo(SpellNames spellName, decimal spellCooldown, decimal spellModificationAmount, decimal spellRange, decimal spellDuration, decimal spellEffectRefreshRate, SpellEffectTypes spellEffectType, SpellProjectileTypes spellProjectileType, SpellTargetTypes spellTargetType, SpellTypes spellType, SpellMovementTypes spellMovementType, SpellBase spellData)
        {
            SpellName = spellName;
            SpellCooldown = spellCooldown;
            SpellModificationAmount = spellModificationAmount;
            SpellRange = spellRange;
            SpellDuration = spellDuration;
            SpellEffectRefreshRate = spellEffectRefreshRate;
            SpellEffectType = spellEffectType;
            SpellProjectileType = spellProjectileType;
            SpellTargetType = spellTargetType;
            SpellType = spellType;
            SpellMovementType = spellMovementType;
            SpellData = spellData;
        }
    }
}
