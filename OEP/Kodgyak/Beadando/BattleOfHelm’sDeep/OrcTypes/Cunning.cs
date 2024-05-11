﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BattleOfHelm_sDeep.ElfTypes; 

namespace BattleOfHelm_sDeep.OrcTypes
{
    public class Cunning : Orc
    {
        public Cunning(string name)
        {
            this.name = name;
            this.treasure = 0;
            this.maxHealth = 90;
            this.health = maxHealth;
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
            return this.GetName() + " " + this.GetHealth() + " " + this.GetTreasure();
        }
    }
}
