using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        public static void StopWatchTimer() 
        {
            Stopwatch stopwatch = new Stopwatch();
            
            Console.WriteLine("Click Enter to Start");
            string a=Console.ReadLine();
            stopwatch.Start();
            Console.WriteLine("Click Enter to Stop");
            string b = Console.ReadLine();
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",stopwatch.Elapsed);
        }
    }
}
