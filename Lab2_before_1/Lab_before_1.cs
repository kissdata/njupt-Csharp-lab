﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Chapter 4 activity  —— Word Puzzle
namespace Lab2_before_1
{
    class Program
    {
        string[] result = new string[] {"ATE", "EAT", "ART", "MAT", "MET", "RAT", "SAT", "SET",
        "RAM", "SAME", "STARE", "RATE", "MATE", "STEM", "TERM", "EAST", "REST", "TEAR",
        "MARE", "SEAT", "TEAM", "TRAM", "STREAM", "MATS", "SEAM", "MEAT", "MART", "MASTER"};

        string[] compare = new string[35];
        int score = 0;
        public void displayDetails()
        {
            Console.WriteLine("Welcome to the game of Word Puzzle\n");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Create words of three or more letters from the word:\tM A S T E R");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\nInstructions:\n" +
                "1. Please enter the words in uppercase only.\n" +
                "2. Every correct word will add 1 point to your score.\n" +
                "3. In order to quit the game, type 'QUIT'.");
        }
        static void Main(String[] args)
        {
            bool b = true;
            Program p = new Program();
            p.displayDetails();
            Console.WriteLine("Please enter the words.");

            do
            {
                string a;
                a = Console.ReadLine();
                bool c = false;
                for (int i = 0; i < p.compare.Length; i++)
                {// To verify that user don't entered any word more than once.
                    if (a == p.compare[i])
                        c = true;
                }
                if (c == true)
                    Console.WriteLine("You have already entered: " + a);
                bool d = false;
                foreach (string element in p.result)
                {
                    if (a == element)
                    {
                        if (c == false)
                        {
                            p.score++;
                            for (int i = 0; i < p.compare.Length; i++)
                                if ((p.compare[i] == "" || p.compare[i] == null))
                                {
                                    p.compare[i] = a;
                                    Console.WriteLine("Correct");
                                    break;
                                }
                        }
                        d = true;
                    }
                }
                if (a == "QUIT")
                {
                    b = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You final score is:" + p.score);
                    break;
                }
                if (d == false)
                    Console.WriteLine("Incorrect");
            } while (b);
        }

    }
}
