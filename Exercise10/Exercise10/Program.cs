namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 4) {
                // menu
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("**************");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - New Game");
                Console.WriteLine("2 - Load Game");
                Console.WriteLine("3 - Options");
                Console.WriteLine("4 - Quit");
                Console.WriteLine("**************");
                Console.WriteLine("");

                // ask user 
                Console.WriteLine("Enter a number from the Menu");
                choice = int.Parse(Console.ReadLine());

                //user inputs

                if (choice == 1)
                {
                    Console.WriteLine("Loading new game...");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Loading game...");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("opening Options...");
                }
                else if (choice <1||choice >4)
                {
                    
                }
             }
        }
    }
}