using Assets.Enums;
using Assets.Implementations;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Assertions;

namespace Assets.Handlers
{
    public class GameHandler : MonoBehaviour
    {
        public void Start()
        {
            if (!Debugger.IsAttached)
            {
                return;
            }
            var implementedSpells = typeof(SpellInfoImplementations).GetProperties();
            var spellNames = Enum.GetValues(typeof(SpellNames)).Cast<SpellNames>().ToList();
            UnityEngine.Debug.Assert(implementedSpells.Count() == spellNames.Count()); // todo fix this
        }
    }
}
