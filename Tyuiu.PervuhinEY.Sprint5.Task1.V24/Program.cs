using Tyuiu.PervuhinEY.Sprint5.Task1.V24.Lib;
namespace Tyuiu.PervuhinEY.Sprint5.Task1.V24;

class Program
{
    static void Main(string[] args)
    {


        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Первухин Е. Ю.| АСОиУБ-26-1";
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Спринт #5                                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Тема: Базовые навыки работы с C#                                 *");
        Console.WriteLine("* Задание #1                                                       *");
        Console.WriteLine("* Вариант #24                                                      *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Дано функция F(x) произвести табулирование на диапазоне [-5;5]   *");
        Console.WriteLine("* с шагом 1. Произвести проверку деления на 0. Резлуьтат сохранить *");
        Console.WriteLine("* в текстововм файле OutPutFileTask1.txt                           *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("*                                                                  *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Результат                                                        *");
        int x = -5;
        int y = 5;
        string res = ds.SaveToFileTextData(x, y);
        Console.WriteLine("********************************************************************");
        Console.WriteLine("Файл:" + res);
        Console.WriteLine("Создан");

        Console.ReadKey();

    }
}
