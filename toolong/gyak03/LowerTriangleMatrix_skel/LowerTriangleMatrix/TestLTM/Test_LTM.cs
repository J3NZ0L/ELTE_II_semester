using LowerTriangleMatrix;

namespace TestLTM;

[TestClass]
public class TestLowerTriangleMatrix
{
    [TestClass]
    public class Test_LTM
    {
        [TestMethod]
        public void TestReadWrite()
        {
            LTM ltm = new(3);
            ltm[1,1] = 1.0;
            ltm[2,1] = 2.0; ltm[2,2] = 2.0;
            ltm[3,1] = 3.0; ltm[3,2] = 3.0; ltm[3,3] = 3.0;
            Assert.AreEqual(ltm[3,1], 3.0);
            Assert.AreEqual(ltm[3,3], 3.0);
            Assert.AreEqual(ltm[2,1], 2.0);
            Assert.ThrowsException<IndexOutOfRangeException>(() => ltm[0,0] = 0.0);
        }

        [TestMethod]
        public void TestAdd()
        {
            LTM a = new(3);
            a[1, 1] = 1.0;
            a[2, 1] = 2.0; a[2, 2] = 2.0;
            a[3, 1] = 3.0; a[3, 2] = 3.0; a[3, 3] = 3.0;
            LTM b = new(3);
            b[1, 1] = 1.0;
            b[2, 1] = 2.0; b[2, 2] = 2.0;
            b[3, 1] = 3.0; b[3, 2] = 3.0; b[3, 3] = 3.0;
            LTM c = a + b;
            Assert.AreEqual(c[1, 1], 2.0);
            Assert.AreEqual(c[2, 2], 4.0);
            Assert.AreEqual(c[3, 1], 6.0);
            c = b + a;
            Assert.AreEqual(c[1, 1], 2.0);
            Assert.AreEqual(c[2, 2], 4.0);
            Assert.AreEqual(c[3, 1], 6.0);
        }

        [TestMethod]
        public void TestMul()
        {
            LTM a = new(3);
            a[1, 1] = 1.0;
            a[2, 1] = 2.0; a[2, 2] = 2.0;
            a[3, 1] = 3.0; a[3, 2] = 3.0; a[3, 3] = 3.0;
            LTM b = new(3);
            b[1, 1] = 1.0;
            b[2, 1] = 0.0; b[2, 2] = 1.0;
            b[3, 1] = 0.0; b[3, 2] = 0.0; b[3, 3] = 1.0;
            LTM c = a * b;
            Assert.AreEqual(c[1, 1], 1.0);
            Assert.AreEqual(c[2, 2], 2.0);
            Assert.AreEqual(c[3, 1], 3.0);
            c = b * a;
            Assert.AreEqual(c[1, 1], 1.0);
            Assert.AreEqual(c[2, 2], 2.0);
            Assert.AreEqual(c[3, 1], 3.0);
        }
    }
}