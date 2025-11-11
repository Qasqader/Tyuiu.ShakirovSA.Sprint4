using Tyuiu.ShakirovSA.Sprint4.Task6.V30.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        var trees = new string[] { "Берёза", "Дуб", "Клён", "Сосна", "Пихта", "Осина" };
        for ( int i = 0; i < trees.Length; i++)
        {
            Console.WriteLine(trees[i]);
        }
        Console.WriteLine("Исходный массив");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string[] res = ds.Calculate(trees);
        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }
}