using System.Data;
using Tyuiu.ShakirovSA.Sprint4.Task7.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int n = 4;
        int m = 2;
        int[,] mtrx = new int[n, m];
        string str = "31415926";
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int index = 0;
        Console.WriteLine("\nМассив");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(n, m, str);
        Console.WriteLine("Ответ: " + res) ;
        Console.ReadKey();
    }
}