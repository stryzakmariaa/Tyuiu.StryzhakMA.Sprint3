using Tyuiu.StryzhakMA.Sprint3.Task4.V24.Lib;

namespace Tyuiu.StryzhakMA.Sprint3.Task4.V24.Test
{
    [TestClass]
    public sealed class DataSetviceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 46.75;
            Assert.AreEqual(res, wait);
        }
    }
}
