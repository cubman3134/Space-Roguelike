using Assets.Enums;
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
        public static SpellInfo CannonBlastSpellInfoData = new SpellInfo(SpellNames.CannonBlast, 4.0f, 1.0f, 10, 10, SpellEffectTypes.Attack, SpellProjectileTypes.Beam, SpellTargetTypes.Enemy, SpellTypes.MultiTarget, SpellMovementTypes.GrowTowardTarget);

        // Debuff Spells
        // Buff Spells
        public static SpellInfo IncreaseMaxAttackSpellInfoData = new SpellInfo(SpellNames.IncreaseMaxAttack, 4.0f, 0, 10, 0, SpellEffectTypes.Buff, SpellProjectileTypes.Bullet, SpellTargetTypes.Friendly, SpellTypes.SingleTarget, SpellMovementTypes.MoveTowardsTarget);
        // Heal Spells
        // Trap Spells
    }
}
