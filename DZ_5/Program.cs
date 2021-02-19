using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double x, y;
            
            st:
            x = Convert.ToDouble(Console.ReadLine());
            if ((x % 1) != 0)
            {
                Console.WriteLine("вы ввели не целое число");
                goto st;
            }

            st1:
            y = Convert.ToDouble(Console.ReadLine());
            if ((x % 1) != 0)
            {
                Console.WriteLine("вы ввели не целое число");
                goto st1;
            }
            
            Console.WriteLine("Ответ: " + Convert.ToString(Convert.ToInt32(x) + Convert.ToInt32(y)));
            Console.ReadKey();

        }
    }
}
