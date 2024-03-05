using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Handlers
{
    public class CombatRoundHandler : MonoBehaviour
    {
        public int CurrentRound = 0;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            /*int numberOfEnemyRoundsSetUp = EnemyData?.SubShipsForEachRound?.Count ?? 0;
            if (numberOfEnemyRoundsSetUp <= CurrentRound)
            {
                // todo, request new round
                return;
            }
            if (EnemyData.SubShipsForEachRound[CurrentRound].Count == 0)
            {
                CurrentRound++;
            }*/
        }
    }
}
