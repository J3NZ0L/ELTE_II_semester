﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleOfHelm_sDeep.ElfTypes; 

namespace BattleOfHelm_sDeep.OrcTypes
{
    public class Ferocious : Orc
    {
        public Ferocious(string name)
        {
            this.name = name;
            this.maxHealth = 100;
            this.health = maxHealth;
        }

        public override string GetType()
        {
            return "Ferocious";
        }

        public override void DealDamage(Elf elf)
        {
            elf.AcceptDamage(this);
        }

        public override void AcceptDamage(Reckless re)
        {
            SufferDamage(25);
        }

        public override void AcceptDamage(Dexterous de)
        {
            SufferDamage(15);
        }

        public override void AcceptDamage(Wise we)
        {
            SufferDamage(5);
        }

        public override string PrintCreature()
        {
            return this.GetName() + " " + this.GetHealth() + " " + this.GetTreasure();
        }
    }
}
