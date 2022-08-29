using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SinglePlayer
    {
        public static void SinglePlayerGame()
        {
            int startPosition = 0; 
            int position = 0;   
            
            Random random = new Random();
            int dice =random.Next(1,7);

            Console.WriteLine();
            Console.WriteLine("Dice has been Rolled: " +dice);
            Console.WriteLine("Checking for Options:");

            int opt=random.Next(1,4);
            switch(opt)
            {
                case 1:
                    Console.WriteLine("It's No Play: You don't advance");
                    break;
                case 2:
                    Console.WriteLine("Congrats, its Ladder: You advance by "+dice);
                    position = position+dice;
                    break;
                case 3:
                    Console.WriteLine("Opps!,its a Snake: You retreat by " + dice);
                    position = position-dice;
                    break;
            }

            

        }
    }
}
