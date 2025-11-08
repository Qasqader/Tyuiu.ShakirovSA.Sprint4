using Tyuiu.ShakirovSA.Sprint4.Task2.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int len;
        Console.WriteLine("Введите количество элементов массива");
        len = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[len];
        for (int i = 0; i < len; i++)
        {
            nums[i] = rnd.Next(1, 9);
        }
        Console.WriteLine();
        Console.WriteLine("Массив: ");
        for (int i = 0; i < len; i++)
        {
            Console.Write(nums[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Исходный массив");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(nums);
        Console.WriteLine("Ответ: " + res);
        Console.ReadKey();
    }
}