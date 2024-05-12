using BattleOfHelm_sDeep.ElfTypes;
using BattleOfHelm_sDeep.Groups;
using BattleOfHelm_sDeep.OrcTypes;
using System.Reflection.PortableExecutable;
using TextFile;

namespace BattleOfHelm_sDeep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beolvasas
            try {
                if (!File.Exists("test1.txt"))
                    Console.WriteLine("nem talalja file.exists sem");               
                using TextFileReader reader = new TextFileReader("test1.txt");
                //test line: Falánk o v 7 Sudár e u Köpcös o v 4 Nyúlánk e v 
                
                string[]? inputarray;
                string currentName;
                char currentCreatureType;
                string currentSubCreatureType;
                uint currentOrcTreasure;
                int i;

                
                ElfGroup elfGroup = new ElfGroup(new UniqueList<Elf>());
                OrcGroup orcGroup = new OrcGroup(new UniqueList<Orc>());
               

                while (reader.ReadLine(out string? line))
                {
                    inputarray = line.Split(' ');
                    i = 0;
                    while (i<inputarray.Length)
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
                                    orcGroup.orcs.Add(new Ferocious(currentName, currentOrcTreasure));
                                    break;
                                case "cu":
                                    orcGroup.orcs.Add(new Cunning(currentName, currentOrcTreasure));
                                    break;
                                case "ca":
                                    orcGroup.orcs.Add(new Careful(currentName, currentOrcTreasure));
                                    break;
                            }
                        } else
                        {
                            switch (currentSubCreatureType)
                            {
                                case "re":
                                    elfGroup.elves.Add(new Reckless(currentName));
                                    break;
                                case "wi":
                                    elfGroup.elves.Add(new Wise(currentName));
                                    break;
                                case "de":
                                    elfGroup.elves.Add(new Dexterous(currentName));
                                    break;
                            }
                        }

                    }
                }

                Battle battle_of_helm_s_deep = new Battle(elfGroup, orcGroup); //fogad ket ket beolvasott creature groupot
                battle_of_helm_s_deep.StillAlive();
            }catch (FileNotFoundException e)
            {
                Console.WriteLine("Nem talalhato a fajl");
            }
            catch(Exception e)
            {
                Console.WriteLine("Ismeretlen hiba tortent: "+e.Message);
            }
        }
    }
}
