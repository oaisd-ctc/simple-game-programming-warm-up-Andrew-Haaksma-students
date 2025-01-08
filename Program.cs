public class Program
{
    public static void Main()
    {
        dice();
    }

    public static void dice()
    {
        //int
        int split = 0;
        int Rounds = 0;
        int user = 0;
        int computer = 0;

        //start of the game
        do
        {
            Random rnd1 = new Random();
            int dice1 = rnd1.Next(1, 7);
            Random rnd2 = new Random();
            int dice2 = rnd2.Next(1, 7);
            if (split == 0)
            {
                //intro
                Console.WriteLine("Dice Game");

                Console.WriteLine("In this game you and a computer Ruival will play 10 rounds");
                Console.WriteLine("where you will each roll a 6-sided dice, and the player");
                Console.WriteLine("with the highest dice value will win the round. The player");
                Console.WriteLine("who wins the most rounds wins that game. Good Luck!");
                Console.WriteLine("press any key to start...");
                Console.ReadKey();
                Console.WriteLine();
                split++;
                continue;
            }
            else if (split != 0)
            {
                //computer roll
                Rounds++;
                Console.WriteLine("Round " + Rounds);
                Console.WriteLine("Rival rolled a " + dice1);
                Console.WriteLine("press any key to roll the dice...");
                Console.ReadKey();

                //user roll
                Console.WriteLine("you rolled a " + dice2); 

                //results
                if (dice2 > dice1)
                {
                    user++;
                    Console.WriteLine("You won this round");
                    Console.WriteLine("The socre in now - You : " + user + ". Rival : " + computer + "");
                    Console.WriteLine("press any key to continue...");
                    Console.WriteLine();
                    Console.ReadKey();
                    continue;
                }
                else if (dice2 < dice1)
                {
                    computer++;
                    Console.WriteLine("The Rival won this round.");
                    Console.WriteLine("The socre in now - You : " + user + ". Rival : " + computer + "");
                    Console.WriteLine("press any key to continue...");
                    Console.WriteLine();
                    Console.ReadKey();
                    continue;

                }
                else
                {
                    Console.WriteLine("This round is a draw!");
                    Console.WriteLine("The socre in now - You : " + user + ". Rival : " + computer + "");
                    Console.WriteLine("press any key to continue...");
                    Console.WriteLine();
                    Console.ReadKey();
                    continue;
                }
            }
        }
        while (Rounds < 10);
        {
            //ending
            if (Rounds < 10)
            {
                Console.WriteLine();
            }
            else
            {
                if (user > computer)
                {
                    Console.WriteLine("Game over.");
                    Console.WriteLine("The socre in now - You : " + user + ". Rival : " + computer + ".");
                    Console.WriteLine("You won!");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
                else if (user < computer)
                {
                    Console.WriteLine("Game over.");
                    Console.WriteLine("The socre in now - You : " + user + ". Rival : " + computer + ".");
                    Console.WriteLine("You lost!");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Game over.");
                    Console.WriteLine("The socre in now - You : " + user + ". Rival : " + computer + ".");
                    Console.WriteLine("This game is a draw.");
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey();
                }
            }

        }

    }
}