using Tyuiu.BerestenDS.Sprint3.Task7.V17.Lib;
namespace Tyuiu.BerestenDS.Sprint3.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = startValue - stopValue + 1;
            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = 0;
            valueWaitArray [1] = 0;
            valueWaitArray [2] = 0;
            valueWaitArray [3] = 0;
            valueWaitArray [4] = 0;
            valueWaitArray [5] = 0;
            valueWaitArray [6] = 0;
            valueWaitArray [7] = 0;
            valueWaitArray [8] = 0;
            valueWaitArray [9] = 0;
            valueWaitArray [10] = 0;

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}