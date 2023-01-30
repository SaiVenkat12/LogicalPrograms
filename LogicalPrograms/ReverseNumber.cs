using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void Reverse()
        {
            int reverse = 0;
            int temp;
            Console.WriteLine("Enter the Number to Reverse : ");
            int n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                temp = n % 10;
                reverse = (reverse * 10) + temp;
                n/= 10;
            }
            Console.WriteLine("Reverse Number=" + reverse);
        }
    }
}
