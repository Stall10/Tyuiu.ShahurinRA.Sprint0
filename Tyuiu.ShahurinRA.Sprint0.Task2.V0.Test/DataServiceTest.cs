using System.Security.Cryptography.X509Certificates;
using Tyuiu.ShahurinRA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ShahurinRA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
            public void CheckGetMessageValid()
            {
                var name = "Рома";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("привет, Рома", res);
            }
    }
}
