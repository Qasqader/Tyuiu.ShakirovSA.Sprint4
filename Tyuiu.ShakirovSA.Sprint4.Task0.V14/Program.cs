using Tyuiu.ShakirovSA.Sprint4.Task0.V14.Lib;
internal class Program { 
        private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] nums = { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
        Console.WriteLine("Исходный массив");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.GetSumOddArrEl(nums);
        Console.WriteLine("Ответ: " + res);
        Console.ReadKey();
    }
}