using Assets.Enums;
using Assets.Implementations.SpellImplementations;
using Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Implementations
{
    public class SpellInfoImplementations : MonoBehaviour
    {
        // Attack Spells
        public static SpellInfo CannonBlastSpellInfoData = new SpellInfo(SpellNames.CannonBlast, 4.0M, 1.0M, 10, 10, 2.0M, SpellEffectTypes.Attack, SpellProjectileTypes.Beam, SpellTargetTypes.Enemy, SpellTypes.MultiTarget, SpellMovementTypes.GrowTowardTarget, new CannonBlastSpellData());

        // Debuff Spells
        // Buff Spells
        public static SpellInfo IncreaseMaxAttackSpellInfoData = new SpellInfo(SpellNames.IncreaseMaxAttack, 4.0M, 0, 10, 0, 0, SpellEffectTypes.Buff, SpellProjectileTypes.Bullet, SpellTargetTypes.Friendly, SpellTypes.SingleTarget, SpellMovementTypes.MoveTowardsTarget, new IncreaseMaxAttackSpellData());
        // Heal Spells
        // Trap Spells
    }
}
