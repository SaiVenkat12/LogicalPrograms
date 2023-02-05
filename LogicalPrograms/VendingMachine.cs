using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class VendingMachine
    {
        
        public static void Change()
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] count=new int[notes.Length];
            int noteCount = 0;
            Console.WriteLine("Enter the Change in Rs: ");
            int change=Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<notes.Length;i++)
            {
                if (change >= notes[i])
                {
                    int m = change / notes[i];
                    count[i] = m;
                    change=change% notes[i];
                    noteCount += m;
                }
            }
            Console.WriteLine("Minimum No.Of Notes requried : " + noteCount);
            for(int i=0;i<count.Length;i++)
            {
                if (count[i]>=1)
                {
                    Console.WriteLine("{0} Rs = {1}", notes[i], count[i]);
                }
            }
        }
    }
}
