using Tyuiu.PervuhinEY.Sprint5.Task6.V4.Lib;
namespace Tyuiu.PervuhinEY.Sprint5.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V4.txt";

            int wait = 2;
            int res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
