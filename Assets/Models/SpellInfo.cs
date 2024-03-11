using Assets.Enums;
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
        public float SpellCooldown { get; set; }
        public float SpellBaseDamage { get; set; }
        public float SpellRange { get; set; }
        public float SpellDuration { get; set; }
        public SpellEffectTypes SpellEffectType { get; set; }
        public SpellProjectileTypes SpellProjectileType { get; set; }
        public SpellTargetTypes SpellTargetType { get; set; }
        public SpellTypes SpellType { get; set; }
        public SpellMovementTypes SpellMovementType { get; set;}
        public SpellInfo(SpellNames spellName, float spellCooldown, float spellBaseDamage, float spellRange, float spellDuration, SpellEffectTypes spellEffectType, SpellProjectileTypes spellProjectileType, SpellTargetTypes spellTargetType, SpellTypes spellType, SpellMovementTypes spellMovementType)
        {
            SpellName = spellName;
            SpellCooldown = spellCooldown;
            SpellBaseDamage = spellBaseDamage;
            SpellRange = spellRange;
            SpellDuration = spellDuration;
            SpellEffectType = spellEffectType;
            SpellProjectileType = spellProjectileType;
            SpellTargetType = spellTargetType;
            SpellType = spellType;
            SpellMovementType = spellMovementType;
        }
    }
}
