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
                Console.WriteLine("1.Fibonacci Series \n2.PerfectNumbert \n3.Prime Number \n4.Reverse a number \n5.Temperature Conversion \n6.Monthly Payment \n7.Coupon Number Generator \n8.Day Of Week \n9.Stop Watch \n22.Exit");
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
                    case 5:
                        TemperatureConversion.Conversion();
                        break;
                    case 6:
                        MonthlyPayment.InterestPerMonth();
                        break;
                    case 7:
                        CouponNumber.CouponGenerator();
                        break;
                    case 8:
                        DayOfWeek.Day();
                        break;
                    case 9:
                        StopWatch.StopWatchTimer();
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
