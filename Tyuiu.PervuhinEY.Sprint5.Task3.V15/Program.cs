using Tyuiu.PervuhinEY.Sprint5.Task3.V15.Lib;
namespace Tyuiu.PervuhinEY.Sprint5.Task3.V15;

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
        Console.WriteLine("* Задание #2                                                       *");
        Console.WriteLine("* Вариант #18                                                      *");
        Console.WriteLine("* Выполнил: Первухин Е. Ю.| АСОиУБ-26-1                            *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                         *");
        Console.WriteLine("* Дано выражение: F(x) = -1.4*x^3 + 2.3*x^2 + 0.6*x, вычислить его *");
        Console.WriteLine("* F(x) = -1.4*x^3 + 2.3*x^2 + 0.6*x                                *");
        Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива *");
        Console.WriteLine("* значение при x = 5, результат сохранить в бинарный файл          *");
        Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль.Округлить до            *");
        Console.WriteLine("* трёх знаков после запятой.                                       *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");
        int x = 3;
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("*                                                                  *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Результат                                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("Файл:" + res);
        Console.WriteLine("Создан");

        Console.ReadKey();

    }
}
