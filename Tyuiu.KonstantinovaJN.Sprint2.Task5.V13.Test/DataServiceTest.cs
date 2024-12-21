using Tyuiu.KonstantinovaJN.Sprint2.Task5.V13.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("2024-09-09", ds.FindDateOfNextDay(2024, 9, 8));
            Assert.AreEqual("2024-09-01", ds.FindDateOfNextDay(2024, 8, 31));
            Assert.AreEqual("2024-02-29", ds.FindDateOfNextDay(2024, 2, 28));
            Assert.AreEqual("2025-01-01", ds.FindDateOfNextDay(2024, 12, 31));
        }
    }
}