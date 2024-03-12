using Assets.BusinessLogic;
using Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Implementations
{
    public abstract class SpellBase
    {
        public virtual void CastSpell(SubShipInfo caster, SubShipInfo target, SpellInfo spellInformation)
        {

        }

        public virtual void OnSpellCast(SubShipInfo caster, SubShipInfo target, SpellInfo spellInformation)
        {

        }

        public virtual void OnSpellExpire(SubShipInfo caster, SubShipInfo target, SpellInfo spellInformation)
        {

        }

        public virtual void OnSubShipCollide(SubShipInfo subShipCollidedWith, SubShipInfo caster, SubShipInfo target, SpellInfo spellInformation)
        {
            if (subShipCollidedWith != target)
            {
                return;
            }
            SubShipBL.ApplyHealthModifierToSubShip(spellInformation, subShipCollidedWith);
        }
    }
}
