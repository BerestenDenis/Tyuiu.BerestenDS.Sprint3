using Tyuiu.BerestenDS.Sprint3.Task6.V9.Lib;
namespace Tyuiu.BerestenDS.Sprint3.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {

            DataService ds = new DataService();
            int startValue = 19;
            int stopValue = 30;
            int res = ds.GetSumTheDivisors(startValue,stopValue);
            int wait = 53;
            Assert.AreEqual(wait,res);
        }
    }
}