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
            int diceCount=0;

            while (position < 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                diceCount++;

                Console.WriteLine();
                Console.WriteLine("Dice has been Rolled: " + dice);
                Console.WriteLine("Checking for Options:");

                int opt = random.Next(1, 4);
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("It's No Play: You don't advance.");
                        Console.WriteLine("Your Current Position is "+position);
                        break;
                    case 2:
                        Console.WriteLine("Congrats, its Ladder: You advance by " + dice);
                        position = position + dice; //99 + 6= 105
                        if(position>100)
                        {
                            Console.WriteLine("Since its going ahead of 100,You do not advance.");
                            position = position - dice;
                            Console.WriteLine("Your Current Position is " + position);
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("Your Current Position is " + position);
                            break;
                        }
                        //Console.WriteLine("Your Current Position is " + position);
                    case 3:
                        Console.WriteLine("Opps!,its a Snake: You retreat by " + dice);
                        position = position - dice;
                        Console.WriteLine("Your Current Position is " + position);
                        if (position < 0)
                        {
                            position = startPosition;
                            Console.WriteLine("You start again from 0.");
                            break;
                        }
                        else
                        {
                            break;
                        }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Congrats, You win.");
            Console.WriteLine("The Dice was rolled {0} times.",diceCount);

        }
    }
}
