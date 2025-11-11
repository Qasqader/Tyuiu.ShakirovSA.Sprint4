using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShakirovSA.Sprint4.Task6.V30.Lib
{
    public class DataService : ISprint4Task6V30
    {
        public string[] Calculate(string[] array)
        {
            int count = 0;
            foreach (string i in array) {
                {
                    if (i.Length > 5)
                    count++;
                } }
            string[] result = new string[count];
            int index = 0;
            foreach (string i in array)
            {
                if (i.Length > 5)
                {
                    result[index] = i;
                }
            }
            return result;
        }
        
    }
}
