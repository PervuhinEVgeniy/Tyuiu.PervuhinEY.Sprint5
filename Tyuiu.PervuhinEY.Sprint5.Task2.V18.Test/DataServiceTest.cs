
using Tyuiu.PervuhinEY.Sprint5.Task2.V18.Lib;

namespace Tyuiu.PervuhinEY.Sprint5.Task2.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix = { { 3, 8, 4 }, { -5, -4, -3 }, { -9, 0, 2 } };
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);

        }
    }
}
