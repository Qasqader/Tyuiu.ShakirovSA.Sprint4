using Tyuiu.ShakirovSA.Sprint4.Task4.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Введите количество строк в массиве");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов в массиве");
        int cols = Convert.ToInt32(Console.ReadLine());
        int[,] mtrx = new int[rows, cols];
        Console.WriteLine();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Введите {i}, {j} элемент массива ");
                mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("\n Массив:");
        for(int i = 0; i < rows; i++)
        {
            for(int j  = 0; j < cols; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Исходная матрица");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int[,] res = ds.Calculate(mtrx);
        Console.WriteLine("Результирующая матрица");
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                Console.Write($"{res[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}