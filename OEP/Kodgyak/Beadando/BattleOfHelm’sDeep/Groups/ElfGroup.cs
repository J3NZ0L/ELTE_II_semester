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
            return elves == null;
        }

        public override void LeaveDead()
        {
            foreach (Elf elf in elves)
            {
                if (!elf.IsAlive())
                {
                    elves.Remove(elf);
                }
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
