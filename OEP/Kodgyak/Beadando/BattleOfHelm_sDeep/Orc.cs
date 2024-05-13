using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleOfHelm_sDeep.ElfTypes;

namespace BattleOfHelm_sDeep
{
    public abstract class Orc : Creature
    {
        public override void Attack(Creature creature)
        {
            Elf? elf = creature as Elf;
            if (elf != null) { 
            DealDamage(elf);
                if (!elf.IsAlive())
                {
                    GatherEnemyTreasure(elf);
                }
            }
        }

        public abstract void DealDamage(Elf elf);

        public abstract void AcceptDamage(Reckless re);

        public abstract void AcceptDamage(Dexterous de);

        public abstract void AcceptDamage(Wise we);
    }
}
