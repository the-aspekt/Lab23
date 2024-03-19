using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, из которого необходимо вычислить факториал");
            int x = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(x);
            Console.WriteLine("А больше я ничего не делаю, сижу починяю примус");
            Thread.Sleep(500);
            Console.WriteLine("Починил!");
            Console.ReadLine();
        }

        static void Factorial (int x)
        {
            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;   
                Thread.Sleep(100);
            }
            Console.WriteLine($" Результат вычислений равен {result}.");
        }

        static async void FactorialAsync (int x)
        {
            await Task.Run(() => Factorial(x));
        }
    }
}
