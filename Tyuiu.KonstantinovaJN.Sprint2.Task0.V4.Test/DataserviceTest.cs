using Tyuiu.KonstantinovaJN.Sprint2.Task0.V4.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint2.Task0.V4.Test
{
    [TestClass]
    public class DataserviceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int x = 333;
            int y = 324;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}