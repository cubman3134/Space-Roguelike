using Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Handlers
{
    public class SpellHandler : MonoBehaviour
    {
        public SubShipInfo Caster { get; set; }
        public SubShipInfo Target { get; set; }
        public SpellInfo SpellInformation { get; set; }
        public decimal SpellDurationLeft { get; set; }
        public bool CheckDuration { get; set; }

        private void OnCollisionEnter(Collision collision)
        {
            var subShipInfo = collision.gameObject.GetComponent<SubShipInfo>();
            if (subShipInfo == null)
            {
                return;
            }
            SpellInformation.SpellData.OnSubShipCollide(subShipInfo, Caster, Target, SpellInformation);
        }

        public void DespawnObject()
        {
            Destroy(gameObject);
            SpellInformation.SpellData.OnSpellExpire(Caster, Target, SpellInformation);
        }

        private bool IsObjectDestroyedFromDuration()
        {
            if (!CheckDuration)
            {
                return false;
            }
            SpellDurationLeft -= (decimal)Time.deltaTime;
            if (SpellDurationLeft < 0)
            {
                DespawnObject();
                return true;
            }
            return false;
        }

        void Start()
        {
            SpellDurationLeft = SpellInformation.SpellDuration;
            if (SpellDurationLeft > 0)
            {
                CheckDuration = true;
            }
            SpellInformation.SpellData.OnSpellCast(Caster, Target, SpellInformation);
        }

        // Update is called once per frame
        void Update()
        {
            if (IsObjectDestroyedFromDuration())
            {
                return;
            }
        }
    }
}
