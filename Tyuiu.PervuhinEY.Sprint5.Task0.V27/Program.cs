using Tyuiu.PervuhinEY.Sprint5.Task0.V27.Lib;
namespace Tyuiu.PervuhinEY.Sprint5.Task0.V27;

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
        Console.WriteLine("* Задание #0                                                       *");
        Console.WriteLine("* Вариант #27                                                       *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат       *");
        Console.WriteLine("* сохранить в текстовый файл OutPutFileTask0.txt и вывести на      *");
        Console.WriteLine("* консоль.                                                         *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("*                                                                  *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Результат                                                        *");
        int x = 3;
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("********************************************************************");
        Console.WriteLine("Файл:" + res);
        Console.WriteLine("Создан");

        Console.ReadKey();

    }
}
