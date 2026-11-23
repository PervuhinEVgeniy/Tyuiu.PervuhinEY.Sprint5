using Mono.Cecil;
using Tyuiu.PervuhinEY.Sprint5.Task0.V27.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.PervuhinEY.Sprint5.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);

        }
    }
}
