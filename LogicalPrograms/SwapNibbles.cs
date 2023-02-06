using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SwapNibbles
    {
        public static void Swap()
        {
            int n;
            double sum=0;
            int[] binary = new int[8];
            int[] swap = new int[8];
            Console.WriteLine("Enter the Number to convert into Binary :");
            int b = Convert.ToInt32(Console.ReadLine());
            n = b;
            for (int i = 0; n > 0; i++)
            {
                binary[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the {0} = ", b);
            for (int k = 7; k >= 0; k--)
            {
                Console.Write(binary[k]);
            }
            Console.WriteLine();
            for(int i=0;i<binary.Length;i++)
            {
                if (i < (binary.Length / 2))
                {
                    swap[i] = binary[i + (binary.Length / 2)];
                }
                else
                {
                    swap[i] = binary[i - (binary.Length / 2)];
                }
            }
            Console.WriteLine("After Swaping  ");
            for (int k = 7; k >= 0; k--)
            {
                Console.Write(swap[k]);
            }
            for (int i=7; i>0; i--)
            {
                if (swap[i]!=0)
                {
                    sum += Math.Pow(2, i);
                }
            }
            Console.WriteLine(" = "+sum);

        }
    }
}
