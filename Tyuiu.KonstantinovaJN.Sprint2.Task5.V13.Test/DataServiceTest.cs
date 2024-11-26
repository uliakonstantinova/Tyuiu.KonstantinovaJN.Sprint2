using Tyuiu.KonstantinovaJN.Sprint2.Task5.V13.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
         
            Assert.AreEqual("01/03/2024", ds.FindDateOfNextDay(2024, 02, 29));
            Assert.AreEqual("01/01/2024", ds.FindDateOfNextDay(2023, 12, 31));
            Assert.AreEqual("01/05/2023", ds.FindDateOfNextDay(2023, 04, 30));
            Assert.AreEqual("01/12/2023", ds.FindDateOfNextDay(2023, 11, 30));

            Assert.AreEqual("01/04/2023", ds.FindDateOfNextDay(2023, 03, 31));
            Assert.AreEqual("01/02/2024", ds.FindDateOfNextDay(2024, 01, 31));

            Assert.AreEqual("Некорректная дата", ds.FindDateOfNextDay(2023, 13, 01));
            Assert.AreEqual("Некорректная дата", ds.FindDateOfNextDay(2023, 02, 30));
            Assert.AreEqual("Некорректная дата", ds.FindDateOfNextDay(2023, 02, 29));

            Assert.AreEqual("01/03/2020", ds.FindDateOfNextDay(2020, 02, 29));
            Assert.AreEqual("01/03/2020", ds.FindDateOfNextDay(2020, 02, 28));
        }
    }
}