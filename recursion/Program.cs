using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the factorial factory");
            Console.Write("please enter a number:  ");
            int n = int.Parse(Console.ReadLine());

            //int factorial = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    factorial *= i;
            //}

            int factorial = CalculateFactorial(n);
            Console.WriteLine(factorial);
        }

        static int CalculateFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * CalculateFactorial(n - 1);

        }
    }
}
