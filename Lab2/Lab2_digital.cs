using System;

namespace numbers
{
    class Program
    {
        static UInt64 Calculate(UInt64 a)
        {
            UInt64 power = 0;
            while (a > 0)
            {
                a /= 2;
                power += a;
            }
            return power;
        }

        static int Main(string[] args)
        {
            UInt64 a = 0, b = 0;
           
            Console.Write("Enter a. A must be > 0: ");
            string str_a = Console.ReadLine();
            while(!UInt64.TryParse(str_a, out a) || (a <= 0))
                 str_a = Console.ReadLine();
            
           
            Console.Write("Enter positive b (b > a): ");
            string str_b = Console.ReadLine();
            while(!UInt64.TryParse(str_b, out b) || (b <= a))
                str_b = Console.ReadLine();


           
            UInt64 powerA = Calculate(a - 1);
            UInt64 powerB = Calculate(b);
            Console.WriteLine("The power of two is: 2^" + (powerB - powerA));
            return 0;
        }
    }
}
