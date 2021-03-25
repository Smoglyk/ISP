using System;

namespace Lab2_digital
{
    class Program
    {
        static void Check(out string s, out int i)
        {
            s = Console.ReadLine();
            while (!Int32.TryParse(s, out i))
                s = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            string a_s, b_s;
            int count = 0, a, b, product = 1;
            Check(out a_s, out a);
            Check(out b_s, out b);

            for(int i = a; i < b; i++)
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
