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
        public void OnSpellCast(SubShipInfo caster, SubShipInfo target, SpellInfo spellInformation)
        {

        }

        public void OnSpellExpire(SubShipInfo caster, SubShipInfo target, SpellInfo spellInformation)
        {

        }

        public abstract void OnSubShipCollide(SubShipInfo subShipCollidedWith, SubShipInfo caster, SubShipInfo target, SpellInfo spellInformation);
    }
}
