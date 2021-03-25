using System;

namespace Lab2_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1 = 0, count2 = 0;
            string str = Console.ReadLine(), strReverse = " ", strStorage;
            for(int i = str.Length - 1; i >= 0; i--)
            {
                count1++;
                if (str[i] == ' ' || i == 0)
                {
                    strStorage = str;
                    strStorage = strStorage.Substring(i);
                    
                    if(i == 0)
                        strReverse = strReverse.Insert(count2 + 1 , strStorage);
                    else
                        strReverse = strReverse.Insert(count2, strStorage);
                    str = str.Remove(i);
                    count2 = count1;
                    count1 = 0;
                }
                
            }
            strReverse = strReverse.Remove(0, 1);

            Console.WriteLine(strReverse);
        } 
    }
}
