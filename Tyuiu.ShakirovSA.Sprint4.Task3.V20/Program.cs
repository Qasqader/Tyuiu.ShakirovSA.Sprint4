using System.Runtime.ExceptionServices;
using Tyuiu.ShakirovSA.Sprint4.Task3.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[,] array = { { 8, 7, 7, 8, 5 }, { 4, 3, 5, 3, 6 }, { 5, 3, 8, 6, 3 }, { 6, 3, 8, 5, 4 }, { 3, 6, 8, 3, 4 } };
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0;  j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} \t ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Исходная матрица");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(array);
        Console.WriteLine("Ответ: " + res);
        Console.ReadKey();
    }
}