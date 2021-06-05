using System;
using System.Collections.Generic;
using System.Text;

    class Delegat
    {
        public delegate void DelegatePerson(ConsoleKeyInfo k);
        static DelegatePerson notify;
        public event DelegatePerson Notify
        {
            add
            {
                notify += value;
                Console.WriteLine($"{value.Method.Name} add");
            }
            remove
            {
                notify -= value;
                Console.WriteLine($"{value.Method.Name} remove");
            }
        }
        public static void Representaion()
        {
            bool b = true;
            ConsoleKeyInfo k = Console.ReadKey();
            Console.WriteLine("Press 1(Nodepad) if you want find out Information of pation. Press 2(Nodepad) if you want find out Plan");

            while (b)
            {
                
                try
                {
                    if (k.Key != ConsoleKey.NumPad1 && k.Key != ConsoleKey.NumPad2)
                        throw new Exception();
                    b = false;
                }
                catch
                {
                    Console.WriteLine("Pls iput correct");
                    k = Console.ReadKey();
                }
            }
            
            while(k.Key != ConsoleKey.Escape)
            {
                notify?.Invoke(k);  
                Console.WriteLine("Do you end? Press esc if yes");
                k = Console.ReadKey();
            }
        }

        public static void DelegatDisplay(Person p)
        {
            notify += delegate (ConsoleKeyInfo k)
            {
                p.InforamationPerson(k);
            };
            notify += (ConsoleKeyInfo k) => p.Plan(k);
            Representaion();
        }
       
    }

