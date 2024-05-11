using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using BattleOfHelm_sDeep.OrcTypes;

namespace BattleOfHelm_sDeep
{
    public abstract class Elf : Creature
    {
        protected uint elixir;

        public uint GetElixir() { return elixir; }

        public void RegenerateAfterRound()
        {
            if (HasTreasure())
            {
                SpendTreasureForElixir(ExpendableTreasure());
            }
            if (EligibleForHeal())
            {
                HealSelf(MinHP());
            }
        }

        protected void SpendTreasureForElixir(uint amount)
        {
            AddToElixir(amount);
            SetTreasure(GetTreasure() - amount);
        }

        protected void UseElixir(uint amount)
        {
            if (GetElixir() < amount)
            {
                throw new ArgumentException("The given amount is more than the current amount of elixir");
            }
            elixir = elixir - amount;
            SetHealth(GetHealth() + amount);
        }

        protected void AddToElixir(uint amount)
        {
            elixir += amount;
        }

        protected bool HasElixir()
        {
            return elixir > 0;
        }

        private void HealSelf(uint toHP)
        {
            if (toHP > GetHealth() && HasElixir())
            {
                if (GetElixir() + GetHealth() > toHP)
                {
                    UseElixir(toHP - GetHealth());
                }
                else
                {
                    UseElixir(GetElixir());
                }
            }
        }

        public override void Attack(Creature creature)
        {
            Orc? orc = creature as Orc;
            DealDamage(orc);
            if (!orc.IsAlive())
            {
                GatherEnemyTreasure(orc);
            }
        }

        protected abstract uint ExpendableTreasure();

        protected abstract bool EligibleForHeal();

        protected abstract uint MinHP();

        public abstract void DealDamage(Orc orc);

        public abstract void AcceptDamage(Cunning cu);

        public abstract void AcceptDamage(Careful ca);

        public abstract void AcceptDamage(Ferocious fe);

        //DealDamage kellhet abstract metoduskent szuloben?
    }
}
