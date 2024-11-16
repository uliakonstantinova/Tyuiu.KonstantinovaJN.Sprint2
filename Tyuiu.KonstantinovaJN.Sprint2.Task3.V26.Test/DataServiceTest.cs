using Tyuiu.KonstantinovaJN.Sprint2.Task3.V26.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint2.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 4.702;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {

        }

        [TestMethod]
        public void ValidCondition3()
        {

        }

        [TestMethod]
        public void ValidCondition4()
        {

        }
    }
}