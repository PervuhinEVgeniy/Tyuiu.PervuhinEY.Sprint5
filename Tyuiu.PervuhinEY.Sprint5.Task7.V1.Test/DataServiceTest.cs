using Tyuiu.PervuhinEY.Sprint5.Task7.V1.Lib;

namespace Tyuiu.PervuhinEY.Sprint5.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckLoadDataAndSave()
        {
            DataService ds = new DataService();

            string testPath = @"C:\DataSprint5\InPutDataFileTask7V1.txt";
            Directory.CreateDirectory(@"C:\DataSprint5\");
            File.WriteAllText(testPath, "123 Привет, это тестовая строка 456.");
            string expectedContent = " Привет, это тестовая строка .";
            string resPath = ds.LoadDataAndSave(testPath);
            string actualContent = File.ReadAllText(resPath);
            Assert.AreEqual(expectedContent, actualContent);
        }
    }
}
