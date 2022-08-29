namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");

            Console.WriteLine("Select option \n1.Single Player");
            int option =Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    SinglePlayer.SinglePlayerGame();
                    break;
                default:
                     Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}