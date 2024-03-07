using Assets.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpellBL
{
    public static void TryToCastSpell(GameObject caster, StructureBase structureData, List<GameObject> subShips)
    {
        var spellToCast = structureData.Spells.OrderBy(x => x.SpellRange).FirstOrDefault(x => (DateTime.Now - x.LastCastTime).TotalSeconds > x.SpellCooldown);
        if (spellToCast == null)
        {
            return;
        }
        foreach (var subShip in subShips)
        {
            if (Vector3.Distance(caster.transform.position, subShip.transform.position) > spellToCast.SpellRange)
            {
                continue;
            }
            
        }
    }
}
