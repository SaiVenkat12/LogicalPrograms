using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public static void Perfect()
        {
            int sum = 0;
            Console.WriteLine("Enter the Number to check Perfect Number or not : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=(n/2); i++)
            {
                if(n%i==0)
                {
                    sum += i;
                }
            }
            if(sum == n)
            {
                Console.WriteLine("{0} is a Perfect Number",n);
            }
            else
            {
                Console.WriteLine("{0} is Not a Perfect Number",n);
            }
           
        }
    }
}
