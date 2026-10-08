namespace CastTheDice;

class Program
{
    private static bool firstRound = true;

    static void Main()
    {
        Console.WriteLine("Welcome to Cast the Dice!");
        GameLoop();
    }

    private static void GameLoop()
    {
        while (true)
        {
            WriteBreakLineInConsole();

            string question = firstRound ? "Would you like to play?" : "Would you like to play again?";
            Console.WriteLine(question);
            Console.WriteLine("Press 'Y' to play or press any other key quit.");
            var keyInfo = Console.ReadKey();
            Console.WriteLine();
            
            WriteBreakLineInConsole();

            if (keyInfo.KeyChar != 'y')
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            var rand = new Random();
            int[] diceValues = [(int)rand.NextInt64(1, 7), (int)rand.NextInt64(1, 7)];

            Console.WriteLine($"The value of your first dice was {diceValues[0]}.");
            Console.WriteLine($"The value of your second dice was {diceValues[1]}.");
            Console.WriteLine($"The total value is {diceValues.Sum()}.");

            if (diceValues.Sum() == 12)
            {
                Console.WriteLine("Congratulations! You won :D");
            }
            else
            {
                Console.WriteLine("No win this time.");
            }

            if (firstRound) firstRound = false;
        }
    }

    private static void WriteBreakLineInConsole()
    {
        Console.WriteLine("------------------------------------------------");
    }
}
