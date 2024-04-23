namespace TestBag
{
    [TestClass]
    public class BagTest
    {
        [TestMethod]
        public void TestSetEmpty()
        {
            Bag.Bag bag = new();
            Assert.AreEqual(bag.ToString(), "{}");

            bag.Insert("barack");
            Assert.AreEqual(bag.ToString(), "{(\"barack\": 1)}");

            bag.SetEmpty();
            Assert.AreEqual(bag.ToString(), "{}");
        }

        [TestMethod]
        public void TestEmpty()
        {
            Bag.Bag bag = new();
            Assert.AreEqual(bag.Empty(), true);

            bag.Insert("barack");
            Assert.AreEqual(bag.Empty(), false);
        }

        [TestMethod]
        public void TestMultipl()
        {
            Bag.Bag bag = new();
            Assert.AreEqual(bag.Multipl("barack"), 0);

            bag.Insert("barack");
            bag.Insert("alma");
            bag.Insert("barack");
            Assert.AreEqual(bag.Multipl("barack"), 2);
        }

        [TestMethod]
        public void TestMax()
        {
            Bag.Bag bag = new();
            Assert.IsNull(bag.Max());
            bag.Insert("alma");
            bag.Insert("barack");
            bag.Insert("barack");
            Assert.AreEqual(bag.Max(), "barack");
            bag.SetEmpty();
        }

        [TestMethod]
        public void TestInsert()
        {
            Bag.Bag bag = new();
            Assert.AreEqual(bag.ToString(), "{}");
            bag.Insert("alma");
            Assert.AreEqual(bag.ToString(), "{(\"alma\": 1)}");
            Assert.AreEqual(bag.Max(), "alma");
            bag.Insert("barack");
            Assert.AreEqual(bag.ToString(), "{(\"alma\": 1), (\"barack\": 1)}");
            Assert.AreEqual(bag.Max(), "alma");
            bag.Insert("barack");
            Assert.AreEqual(bag.ToString(), "{(\"alma\": 1), (\"barack\": 2)}");
            Assert.AreEqual(bag.Max(), "barack");
        }

        [TestMethod]
        public void TestRemove()
        {
            Bag.Bag bag = new();
            bag.Insert("alma");
            bag.Insert("barack");
            bag.Insert("barack");
            Assert.AreEqual(bag.ToString(), "{(\"alma\": 1), (\"barack\": 2)}");
            Assert.AreEqual(bag.Max(), "barack");
            bag.Remove("barack");
            Assert.AreEqual(bag.ToString(), "{(\"alma\": 1), (\"barack\": 1)}");
            Assert.AreEqual(bag.Max(), "alma");
            bag.Remove("alma");
            Assert.AreEqual(bag.ToString(), "{(\"barack\": 1)}");
            Assert.AreEqual(bag.Max(), "barack");
        }
    }
}