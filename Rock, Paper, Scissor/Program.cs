using System.Runtime.Intrinsics.Arm;

namespace ROCKPAPERSCISSOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0, scoreCPU = 0, draw = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine("[1]Rock, [2]Paper, [3]Scissor");
                    Console.Write("What is your move? ");
                    inputPlayer = Console.ReadLine().ToLower();

                    var rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "rock";
                            Console.WriteLine("Computer chose rock");
                            if (inputPlayer == "1")
                            {
                                Console.WriteLine("Draw!\n\n");
                                draw++;
                            }

                            else if (inputPlayer == "2")
                            {
                                Console.WriteLine("You won!\n\n");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "3")
                            {
                                Console.WriteLine("You lost!\n\n");
                                scoreCPU++;
                            }

                            else
                            {
                                Console.WriteLine("That's invalid");
                                Console.WriteLine("");
                            }
                            break;

                        case 2:
                            inputCPU = "paper";
                            Console.WriteLine("Computer chose paper");
                            if (inputPlayer == "1")
                            {
                                Console.WriteLine("You lost!\n\n");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "2")
                            {
                                Console.WriteLine("Draw!\n\n");
                                draw++;
                            }

                            else if (inputPlayer == "3")
                            {
                                Console.WriteLine("You won!\n\n");
                                scorePlayer++;
                            }

                            else
                            {
                                Console.WriteLine("That's invalid");
                                Console.WriteLine("");
                            }
                            break;

                        case 3:
                            inputCPU = "scissor";
                            Console.WriteLine("Computer chose scissor");
                            if (inputPlayer == "1")
                            {
                                Console.WriteLine("You won!\n\n");
                                scorePlayer++;
                            }

                            else if (inputPlayer == "2")
                            {
                                Console.WriteLine("You lost!\n\n");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "3")
                            {
                                Console.WriteLine("Draw!\n\n");
                                draw++;
                            }

                            else
                            {
                                Console.WriteLine("That's invalid");
                                Console.WriteLine("");
                            }
                            break;

                        default:
                            Console.WriteLine("Nuh uh, it is not there");
                            break;
                    }
                    Console.WriteLine($"Player: {scorePlayer}\tComputer: {scoreCPU}\tDraws occured: {draw}");
                }

                Console.WriteLine($"Player: {scorePlayer}\nComputer: {scoreCPU}\nDraws occured: {draw}");

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player won");
                }

                else if (scoreCPU == 3)
                {
                    Console.WriteLine("Computer Won");
                }

                Console.Write("Do you want to play again? y/n: ");
                string loop = Console.ReadLine().ToLower();

                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                    
                }

                else if (loop == "n")
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing!");
                }

                else
                {
                    Console.WriteLine("That's an invalid response\a");
                    break;
                }
            }
        }
    }
}