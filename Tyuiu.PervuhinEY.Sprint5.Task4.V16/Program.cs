using Tyuiu.PervuhinEY.Sprint5.Task4.V16.Lib;
namespace Tyuiu.PervuhinEY.Sprint5.Task4.V16;

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
        Console.WriteLine("* Задание #4                                                       *");
        Console.WriteLine("* Вариант #16                                                      *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt в котором есть*");
        Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить  *");
        Console.WriteLine("* вместо Х в формуле. Вычислить значение по формуле и вернуть      *");
        Console.WriteLine("* полученный результат на консоль.                                 *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask4V16.txt";
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);

        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Результат                                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();

    }
}
