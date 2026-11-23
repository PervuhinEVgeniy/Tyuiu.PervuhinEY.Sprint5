using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PervuhinEY.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            double z;
            double u;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Cos(x) * 3;
                z = 4 * x - 0.5;
                u = Math.Sin(x) - 5 * x - 2;
                if (z == 0)
                {
                    strY = "0";
                }
                else
                {
                    strY = Convert.ToString(Math.Round(y / z + u, 2));
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
            
        }
    }
}
