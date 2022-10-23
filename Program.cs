using System;
namespace SL3
{
    class Program
    {
        //static variable
        static int postion = 0;
        static void Main(string[] args)
        {
            //variables
            const int snake = 1;
            const int ladder = 2;
            const int No_Play = 3;
            Random random = new Random();  //random function for range 1 to 6
            int die = random.Next(1, 7);
            switch (die)
            {
                case No_Play:
                    postion = 0;
                    break;
                case ladder:
                    postion += die;
                    break;
                case snake:
                    postion -= die;
                    break;
                default:
                    postion = 0;
                    break;
            }
            /// postion of the player after roll of die
            Console.WriteLine("postion of player: " + postion);
        }
    }
}