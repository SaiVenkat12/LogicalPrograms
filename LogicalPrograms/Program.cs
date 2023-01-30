using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Logical Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Fibonacci Series \n2.PerfectNumbert \n3.Prime Number \n4.Reverse a number \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Fibonacci.FibonacciSeries();
                        break;
                    case 2:
                        PerfectNumber.Perfect();
                        break;
                    case 3:
                        PrimeNumber.Prime();
                        break;
                    case 4:
                        ReverseNumber.Reverse();
                        break;
                    case 22:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct number ! ");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
