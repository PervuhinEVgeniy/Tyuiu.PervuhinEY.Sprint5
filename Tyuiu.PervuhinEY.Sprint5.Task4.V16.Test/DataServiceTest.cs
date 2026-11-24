using Tyuiu.PervuhinEY.Sprint5.Task4.V16.Lib;
namespace Tyuiu.PervuhinEY.Sprint5.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V16.txt";
            DataService ds = new DataService();
            double wait = 13.935;
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);

        }
    }
}
