using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleOfHelm_sDeep.OrcTypes;

namespace BattleOfHelm_sDeep.ElfTypes
{
    public class Wise : Elf
    {
        public Wise(string name)
        {
            this.name = name;
            this.treasure = 0;
            this.maxHealth = 60;
            this.health = (int)maxHealth;
        }

        protected override uint ExpendableTreasure()
        {
            return this.GetTreasure();
        }

        protected override bool EligibleForHeal()
        {
            return true;
        }

        protected override uint MinHP()
        {
            return this.maxHealth;
        }

        public new string GetType()
        {
            return "Wise";
        }

        public override void AcceptDamage(Cunning cu)
        {
            SufferDamage(5);
        }

        public override void AcceptDamage(Careful ca)
        {
            SufferDamage(0);
        }
        public override void AcceptDamage(Ferocious fe)
        {
            SufferDamage(20);
        }

        public override void DealDamage(Orc? o)
        {
            o?.AcceptDamage(this);
        }

        public override string PrintCreature()
        {
            return this.GetName() + " " + this.GetType() + " " + this.GetHealth() + " " + this.GetElixir() + " " + this.GetTreasure();
            //a nevük, fajtájuk, életerejük, elixírjük és kincsük kiírásával!
        }


    }
}
