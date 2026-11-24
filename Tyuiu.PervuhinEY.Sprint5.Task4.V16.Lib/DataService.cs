using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PervuhinEY.Sprint5.Task4.V16.Lib
{
    public class DataService: ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            strx = strx.Trim().Replace(',', '.');
            double x = double.Parse(strx, CultureInfo.InvariantCulture);
            double y = Math.Cos(x) + Math.Pow(x, 2) - (2 * x / 1.2);
            return Math.Round(y, 3);



        }
    }
}
