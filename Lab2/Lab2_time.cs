using System;

namespace Lab2_time
{
    class Program
    {
        static void Check(ref string str)
        {
            int[] arr = new int[10]; 

            for (int i = 0; i < 10; i++)
                arr[i] = 0;

            for(int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (str[i] == j + '0')
                        arr[j]++;
                }
            }
            for(int i = 0; i < 10; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine("Form DateTime have " + arr[i] + " number " + i);
                }
            }
           
        }  
        static void Main(string[] args)
        {
            
            string date1 = DateTime.Now.ToString();
            string date2 = DateTime.UtcNow.ToString();
            
            Console.WriteLine(date1 + ":");
            Check(ref date1);
            Console.WriteLine();

            Console.WriteLine(date2 + ":");
            Check(ref date2);

        }
    }
}
