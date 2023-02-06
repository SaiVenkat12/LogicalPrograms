using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Binary
    {
        public static void ConvertBinary()
        {
            int i, n;           
            int[] binary = new int[8];
            Console.WriteLine("Enter the Number to convert into Binary :");
            int b = Convert.ToInt32(Console.ReadLine());
            n = b;
            for (i = 0; n > 0; i++)
            {
                binary[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the {0} = ",b);
            for (int k = 7; k>=0; k--)
            {
                Console.Write(binary[k]);
            }
            Console.WriteLine();
        }
    }
}
