using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class MonthlyPayment
    {
        public static void InterestPerMonth()
        {
            int principal,n,year;
            double payment,r,Rate;
            Console.WriteLine("Enter the Principal Amount : ");
            principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the No.of Years : ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest : ");
            Rate = Convert.ToDouble(Console.ReadLine());
            n = 12 * year;
            r = Rate / (12 * 100);
            payment=(principal*r)/(1-(Math.Pow((1+r),(-n))));
            Console.WriteLine("Monthly Payment : "+payment);
        }
    }
}
