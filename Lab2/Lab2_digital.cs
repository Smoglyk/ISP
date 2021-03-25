using System;

namespace Lab2_digital
{
    class Program
    {
        static void check(out string s, out Int64 i)
        {
            s = Console.ReadLine();
            while (!Int64.TryParse(s, out i))
                s = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string a_s, b_s;
            Int64 count = 0, a, b, product = 1;
            check(out a_s, out a);
            check(out b_s, out b);

            for(Int64 i = a; i < b; i++)
            {
                product *= (i + 1);
            }
            
            while(true)
            {
                if (product % 2 == 0)
                {
                    count++;
                    product /= 2;
                }
                else
                    break;
            }

            Console.WriteLine("2^{0}", count);
        } 
    }
}
