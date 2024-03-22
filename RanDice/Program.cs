using System;

namespace RanDice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int s = 1;
            int count = 0;
            
            if(args.Length == 2)
            {
                n = int.Parse(args[0]);
                s = int.Parse(args[1]);
            }
            Random dice = new Random(s);
            for(int i = 0; i < n; i++)
            {
                count += dice.Next(6) + 1;
            }
            Console.WriteLine(count);
        }
    }
}
