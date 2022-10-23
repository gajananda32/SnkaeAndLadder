using System;
namespace SL2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random function to generate 1,2,3,4,5,6
            Random random = new Random();
            int ran = random.Next(1,7);
            Console.WriteLine("Player roll the die: ");
            Console.WriteLine(ran);
        }
    }
}