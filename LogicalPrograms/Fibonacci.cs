using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibonacci
    {
        public static void FibonacciSeries()
        {
            int sum = 0;
            int a=0; int b=1;
            Console.WriteLine("Enter the Nth term of the Fibonacci Series : ");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("The first Term of Fibonacci Series is 0");
            }
            else if (n == 1)
            {
                Console.WriteLine("The second Term of Fibonacci Series is 1");
            }
            else if(n>1)
            {
                Console.WriteLine("\n0 \n1");
                for (int i = 2; i < n; i++)
                {
                    sum = a + b;
                    a = b;
                    b = sum;
                    Console.WriteLine(sum);
                }
                Console.WriteLine("The {0} Term of Fibonacci Series is {1}", n, sum);
            }
            else
            {
                Console.WriteLine("Enter the Number > 0");
            }
        }
    }
    
}
