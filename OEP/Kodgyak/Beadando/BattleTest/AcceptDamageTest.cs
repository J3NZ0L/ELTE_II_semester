using BattleOfHelm_sDeep;
using BattleOfHelm_sDeep.ElfTypes;
using BattleOfHelm_sDeep.OrcTypes;
using BattleOfHelm_sDeep.Groups;

namespace BattleTest
{
    [TestClass]
    public class AcceptDamageTest
    {
        [TestMethod]
        public void TestWise()
        {
            Wise elf = new Wise("Sanyi");
            Cunning kunyi = new Cunning("Kunyi", 0);
            Careful kerfu = new Careful("Kerfűi Kata", 0);
            Ferocious feri = new Ferocious("Ferenc", 0);
            kunyi.Attack(elf);
            Assert.AreEqual<int>((int)elf.GetMaxHealh() - 5, elf.GetHealth());
            kerfu.Attack(elf);
            Assert.AreEqual<int>((int)elf.GetMaxHealh() - 5 -0, elf.GetHealth());
            feri.Attack(elf);
            Assert.AreEqual<int>((int)elf.GetMaxHealh() -5 -0 -20, elf.GetHealth());
        }
        [TestMethod]
        public void TestDexterous()
        {
            Dexterous elf = new Dexterous("Sanyi");
            Cunning kunyi = new Cunning("Kunyi", 0);
            Careful kerfu = new Careful("Kerfűi Kata", 0);
            Ferocious feri = new Ferocious("Ferenc", 0);
            kunyi.Attack(elf);
            Assert.AreEqual<int>((int)elf.GetMaxHealh() - 0, elf.GetHealth());
            kerfu.Attack(elf);
            Assert.AreEqual<int>((int)elf.GetMaxHealh() - 0 - 0, elf.GetHealth());
            feri.Attack(elf);
            Assert.AreEqual<int>((int)elf.GetMaxHealh() - 0 - 0 - 10, elf.GetHealth());
        }
        [TestMethod]
        public void TestReckless()
        {
            Reckless elf = new Reckless("Sanyi");
            Cunning kunyi = new Cunning("Kunyi", 0);
            Careful kerfu = new Careful("Kerfűi Kata", 0);
            Ferocious feri = new Ferocious("Ferenc", 0);
            kunyi.Attack(elf);
            Assert.AreEqual<int>((int)elf.GetMaxHealh() - 5, elf.GetHealth());
            kerfu.Attack(elf);
            Assert.AreEqual<int>((int)elf.GetMaxHealh() - 5 - 0, elf.GetHealth());
            feri.Attack(elf);
            Assert.AreEqual<int>((int)elf.GetMaxHealh() - 5 - 0 - 20, elf.GetHealth());
        }

        [TestMethod]
        public void TestCunning()
        {
            Cunning orc = new Cunning("Kunyi",0);
            Wise vizi= new Wise("Vizi");
            Dexterous dede = new Dexterous("Dede");
            Reckless reki = new Reckless("Rekonstruator");
            vizi.Attack(orc);
            Assert.AreEqual<int>((int)orc.GetMaxHealh() - 0, orc.GetHealth());
            dede.Attack(orc);
            Assert.AreEqual<int>((int)orc.GetMaxHealh() - 0 - 0, orc.GetHealth());
            reki.Attack(orc);
            Assert.AreEqual<int>((int)orc.GetMaxHealh() - 0 - 0 - 10, orc.GetHealth());
        }
        [TestMethod]
        public void TestCareful()
        {
            Careful orc = new Careful("Karcsi", 0);
            Wise vizi = new Wise("Vizi");
            Dexterous dede = new Dexterous("Dede");
            Reckless reki = new Reckless("Rekonstruator");
            vizi.Attack(orc);
            Assert.AreEqual<int>((int)orc.GetMaxHealh() - 0, orc.GetHealth());
            dede.Attack(orc);
            Assert.AreEqual<int>((int)orc.GetMaxHealh() - 0 - 5, orc.GetHealth());
            reki.Attack(orc);
            Assert.AreEqual<int>((int)orc.GetMaxHealh() - 0 - 5 - 15, orc.GetHealth());
        }
        [TestMethod]
        public void TestFerocious()
        {
            Ferocious orc = new Ferocious("Ferenc", 0);
            Wise vizi = new Wise("Vizi");
            Dexterous dede = new Dexterous("Dede");
            Reckless reki = new Reckless("Rekonstruator");
            vizi.Attack(orc);
            Assert.AreEqual<int>((int)orc.GetMaxHealh() - 5, orc.GetHealth());
            dede.Attack(orc);
            Assert.AreEqual<int>((int)orc.GetMaxHealh() - 5 - 15, orc.GetHealth());
            reki.Attack(orc);
            Assert.AreEqual<int>((int)orc.GetMaxHealh() - 5 - 15 - 25, orc.GetHealth());
        }

    }
}
