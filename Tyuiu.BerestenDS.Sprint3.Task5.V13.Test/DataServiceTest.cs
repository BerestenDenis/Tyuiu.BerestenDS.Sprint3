using Tyuiu.BerestenDS.Sprint3.Task5.V13.Lib;
namespace Tyuiu.BerestenDS.Sprint3.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds= new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 2;
            int startValue2 = 1;
            int stopValue2 = 12;
            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            double wait = ;
            Assert.AreEqual(wait, res);
        }
    }
}