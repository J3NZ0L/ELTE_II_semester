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

                
                ElfGroup elfGroup = new ElfGroup(new UniqueList<Elf>());
                OrcGroup orcGroup = new OrcGroup(new UniqueList<Orc>());


             
                Battle.ReadGroups(elfGroup, orcGroup, "test1.txt");

                Battle battle_of_helm_s_deep = new Battle(elfGroup, orcGroup); //fogad ket ket beolvasott creature groupot
                battle_of_helm_s_deep.Fight();

            }
            catch (FileNotFoundException e)
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
