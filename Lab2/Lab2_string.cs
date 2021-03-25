using System;
using System.Text;

namespace Lab2_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, arr_c = 0;
            char[] arr = new char[1000];
            StringBuilder str = new StringBuilder(Console.ReadLine());
           
            for(int i = str.Length - 1; i >= 0; i--)
            {
                count++;
                if (str[i] == ' ' || i == 0)
                {
                    
                    str.CopyTo(i, arr, arr_c, count);
                    arr_c += count;
                    count = 0;
                }
               
            }


            Console.WriteLine(arr);
        } 
    }
}
