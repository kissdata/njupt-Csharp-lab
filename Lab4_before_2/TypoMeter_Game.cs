using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
namespace Lab4_before_2
{
    class TypoMeter_Game
    {
        public void StartGame()
        {
            String str;
            str = "The Cheater Cheats the Cheating Code";
            String str1;
            str1 = "She Sell Sea Shell On The Sea Shore!";
            Console.WriteLine("Level 1: \n{0}", str);

            String userVal = Console.ReadLine();
            if(userVal==str)
            {
                Console.WriteLine("\nYou WON! Welcome to Level 2! \n");
                Console.WriteLine("Level 2: \n{0}", str1);

                String userVall = Console.ReadLine();
                if (userVall == str1)
                {
                    Console.WriteLine("\nYou Won! Game Over! \n");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\nThe strings do not match..Game Over! \n");
                }
            }
            else
            {
                Console.WriteLine("\nThe strings do not match..Try Again! \n");
                StartGame();
            }
        }
    }

    class Game
    {
        static void Main(String[] args)
        {
            Console.Clear();
            Console.WriteLine("This game has two Levels\n");
            Console.WriteLine("In each level you have to type a string\n");

            Console.WriteLine("You have 35 seconds to complete the game \n");

            TypoMeter_Game obj = new TypoMeter_Game();

            {
                Thread t = new Thread(new ThreadStart(obj.StartGame));
                t.Start();
                Thread.Sleep(35000);
                try
                {
                    t.Abort();//终止线程
                    Console.WriteLine("\n\nSorry You lose! The time is Over!");
                }
                catch (ThreadAbortException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
