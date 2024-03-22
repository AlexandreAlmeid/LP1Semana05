using System;
using System.Diagnostics;
using System.Threading;

// System.Diagnostics
// ElapsedMiliseconds
// IsRunning
// Start
// Stop

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(600);

            crono2.Start();
            Thread.Sleep(200);

            crono1.Stop();
            crono2.Stop();

            Console.WriteLine($"Time in crono1: {(float) crono1.ElapsedMilliseconds/1000} seconds.");
            Console.WriteLine($"Time in crono2: {(float) crono2.ElapsedMilliseconds/1000} seconds.");
        }
    }
}
