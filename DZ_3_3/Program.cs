using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_3
{
    //54. Вычислить сумму: 1 + 1/2 + 1/3 + ... + 1/n

    class Program
    {
        static void Main(string[] args)
        {

            float result = 0;
            int n;

            Console.WriteLine("Вычисление суммы: 1 + 1/2 + 1/3 + ... + 1/n");
            
            Console.WriteLine("Введите n:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------");

            for (int i = 1; i <= n; i++)
            {
                result = result + (1f / i);
            }

            Console.WriteLine($"Сумма = {result}");

            Console.ReadLine();
        }
    }
}
