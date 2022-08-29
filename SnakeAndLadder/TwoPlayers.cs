using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class TwoPlayers
    {

        public static void TwoPlayerGame()
        {
            int startPosition = 0;
            int position = 0;
            int diceCount = 0;
            int dummy = 0;
            int position2 = 0;

            while (position < 100 && position2<100)
            {
                Console.WriteLine();
                if (dummy == 0)
                {
                   
                    Console.WriteLine("Player 1");

                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    diceCount++;
                    dummy = 1;

                    
                    Console.WriteLine("Dice has been Rolled: " + dice);
                    Console.WriteLine("Checking for Options:");

                    int opt = random.Next(1, 4);
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("It's No Play: You don't advance.");
                            Console.WriteLine("Your Current Position is " + position);
                            break;
                        case 2:
                            Console.WriteLine("Congrats, its Ladder: You advance by " + dice);
                            dummy = 0;
                            Console.WriteLine("You play again.");
                            position = position + dice; //99 + 6= 105
                            if (position > 100)
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
                else
                {
                    Console.WriteLine("player 2");

                    Random random = new Random();
                    int dice = random.Next(1, 7);
                    diceCount++;
                    dummy = 0;

                    
                    Console.WriteLine("Dice has been Rolled: " + dice);
                    Console.WriteLine("Checking for Options:");

                    int opt = random.Next(1, 4);
                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("It's No Play: You don't advance.");
                            Console.WriteLine("Your Current Position is " + position2);
                            break;
                        case 2:
                            Console.WriteLine("Congrats, its Ladder: You advance by " + dice);
                            dummy = 1;
                            Console.WriteLine("You play again.");
                            position2 = position2 + dice; //99 + 6= 105
                            if (position > 100)
                            {
                                Console.WriteLine("Since its going ahead of 100,You do not advance.");
                                position2 = position2 - dice;
                                Console.WriteLine("Your Current Position is " + position2);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Your Current Position is " + position2);
                                break;
                            }
                        //Console.WriteLine("Your Current Position is " + position);
                        case 3:
                            Console.WriteLine("Opps!,its a Snake: You retreat by " + dice);
                            position2 = position2 - dice;
                            Console.WriteLine("Your Current Position is " + position2);
                            if (position2 < 0)
                            {
                                position2 = startPosition;
                                Console.WriteLine("You start again from 0.");
                                break;
                            }
                            else
                            {
                                break;
                            }

                    }





                }
                

            }
            Console.WriteLine();
            if(position==100)
            {
                Console.WriteLine("Player 1 WIN & player 2 is at {0} position.",position2);
            }
            else
            {
                Console.WriteLine("Player 2 WIN & player 1 is at {0} position.", position);
            }
            //Console.WriteLine("Congrats, You win.");
            //Console.WriteLine("The Dice was rolled {0} times.", diceCount);

        }
    }
}
