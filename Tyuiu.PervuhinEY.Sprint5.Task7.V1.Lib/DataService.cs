using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PervuhinEY.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);
            StringBuilder newText = new StringBuilder();
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    newText.Append(c);
                }
            }

            string result = newText.ToString().Trim();
            result = result.TrimEnd('.', ' ');

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V1.txt");
            File.WriteAllText(outputPath, result);

            return outputPath;
        }
    }
}
