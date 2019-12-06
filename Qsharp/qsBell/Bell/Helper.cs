using System;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;

namespace qsBell.Bell
{
    public static class Helper
    {
        private static string sep => "################################################";
        public static void Print(string method)
        {
            Console.WriteLine(sep + "\n" + method + "\n" + sep);
        }
        public static void StartTime(Stopwatch stopwatch)
        {
            stopwatch.Start();
        }
        public static void OperationTime(Stopwatch stopwatch)
        {
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Print("RunTime: " + elapsedTime);
        }
    }
}