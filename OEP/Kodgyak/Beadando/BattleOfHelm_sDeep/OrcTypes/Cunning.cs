using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleOfHelm_sDeep.ElfTypes; 

namespace BattleOfHelm_sDeep.OrcTypes
{
    public class Cunning : Orc
    {
        public Cunning(string name,uint treasure)
        {
            this.name = name;
            this.treasure = treasure;
            this.maxHealth = 90;
            this.health = (int)maxHealth;

        }

        public override string GetType()
        {
            return "Cunning";
        }

        public override void DealDamage(Elf elf)
        {
            elf.AcceptDamage(this);
        }

        public override void AcceptDamage(Reckless re)
        {
            SufferDamage(10);
        }

        public override void AcceptDamage(Dexterous de)
        {
            SufferDamage(0);
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
