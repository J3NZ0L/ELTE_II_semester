using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleOfHelm_sDeep.ElfTypes; 

namespace BattleOfHelm_sDeep.OrcTypes
{
    public class Careful : Orc
    {
        public Careful(string name, uint treasure)
        {
            this.name = name;
            this.treasure = treasure;
            this.maxHealth = 80;
            this.health = (int)maxHealth;
        }

        public override string GetType()
        {
            return "Careful";
        }

        public override void DealDamage(Elf elf)
        {
            elf.AcceptDamage(this);
        }

        public override void AcceptDamage(Reckless re)
        {
            SufferDamage(15);
        }

        public override void AcceptDamage(Dexterous de)
        {
            SufferDamage(5);
        }

        public override void AcceptDamage(Wise we)
        {
            SufferDamage(0);
        }
        public override string PrintCreature()
        {
            return this.GetName() + " " + this.GetType() + " " + this.GetHealth() + " " + this.GetTreasure();
        }
    }
}
