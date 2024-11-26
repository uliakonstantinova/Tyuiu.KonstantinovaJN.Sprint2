using Tyuiu.KonstantinovaJN.Sprint2.Task5.V13.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
         
            Assert.AreEqual("1/3/2024", ds.FindDateOfNextDay(2024, 2, 29));
            Assert.AreEqual("1/1/2024", ds.FindDateOfNextDay(2023, 12, 31));
            Assert.AreEqual("1/5/2023", ds.FindDateOfNextDay(2023, 4, 30));
            Assert.AreEqual("1/12/2023", ds.FindDateOfNextDay(2023, 11, 30));

            Assert.AreEqual("1/4/2023", ds.FindDateOfNextDay(2023, 3, 31));
            Assert.AreEqual("1/2/2024", ds.FindDateOfNextDay(2024, 1, 31));

            Assert.AreEqual("Некорректная дата", ds.FindDateOfNextDay(2023, 13, 1));
            Assert.AreEqual("Некорректная дата", ds.FindDateOfNextDay(2023, 2, 30));
            Assert.AreEqual("Некорректная дата", ds.FindDateOfNextDay(2023, 2, 29));

            Assert.AreEqual("1/3/2020", ds.FindDateOfNextDay(2020, 2, 29));
            Assert.AreEqual("1/3/2020", ds.FindDateOfNextDay(2020, 2, 28));
        }
    }
}