using Tyuiu.PervuhinEY.Sprint5.Task2.V18.Lib;
namespace Tyuiu.PervuhinEY.Sprint5.Task2.V18;

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
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный *");
        Console.WriteLine("* с шагом 1. Произвести проверку деления на 0. Резлуьтат сохранить *");
        Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива *");
        Console.WriteLine("* на 1, отрицательные на 0. Результат сохранить в файл             *");
        Console.WriteLine("* OutPutFileTask2.csv и вывести на консоль.                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                 *");
        Console.WriteLine("********************************************************************");

        int[,] matrix = new int[3, 3];
        Console.WriteLine("Введите 9 целых чисел для заполнения массива 3x3:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Введите элемент [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        string res = ds.SaveToFileTextData(matrix);
        Console.WriteLine("*                                                                  *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("* Результат                                                        *");
        Console.WriteLine("********************************************************************");
        Console.WriteLine("Файл:" + res);
        Console.WriteLine("Создан");

        Console.ReadKey();

    }
}
