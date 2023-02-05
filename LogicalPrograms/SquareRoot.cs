using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SquareRoot
    {
        public static void Sqrt() 
        {
            Console.WriteLine("Enter the Number to find the Square Root :");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c > 0)
            {
                double t = c;
                double epsilon = 1e-15;
                while (Math.Abs(t - (c / t)) > epsilon * t)
                {
                    t = ((c / t) + t) / 2;
                }
                Console.WriteLine("Square Root of {0} is {1}", c, t);
            }
            else
            {
                Console.WriteLine("Enter only Non negitive integers");
            }
        }
    }
}
