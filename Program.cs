using System;
namespace SnakeAndLadder
{
    class Program
    {
        // static variable
        static int player_postion = 0;
        public static void Main(string[] args)
        {
            //variables
            const int snake = 1;
            const int ladder = 2;
            const int No_play = 0;
            const int Wining_postion = 100;
            while (player_postion < Wining_postion)
            {
                //Random function to generate 1 to 6
                Random random = new Random();
                int die = random.Next(1, 7);
                // to check swtich case and rolling dies
                int roll = random.Next(1, 3);
                switch (roll)
                {
                    case snake:
                        player_postion -= die;
                        break;
                    case ladder:
                        player_postion += die;
                        break;
                    case No_play:
                        player_postion = 0;
                        break;
                }
            }
                if (player_postion < 100)
                {
                    Console.WriteLine("postion of player in previous postion: " + player_postion);
                }
                else if (player_postion > 100)
                {
                    player_postion = 100;
                    Console.WriteLine("postion of player is: " + player_postion);
                }
        }
        
    }
}