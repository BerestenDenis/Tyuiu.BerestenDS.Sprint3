using Tyuiu.BerestenDS.Sprint3.Task3.V25.Lib;
namespace Tyuiu.BerestenDS.Sprint3.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void valid()
        {
            DataService ds = new DataService();
            string str = "uuuuupds";
            char chr = 'u';
            int res = ds.GetMinCharCount(str, chr);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }
    }
}