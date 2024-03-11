using Assets.Enums;
using Assets.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpellBL
{
    public static void TryToCastSpell(SubShipInfo caster, StructureBase structureData, List<SubShipInfo> subShips)
    {
        var spellToCast = structureData.Spells.OrderBy(x => x.SpellRange).FirstOrDefault(x => (DateTime.Now - x.LastCastTime).TotalSeconds > x.SpellCooldown);
        if (spellToCast == null)
        {
            return;
        }
        SubShipInfo spellTargetSubShip = null;
        if (spellToCast.SpellTargetType != SpellTargetTypes.NoTarget)
        {
            spellTargetSubShip = GetTargetForSpell(caster, spellToCast, subShips);
            if (spellTargetSubShip == null)
            {
                return;
            }
        }
        CastSpell(caster, spellTargetSubShip, spellToCast);
    }

    public static SubShipInfo GetTargetForSpell(SubShipInfo caster, SpellInfo spell, List<SubShipInfo> subShips)
    {
        if (spell.SpellTargetType == SpellTargetTypes.Unassigned || spell.SpellTargetType == SpellTargetTypes.NoTarget)
        {
            return null;
        }
        foreach (var subShip in subShips)
        {
            if (Vector3.Distance(caster.SubShipGameObject.transform.position, subShip.SubShipGameObject.transform.position) > spell.SpellRange)
            {
                continue;
            }
            if (spell.SpellTargetType == SpellTargetTypes.Enemy && caster.Alliance == subShip.Alliance)
            {
                continue;
            }
            if (spell.SpellTargetType == SpellTargetTypes.Friendly && caster.Alliance != subShip.Alliance)
            {
                continue;
            }
            return subShip;
        }
        return null;
    }

    public static void CastSpell(SubShipInfo caster, SubShipInfo target, SpellInfo spell)
    {
        switch (spell.SpellName)
        {
            case SpellNames.CannonBlast:
                break;
            default: 
                break;
        }
    }
}
