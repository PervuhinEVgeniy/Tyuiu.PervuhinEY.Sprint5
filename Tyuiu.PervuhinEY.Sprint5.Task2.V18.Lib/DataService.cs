using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PervuhinEY.Sprint5.Task2.V18.Lib
{
    public class DataService : ISprint5Task2V18
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            string result = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        result += "1";
                    }
                    else
                    {
                        result += "0";
                    }

                    if (j == matrix.GetLength(1) - 1) 
                    {
                        result += "\n";
                    }
                    else
                    {
                        result += ";"; 
                    }
                }
            }

            File.WriteAllText(path, result);

            return path;

        }
    }
}
