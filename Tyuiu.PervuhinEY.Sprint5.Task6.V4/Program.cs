using System;
using Tyuiu.PervuhinEY.Sprint5.Task6.V4.Lib;

namespace Tyuiu.PervuhinEY.Sprint5.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Первухин Е. Ю. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю. | АСОиУб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask6V4.txt в котором есть       *");
            Console.WriteLine("* набор символьных данных. Найти количество заглавных русских букв        *");
            Console.WriteLine("* в заданной строке.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V4.txt";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.LoadFromDataFile(path);

            Console.WriteLine($"Количество заглавных русских букв: {res}");

            Console.ReadKey();
        }
    }
}