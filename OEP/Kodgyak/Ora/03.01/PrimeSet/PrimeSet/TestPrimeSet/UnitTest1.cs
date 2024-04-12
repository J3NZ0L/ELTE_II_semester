using System.Security.Cryptography.X509Certificates;

namespace TestPrimeSet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmpty()
        {
            PrimeSet.PrimeSet set = new PrimeSet.PrimeSet(); //nem tudja ebbol h hol van a primeset class
            Assert.AreEqual(0, set.Size);
            set.Add(13);
            Assert.AreEqual(0, set.Size);
            Assert.IsFalse(set.Empty());
            set.SetEmpty();
            Assert.AreEqual(0, set.Size);
            
        }
        [DataTestMethod]
            [DataRow(2)]
            [DataRow(3)]
            [DataRow(19)]
        public void TestInsert(int n)
            {
                PrimeSet.PrimeSet set = new PrimeSet.PrimeSet();
                Assert.IsFalse(set.Int(3));
                set.Add(3);
                Assert.IsTrue(set.Int(n));
            }
        [TestMethod]
        public void TestInsert0()
        {
            PrimeSet.PrimeSet set = new PrimeSet.PrimeSet();
            Assert.ThrowsException<DivideByZeroException>(() => set.Add(0));
        }
        public void TestFail()
        {
            Assert.Fail();
            //az eletben se megy at
        }
    }
}