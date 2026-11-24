using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PervuhinEY.Sprint5.Task6.V4.Lib
{
    public class DataService : ISprint5Task6V4
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            int count = 0;

            foreach (char c in text)
            {
                if (char.IsUpper(c) && (c >= 'А' && c <= 'Я' || c == 'Ё'))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
