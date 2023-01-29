using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void Prime()
        {
            int count = 0;
            Console.WriteLine("Enter the Number to check Prime Number or not : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= (n / 2); i++)
            {
                if (n % i == 0)
                {
                  count++;  
                }
            }
            if(count<=2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number", n);
            }
        }
    }
}
