using BattleOfHelm_sDeep;
using BattleOfHelm_sDeep.ElfTypes;
using BattleOfHelm_sDeep.OrcTypes;
using BattleOfHelm_sDeep.Groups;

namespace BattleTest

{
    [TestClass]
    public class UnitTest1
    {
        //Felsorolas hossza szerint
        [TestMethod]
        public void ListOfNothing()  //nulla leny
        {
            ElfGroup elfGroup = new ElfGroup(new UniqueList<Elf>());
            OrcGroup orcGroup = new OrcGroup(new UniqueList<Orc>());
            Battle battle_of_helm_s_deep = new Battle(elfGroup, orcGroup);
            Assert.IsTrue(battle_of_helm_s_deep.IsOver());
        }

        [TestMethod]
        public void OneCreatureBattle() //egy leny
        {
            UniqueList<Elf> oneelf = new UniqueList<Elf>();
            oneelf.Add(new Wise("Sanyi"));
            ElfGroup elfGroup = new ElfGroup(oneelf);
            OrcGroup orcGroup = new OrcGroup(new UniqueList<Orc>());
            Battle battle_of_helm_s_deep = new Battle(elfGroup, orcGroup);
            battle_of_helm_s_deep.Fight();
            Assert.IsTrue(orcGroup.AllDead());
            Assert.IsFalse(elfGroup.AllDead());
        }
        public void MoreCreatureBattle() //tobb leny
        {
            UniqueList<Elf> twoelf = new UniqueList<Elf>();
            twoelf.Add(new Wise("Sanyi"));
            twoelf.Add(new Wise("Kenyeres"));
            UniqueList<Orc> twoorc = new UniqueList<Orc>();
            twoorc.Add(new Cunning("Sandor", 12));
            twoorc.Add(new Ferocious("Wilhelm the 3rd", 300));
            ElfGroup elfGroup = new ElfGroup(twoelf);
            OrcGroup orcGroup = new OrcGroup(twoorc);
            Battle battle_of_helm_s_deep = new Battle(elfGroup, orcGroup);
            battle_of_helm_s_deep.Fight();
            Assert.AreEqual<int>((int)orcGroup.orcs[0].GetMaxHealh(), orcGroup.orcs[0].GetHealth());
            Assert.AreEqual<int>(85, orcGroup.orcs[1].GetHealth());
            Assert.IsTrue(elfGroup.AllDead());
        }

        [TestMethod]
        public void DuelBattle() //elso leny tuleli
        {
            UniqueList<Elf> oneelf = new UniqueList<Elf>();
            oneelf.Add(new Wise("Sanyi"));
            UniqueList<Orc> oneorc = new UniqueList<Orc>();
            oneorc.Add(new Cunning("Sandor", 12));
            ElfGroup elfGroup = new ElfGroup(oneelf);
            OrcGroup orcGroup = new OrcGroup(oneorc);
            Battle battle_of_helm_s_deep = new Battle(elfGroup, orcGroup);
            battle_of_helm_s_deep.Fight();
            Assert.AreEqual<int>((int)orcGroup.orcs[0].GetMaxHealh(), orcGroup.orcs[0].GetHealth());
            Assert.IsTrue(elfGroup.AllDead()); //itt elso leny nem eli tul a csatat
            Assert.IsFalse(orcGroup.AllDead()); // utolso leny tzuleli
        }

        [TestMethod]
        public void DuelBattleWonByFirst() //elso leny nem eli tul, utolso leny tuleli 
        {
            UniqueList<Elf> oneelf = new UniqueList<Elf>();
            oneelf.Add(new Reckless("Sanyi"));
            UniqueList<Orc> oneorc = new UniqueList<Orc>();
            oneorc.Add(new Cunning("Sandor", 12));
            ElfGroup elfGroup = new ElfGroup(oneelf);
            OrcGroup orcGroup = new OrcGroup(oneorc);
            Battle battle_of_helm_s_deep = new Battle(elfGroup, orcGroup);
            battle_of_helm_s_deep.Fight();
            Assert.IsFalse(elfGroup.AllDead()); //itt elso leny tuleli a csatat
            Assert.IsTrue(orcGroup.AllDead()); // utolso leny nem eli tul
        }

        [TestMethod]

        public void ProperBattle() //tobb leny
        {
            UniqueList<Elf> twoelf = new UniqueList<Elf>();
            twoelf.Add(new Wise("Sanyi"));
            twoelf.Add(new Wise("Kenyeres"));
            UniqueList<Orc> twoorc = new UniqueList<Orc>();
            twoorc.Add(new Cunning("Sandor", 12));
            twoorc.Add(new Ferocious("Wilhelm the 3rd", 300));
            ElfGroup elfGroup = new ElfGroup(twoelf);
            OrcGroup orcGroup = new OrcGroup(twoorc);
            Battle battle_of_helm_s_deep = new Battle(elfGroup, orcGroup);
            battle_of_helm_s_deep.Fight();
            Assert.AreEqual<int>((int)orcGroup.orcs[0].GetMaxHealh(), orcGroup.orcs[0].GetHealth());
            Assert.AreEqual<int>(85, orcGroup.orcs[1].GetHealth());
            Assert.IsTrue(elfGroup.AllDead());
        }

        //Az életben maradtak tulajdonságai megfelelő változásának vizsgálata (kincs, életerő, elfek esetén elixír)
        [TestMethod]
        public void ExaminationOfCreatureProperties1() //tobb leny
        {
            UniqueList<Elf> twoelf = new UniqueList<Elf>();
            twoelf.Add(new Reckless("Sanyi"));
            twoelf.Add(new Wise("Kenyeres"));
            UniqueList<Orc> twoorc = new UniqueList<Orc>();
            twoorc.Add(new Cunning("Sandor", 12));
            twoorc.Add(new Careful("Wilhelm the 3rd", 10));
            ElfGroup elfGroup = new ElfGroup(twoelf);
            OrcGroup orcGroup = new OrcGroup(twoorc);
            Battle battle_of_helm_s_deep = new Battle(elfGroup, orcGroup);
            battle_of_helm_s_deep.Fight();
            Assert.AreEqual<int>(55, (int)elfGroup.elves[0].GetHealth());
            Assert.AreEqual<int>(22, (int)elfGroup.elves[0].GetTreasure());
            Assert.AreEqual<int>(0, (int)elfGroup.elves[0].GetElixir());
            Assert.AreEqual<int>(60, (int)elfGroup.elves[1].GetHealth());
            Assert.AreEqual<int>(0, (int)elfGroup.elves[1].GetTreasure());
            Assert.AreEqual<int>(0, (int)elfGroup.elves[1].GetElixir());
            Assert.IsTrue(orcGroup.AllDead());
        }

        [TestMethod]
        public void ExaminationOfCreatureProperties2()
        {
                UniqueList<Elf> twoelf = new UniqueList<Elf>();
                twoelf.Add(new Wise("Sanyi"));
                twoelf.Add(new Wise("Kenyeres"));
                UniqueList<Orc> twoorc = new UniqueList<Orc>();
                twoorc.Add(new Cunning("Kunyeráló", 12));
                twoorc.Add(new Ferocious("Feró", 300));
                ElfGroup elfGroup = new ElfGroup(twoelf);
                OrcGroup orcGroup = new OrcGroup(twoorc);
                Battle battle_of_helm_s_deep = new Battle(elfGroup, orcGroup);
                battle_of_helm_s_deep.Fight();
                Assert.AreEqual<int>((int)orcGroup.orcs[0].GetMaxHealh(), (int)orcGroup.orcs[0].GetHealth());
                Assert.AreEqual<int>(12, (int)orcGroup.orcs[0].GetTreasure());
                Assert.AreEqual<int>(85, (int)orcGroup.orcs[1].GetHealth());
                Assert.AreEqual<int>(300, (int)orcGroup.orcs[1].GetTreasure());
                Assert.IsTrue(elfGroup.AllDead());
        }
    } 
}