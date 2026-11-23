using Tyuiu.PervuhinEY.Sprint5.Task1.V24.Lib;
namespace Tyuiu.PervuhinEY.Sprint5.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5,5);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
