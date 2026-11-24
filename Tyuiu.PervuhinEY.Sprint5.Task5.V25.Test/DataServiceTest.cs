using Tyuiu.PervuhinEY.Sprint5.Task5.V25.Lib;
namespace Tyuiu.PervuhinEY.Sprint5.Task5.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V25.txt";
            double wait = -5973964.557;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
