internal class Program
{
    private static void Main(string[] args)
    {
        //declare variables for the game
        string inputPlayer, inputCPU;
        int randomInt;
       
        bool playAgain = true;

        while (playAgain)
        {

            int scorePlayer = 0;
            int scoreCPU = 0;

            while (scorePlayer < 3 && scoreCPU < 3)
            {
                //get user input
                Console.Write("Choose between ROCK, PAPER and SCISSORS:  ");
                inputPlayer = Console.ReadLine();
                inputPlayer = inputPlayer.ToUpper();

                Random rnd = new Random();

                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputCPU = "ROCK";
                        Console.WriteLine("Computer chose ROCK");
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("DRAW!!\n");
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("PLAYER WINS!!\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("CPU WINS!!\n");
                            scoreCPU++;
                        }
                        break;

                    case 2:
                        inputCPU = "PAPER";
                        Console.WriteLine("Computer chose PAPER");
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("CPU WINS!!\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("DRAW!!\n");
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("PLAYER WINS!!\n");
                            scorePlayer++;
                        }
                        break;
                    case 3:
                        inputCPU = "SCISSORS";
                        Console.WriteLine("Computer chose SCISSORS");
                        if (inputPlayer == "ROCK")
                        {
                            Console.WriteLine("PLAYER WINS!!\n");
                            scorePlayer++;
                        }
                        else if (inputPlayer == "PAPER")
                        {
                            Console.WriteLine("CPU WINS!!\n");
                            scoreCPU++;
                        }
                        else if (inputPlayer == "SCISSORS")
                        {
                            Console.WriteLine("DRAW!!\n");
                        }
                        break;


                    default:
                        Console.WriteLine("Invalid entry");
                        break;


                }//end switch

                Console.WriteLine("SCORES:\tPLAYER:\t{0}\tCPU:{1}\n",scorePlayer,scoreCPU);            

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!!");
                }

            }//end while loop score player

            bool invalidEntry = true;

            while (invalidEntry)
            {
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();

                if (loop != null && loop.Length > 0)
                {
                    loop = loop.ToLower();
                }

                if (loop == "y")
                {
                    invalidEntry = false;
                    playAgain = true;

                    Console.Clear();
                }
                else if (loop == "n")
                {
                    invalidEntry = false;
                    playAgain = false;
                    Console.WriteLine("\nTHANK YOU FOR PLAYING!!");
                }
                else
                {                 
                    Console.WriteLine("Invalid input!");
                    invalidEntry= true;

                }

            }//end while loop invalid entry


        }//end while loop play again

    }//end main
}