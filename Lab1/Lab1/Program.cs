using System;
using System.Reflection;
using System.Diagnostics;

namespace Lab1
{
    class Program : ProgramBase
    {
        
        static void CheakInput(ref string betS, ref int bet)
        {
            while (!(int.TryParse(betS, out bet)))
            {
                Console.WriteLine("Pls, input data correct");
                betS = Console.ReadLine();
            }
        }
        static bool Cheak(ref int[] copy)
        {
            if (copy[0] == 14 && copy[1] >= 10)
                return true;
            else if (copy[1] == 14 && copy[0] >= 10)
                return true;
            else 
                return false;
        }
        static int SumIntegers(ref int[] copy)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += copy[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int Package = 5000;

            Random rnd = new Random();
            while (true)
            {
                int[] player = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
                int[] dealer = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };
                
                Console.WriteLine("You have " + Package + " $. How much your bet?");

                string betS = Console.ReadLine();
                int bet = 0;
                CheakInput(ref betS, ref bet);

                if (bet <= 0)
                {
                    Console.WriteLine("Error input");
                    break;
                }
                Package -= bet;

                Console.WriteLine("Your cards:");
                for (int i = 0; i < 2; i++)
                {
                    player[i] = rnd.Next(2, 14);
                    Console.WriteLine(player[i]);
                }


                for (int i = 0; i < 2; i++)
                {
                    dealer[i] = rnd.Next(2, 14);
                    if (i == 0)
                        Console.WriteLine("First card dealer:" + dealer[0]);
                }



                if (Cheak(ref player) && Cheak(ref dealer))
                {
                    Console.WriteLine("Draw. Your cash: " + (Package += bet));
                    Console.WriteLine("You want play again? Input 1(yes), 0(not)");
                    string ansS = Console.ReadLine();
                    int ans = 0;
                    CheakInput(ref ansS, ref ans);
                    if (ans == 0)
                        break;
                    else if (Package > 0 && ans == 1)
                        Console.Clear();
                    else
                    {
                        Console.WriteLine("You don't have enough money ");
                        break;
                    }

                }
                else if (Cheak(ref player))
                {
                    Console.WriteLine("You win. Your cash: " + (Package += bet + bet / 2));
                    Console.WriteLine("You want play again? Input 1(yes), 0(not)");
                    string ansS = Console.ReadLine();
                    int ans = 0;
                    CheakInput(ref ansS, ref ans);
                    if (ans == 0)
                        break;
                    else if (Package > 0 && ans == 1)
                        Console.Clear();
                    else
                    {
                        Console.WriteLine("You don't have enough money ");
                        break;
                    }
                }
                else if (Cheak(ref dealer))
                {
                    Console.WriteLine("You lose!!Your cash: " + Package);
                    Console.WriteLine("You want play again? Input 1(yes), 0(not)");
                    string ansS = Console.ReadLine();
                    int ans = 0;
                    CheakInput(ref ansS, ref ans);
                    if (ans == 0)
                        break;
                    else if (Package > 0 && ans == 1)
                        Console.Clear();
                    else
                    {
                        Console.WriteLine("You don't have enough money ");
                        break;
                    }
                }



                for (int i = 2; i < 10; i++)
                {
                    Console.WriteLine("If you want to hit, input 1(yes) or 0(no)?\n");
                    string ansS = Console.ReadLine();
                    int ans = 0;
                    CheakInput(ref ansS, ref ans);
                    if (ans == 1)
                    {
                        player[i] = rnd.Next(2, 14);
                        Console.WriteLine("+ your card: " + player[i]);
                    }
                    else
                        break;
                }

                Console.WriteLine("Cards of dealer: ");
                Console.WriteLine(dealer[0] + "\n" + dealer[1]);
                for (int i = 2; i < 10; i++)
                {
                    if (SumIntegers(ref dealer) < 17 && i >= 2)
                    {
                        dealer[i] = rnd.Next(2, 14);
                        Console.WriteLine(dealer[i]);
                    }
                }

                if (SumIntegers(ref dealer) > SumIntegers(ref player) && SumIntegers(ref dealer) <= 21)
                {
                    Console.WriteLine("You lose!!Your cash: " + Package);
                }
                else if (SumIntegers(ref dealer) < SumIntegers(ref player) && SumIntegers(ref player) > 21 && SumIntegers(ref dealer) < 21)
                {
                    Console.WriteLine("You lose!!");
                }
                else if (SumIntegers(ref dealer) == SumIntegers(ref player))
                    Console.WriteLine("Draw. Your cash: " + (Package += bet));
                else if (SumIntegers(ref dealer) > 21 && SumIntegers(ref player) > 21)
                {
                    Console.WriteLine("Draw. Your cash: " + (Package += bet));
                }
                else
                {
                    Console.WriteLine("You win. Your cash: " + (Package += bet * 2));
                }



                Console.WriteLine("You want play again? Input 1(yes), 0(not)");
                string aS = Console.ReadLine();
                int a = 0;
                CheakInput(ref aS, ref a);
                if (a == 0)
                    break;
                else if (Package > 0 && a == 1)
                    Console.Clear();
                else
                {
                    Console.WriteLine("You don't have enough money ");
                    break;
                }
            }
        }
    }
}
