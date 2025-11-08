using Tyuiu.ShakirovSA.Sprint4.Task1.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
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
            Console.WriteLine("Введите значение" + i + "элемента массива");
            nums[i] = Convert.ToInt32(Console.ReadLine());
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