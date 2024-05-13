using BattleOfHelm_sDeep.ElfTypes;
using BattleOfHelm_sDeep.Groups;
using BattleOfHelm_sDeep.OrcTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace BattleOfHelm_sDeep
{
    public class Battle
    {
        public ElfGroup elfgroup;
        public OrcGroup orcgroup;

        public Battle(ElfGroup eg, OrcGroup og)
        {
            elfgroup = eg;
            orcgroup = og;
        }

        private void StillAlive() 
        {
            string output = "";
            foreach (Elf e in elfgroup.elves)
            {
                output += e.PrintCreature() + " ";
            }

            foreach (Orc o in orcgroup.orcs)
            {
                output += o.PrintCreature() + " ";
            }
            Console.WriteLine(output);
        }

        public bool IsOver()
        {
            return elfgroup.AllDead() || orcgroup.AllDead();
        }

        public void Fight()
        {
            int lengthOfRound;
            int currentDuel = 0;
            while (!this.IsOver())
            {
                lengthOfRound = Math.Min(elfgroup.elves.Count, orcgroup.orcs.Count);
                currentDuel = 0;
                while (currentDuel < lengthOfRound)
                {
                    elfgroup.elves[currentDuel].Attack(orcgroup.orcs[currentDuel]);
                    orcgroup.orcs[currentDuel].Attack(elfgroup.elves[currentDuel]);
                    currentDuel++;
                }
                elfgroup.LeaveDead();
                orcgroup.LeaveDead();
                elfgroup.HealElves();
                StillAlive();
            }

        }

        public static void ReadGroups(ElfGroup elfgroup, OrcGroup orcgroup, string filename)
        {

            using TextFileReader reader = new TextFileReader(filename);

            string[]? inputarray;
            string currentName;
            char currentCreatureType;
            string currentSubCreatureType;
            uint currentOrcTreasure;
            int i;

            while (reader.ReadLine(out string? line))
            {
                inputarray = line.Split(' ');
                i = 0;
                while (i < inputarray.Length)
                {
                    currentName = inputarray[i++];

                    currentCreatureType = inputarray[i++][0];
                    currentSubCreatureType = inputarray[i++];
                    if (currentCreatureType == 'o')
                    {
                        currentOrcTreasure = uint.Parse(inputarray[i++]);
                        switch (currentSubCreatureType)
                        {
                            case "fe":
                                orcgroup.orcs.Add(new Ferocious(currentName, currentOrcTreasure));
                                break;
                            case "cu":
                                orcgroup.orcs.Add(new Cunning(currentName, currentOrcTreasure));
                                break;
                            case "ca":
                                orcgroup.orcs.Add(new Careful(currentName, currentOrcTreasure));
                                break;
                        }
                    }
                    else
                    {
                        switch (currentSubCreatureType)
                        {
                            case "re":
                                elfgroup.elves.Add(new Reckless(currentName));
                                break;
                            case "wi":
                                elfgroup.elves.Add(new Wise(currentName));
                                break;
                            case "de":
                                elfgroup.elves.Add(new Dexterous(currentName));
                                break;
                        }
                    }

                }
            }
        }

    }
}
