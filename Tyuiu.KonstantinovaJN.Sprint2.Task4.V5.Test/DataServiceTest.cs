using Tyuiu.KonstantinovaJN.Sprint2.Task4.V5.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint2.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 15;
            double y = 9;
            double res = ds.Calculate(x, y);
            double wait = 165.598;
            Assert.AreEqual(wait, res);
        }


        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 7;
            double res = ds.Calculate(x, y);
            double wait = 75.143;
            Assert.AreEqual(wait, res);
        }
    }
}