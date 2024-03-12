using Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.BusinessLogic
{
    public class SubShipBL
    {
        public static void ApplyHealthModifierToSubShip(SpellInfo damagingSpell, SubShipInfo target)
        {
            if (damagingSpell == null) return;
            if (target == null) return;

            switch (damagingSpell.SpellEffectType)
            {
                case Enums.SpellEffectTypes.Heal:
                    ApplyHealthModificationAmountToSubShip(-damagingSpell.SpellModificationAmount, target);
                    break;
                case Enums.SpellEffectTypes.Attack:
                    ApplyHealthModificationAmountToSubShip(damagingSpell.SpellModificationAmount, target);
                    break;
                default:
                    break;
            }
        }

        public static void ApplyHealthModificationAmountToSubShip(decimal healthDelta, SubShipInfo target)
        {
            target.CurrentHealth -= healthDelta;
        }
    }
}
