using System;

namespace Pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введiть 3 цiлих числа:");

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int No = 8;

            Console.WriteLine("Числа якi належать iнтервалу [1,10+No]:");
            if (num1 >= 1 && num1 <= (10 + No))
            {
                Console.WriteLine(num1);
            }
            if (num2 >= 1 && num2 <= (10 + No))
            {
                Console.WriteLine(num2);
            }
            if (num3 >= 1 && num3 <= (10 + No))
            {
                Console.WriteLine(num3);
            }
        }
    }

}