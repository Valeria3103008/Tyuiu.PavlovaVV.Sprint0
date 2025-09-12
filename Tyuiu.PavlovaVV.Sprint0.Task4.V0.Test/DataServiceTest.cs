using Tyuiu.PavlovaVV.Sprint0.Task4.V0.Lib;
namespace Tyuiu.PavlovaVV.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckesdValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
