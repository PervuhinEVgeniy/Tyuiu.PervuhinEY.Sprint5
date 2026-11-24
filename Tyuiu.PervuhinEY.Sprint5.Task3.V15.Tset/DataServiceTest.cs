using Microsoft.ApplicationInsights;
using Tyuiu.PervuhinEY.Sprint5.Task3.V15.Lib;
namespace Tyuiu.PervuhinEY.Sprint5.Task3.V15.Tset
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CeckSaveToFileTextData()
        {
            int x = 5;
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
