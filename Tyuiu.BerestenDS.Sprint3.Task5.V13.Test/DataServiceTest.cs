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
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 127.212;
            Assert.AreEqual(wait, res);
        }
    }
}