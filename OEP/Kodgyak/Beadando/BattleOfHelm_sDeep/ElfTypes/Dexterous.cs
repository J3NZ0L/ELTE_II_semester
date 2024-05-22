using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleOfHelm_sDeep.OrcTypes;

namespace BattleOfHelm_sDeep.ElfTypes
{
    public class Dexterous : Elf
    {
        public Dexterous(string name)
        {
            this.name = name;
            this.treasure = 0;
            this.maxHealth = 80;
            this.health = 80;
        }

        protected override uint ExpendableTreasure()
        {
            return this.GetTreasure() / 2;
        }

        protected override bool EligibleForHeal()
        {
            return this.GetHealth()<this.MinHP();
        }

        protected override uint MinHP()
        {
            return 50;
        }

        public override string GetType()
        {
            return "Dexterous";
        }

        public override void AcceptDamage(Cunning cu)
        {
            SufferDamage(0);
        }

        public override void AcceptDamage(Careful ca)
        {
            SufferDamage(0);
        }
        public override void AcceptDamage(Ferocious fe)
        {
            SufferDamage(10);
        }

        public override void DealDamage(Orc? o)
        {
            o?.AcceptDamage(this);
        }

        public override string PrintCreature()
        {
            return this.GetName() + " "+ this.GetType()+" " + this.GetHealth() + " " + this.GetElixir() + " " + this.GetTreasure();
            //a nevük, fajtájuk, életerejük, elixírjük és kincsük kiírásával!
        }


    }
}
