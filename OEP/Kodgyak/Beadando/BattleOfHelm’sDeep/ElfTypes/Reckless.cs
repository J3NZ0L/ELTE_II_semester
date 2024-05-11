using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleOfHelm_sDeep.OrcTypes;

namespace BattleOfHelm_sDeep.ElfTypes
{
    public class Reckless : Elf
    {
        public Reckless(string name)
        {
            this.name = name;
            this.treasure = 0;
            this.maxHealth = 100;
            this.health = maxHealth;
        }


        protected override uint ExpendableTreasure()
        {
            return 0;
        }

        protected override bool EligibleForHeal()
        {
            return this.GetHealth()<this.MinHP();
        }

        protected override uint MinHP()
        {
            return 30;
        }

        public override string GetType()
        {
            return "Reckless";
        }

        public override void AcceptDamage(Cunning cu)
        {
            cu.SufferDamage(20);
        }

        public override void AcceptDamage(Careful ca)
        {
            ca.SufferDamage(0);
        }
        public override void AcceptDamage(Ferocious fe)
        {
            fe.SufferDamage(5);
        }

        public override void DealDamage(Orc o)
        {
            o.AcceptDamage(this);
        }

        public override string PrintCreature()
        {
            return this.GetName() + " " + this.GetHealth() + " " + this.GetElixir() + " " + this.GetTreasure();
            //a nevük, fajtájuk, életerejük, elixírjük és kincsük kiírásával!
        }


    }
}
