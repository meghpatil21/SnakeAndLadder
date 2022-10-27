namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");

            Console.WriteLine("Select option \n1.Single Player \n2.Two Player");
            int option =Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    SinglePlayer.SinglePlayerGame();
                    break;
                case 2:
                    TwoPlayers.TwoPlayerGame();
                    break ;
                default:
                     Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }
}