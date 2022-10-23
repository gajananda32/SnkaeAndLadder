using System;
using System.Reflection;

namespace SL1
{
    internal class SL1
    {
        static void Main(string[] args)
        {
            //variable
            int postion = 0;
            Random random = new Random();   //Random function to generate values
            int die = random.Next(0, 1);
            if(die==postion)
            {
                Console.WriteLine("Starting the game with single player at postion: " + postion);
            }
        }
    }
}