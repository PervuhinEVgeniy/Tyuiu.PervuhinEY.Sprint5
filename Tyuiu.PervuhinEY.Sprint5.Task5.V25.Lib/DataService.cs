using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PervuhinEY.Sprint5.Task5.V25.Lib
{
    public class DataService : ISprint5Task5V25
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] strings = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            double product = 1;
            bool hasRealNumbers = false; 

            foreach (string str in strings)
            {
                if (double.TryParse(str.Replace(',', '.'), NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                {
                    if (number % 1 != 0)
                    {
                        product *= number;
                        hasRealNumbers = true;
                    }
                }
            }
            return Math.Round(product, 3);
        }
    }
}
