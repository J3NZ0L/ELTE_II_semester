using BattleOfHelm_sDeep.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHelm_sDeep
{
    public class Battle
    {
        public ElfGroup elfgroup;
        public OrcGroup orcgroup;

        public Battle(ElfGroup eg, OrcGroup og)
        {
            elfgroup = eg;
            orcgroup = og;
        }

        public void StillAlive() //TODO!! atirni privatera
        {
            foreach (Elf e in elfgroup.elves)
            {
                e.PrintCreature();
            }

            foreach (Orc o in orcgroup.orcs)
            {
                o.PrintCreature();
            }
        }

        public bool IsOver()
        {
            return elfgroup.AllDead() || orcgroup.AllDead();
        }

        public void Fight()
        {
            int lengthOfRound;
            int currentDuel = 0;
            while (!this.IsOver())
            {
                lengthOfRound = Math.Min(elfgroup.elves.Count,orcgroup.orcs.Count);
                currentDuel = 0;
                while (currentDuel < lengthOfRound)
                {
                    elfgroup.elves[currentDuel].Attack(orcgroup.orcs[currentDuel]);
                    orcgroup.orcs[currentDuel].Attack(elfgroup.elves[currentDuel]);
                    currentDuel++;
                }
                elfgroup.LeaveDead();
                orcgroup.LeaveDead();
                elfgroup.HealElves();
                StillAlive();
            }

        }

    }
}
