using System;
using Tyuiu.PervuhinEY.Sprint5.Task5.V25.Lib;

namespace Tyuiu.PervuhinEY.Sprint5.Task5.V25
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю. | АСОиУб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V25.txt (файл взять из архива)*");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную C:\\DataSprint5\\ и       *");
            Console.WriteLine("* скопировать в неё файл) в котором есть набор значений. Найти            *");
            Console.WriteLine("* произведение всех вещественных чисел в файле. Результат округлить до 3  *");
            Console.WriteLine("* знаков после запятой. Полученный результат вывести на консоль.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V25.txt";
            Console.WriteLine($"Данные берутся из файла: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);

            Console.WriteLine($"Произведение вещественных чисел: {res}");

            Console.ReadKey();
        }
    }
}