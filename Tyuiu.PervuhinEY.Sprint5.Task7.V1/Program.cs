using System;
using System.IO;
using Tyuiu.PervuhinEY.Sprint5.Task7.V1.Lib;

namespace Tyuiu.PervuhinEY.Sprint5.Task7.V1
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Первухин Е. Ю. | АСОиУб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V1.txt в котором есть        *");
            Console.WriteLine("* набор символьных данных. Удалить все цифры из файла.                    *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V1.txt.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V1.txt";
            Console.WriteLine($"Данные берутся из файла: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string resPath = ds.LoadDataAndSave(path);

            Console.WriteLine($"Файл успешно сохранен по пути: {resPath}");
            Console.WriteLine("\nСодержимое нового файла (без цифр):");

            Console.WriteLine(File.ReadAllText(resPath));

            Console.ReadKey();
        }
    }
}