using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHelm_sDeep.Groups
{
    public class ElfGroup : Group
    {
        public UniqueList<Elf> elves;

        public ElfGroup(UniqueList<Elf> elves)
        {
            this.elves = elves;
        }

        public override bool AllDead()
        {
            return elves.Count==0;
        }

        public override void LeaveDead()
        {
            UniqueList<Elf> elvesToBury = new UniqueList<Elf>();
            foreach (Elf elf in elves)
            {
                if (!elf.IsAlive())
                {
                    elvesToBury.Add(elf);
                }
            }

            foreach (Elf elf in elvesToBury)
            {
                elves.Remove(elf);
            }
        }

        public void HealElves()
        {
            foreach (Elf elf in elves)
            {
                elf.RegenerateAfterRound();
            }
        }
    }
}
