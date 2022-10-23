using System;
namespace SnakeAndLadder
{
    class Program
    {
        static int player_postion = 0;
        public static void Main(string[] args)
        {
            const int snake = 1;
            const int ladder = 2;
            const int No_play = 0;
            const int Wining_postion = 100;
            for (int i = 0; i <= Wining_postion; i++)
            {
                Random random = new Random();
                int die = random.Next(1, 7);
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
                if (player_postion < 0)
                {
                    player_postion = 0;
                }
                Console.WriteLine("player postion: "+i);
            }
        }
    }
}