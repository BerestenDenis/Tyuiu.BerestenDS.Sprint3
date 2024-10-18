using Tyuiu.BerestenDS.Sprint3.Task0.V18.Lib;
namespace Tyuiu.BerestenDS.Sprint3.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 100;

            Assert.AreEqual(wait, res);
            
        }
    }
}