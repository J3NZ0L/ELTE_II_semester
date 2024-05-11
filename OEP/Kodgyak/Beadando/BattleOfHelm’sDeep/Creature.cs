using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfHelm_sDeep
{
    public abstract class Creature
    {
        protected string? name;
        protected uint health;
        protected uint treasure;
        protected uint maxHealth;
        protected uint damage;
        protected uint shield;

        public string GetName()
        {
            return name;
        }

        public uint GetHealth()
        {
            return health;
        }

        public void SetHealth(uint value)
        {
            health = value;
        }

        public uint GetTreasure()
        {
            return treasure;
        }

        public void SetTreasure(uint value)
        {
            treasure = value;
        }

        public uint GetMaxHealh()
        {
            return maxHealth;
        }

        public uint GetDamage()
        {
            return damage;
        }

        public uint GetShield()
        {
            return shield;
        }

        public bool IsAlive()
        {
            return GetHealth() > 0;
        }

        public bool HasTreasure()
        {
            return GetTreasure() > 0;
        }

        public void SufferDamage(uint damage)
        {
            this.SetHealth(Math.Max(GetHealth() - damage, 0));
        }

        public void GatherEnemyTreasure(Creature creature)
        {
            if (creature.HasTreasure())
            {
                this.SetTreasure(this.GetTreasure() + creature.GetTreasure());
                creature.SetTreasure(0);
            }
        }

        public abstract string PrintCreature();

        public abstract string GetType();

        public abstract void Attack(Creature creature);
    }
}







