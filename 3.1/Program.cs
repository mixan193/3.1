using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool isAccepted = false;
            while(!isAccepted) 
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    isAccepted = true;
                }
                catch
                {
                    Console.WriteLine("Введены неверные данные");
                }
            }
            string response = isEven(num) ? "Число чётное" : "Число нечётное";
            Console.WriteLine(response);
            Console.ReadKey();
        }
        private static bool isEven(int num)
        {
            return num % 2 == 0;
        }

    }
}
