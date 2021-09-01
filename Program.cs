using System;

namespace Rock_paper_scissors {

    class Program {

        static void Main(string[] args) {

            try {

                Random rnd = new Random();

                Console.Write("Enter the number of rounds: ");
                string rounds = Console.ReadLine();
                int Rounds = int.Parse(rounds);

                int points = 0;
                int botPoints = 0;
                int rounds2 = Rounds;

                if (Rounds % 2 == 1) {

                    while (rounds2 != 0) {

                        Console.Write("Enter your move ('rock' / 'paper' / 'scissors'): ");
                        string move = Console.ReadLine();
                        move.ToLower();

                        string[] moves = {"rock","paper","scissors"};

                        string botMove = moves[rnd.Next(0,3)];

                        if (move == "rock" && botMove == "paper") {

                            Console.WriteLine("The bot chose paper while you chose rock. The bot got a point!");
                            botPoints ++;

                        } if (move == "rock" && botMove == "rock") Console.WriteLine("You both chose rock. Noone got a point!");

                        if (move == "rock" && botMove == "scissors") {

                            Console.WriteLine("The bot chose scissors while you chose rock. You got a point!");
                            points ++;

                        } if (move == "paper" && botMove == "scissors") {

                            Console.WriteLine("The bot chose scissors while you chose paper. You got a point!");
                            botPoints ++;

                        } if (move == "paper" && botMove == "paper") Console.WriteLine("You both chose paper. Noone got a point!");

                        if (move == "paper" && botMove == "rock") {

                            Console.WriteLine("The bot chose rock while you chose paper. The bot got a point!");
                            points ++;

                        } if (move == "scissors" && botMove == "rock") {

                            Console.WriteLine("The bot chose rock while you chose scissors. The bot got a point!");
                            botPoints ++;
                    
                        } if (move == "scissors" && botMove == "scissors") Console.WriteLine("You both chose scissors. Noone got a point!");

                        if (move == "scissors" && botMove == "paper") {

                            Console.WriteLine("The bot chose paper while you chose scissors. You got a point!");
                            points ++;

                        }

                        rounds2 --;

                        if (move != "rock" && move != "paper" && move == "scissors") {

                            Rounds ++;
                            Console.WriteLine("Please enter a valid move.");

                        }

                    }

                    if (botPoints > points) Console.WriteLine("\nThe bot won!\n\nYour points:\t\tBot points:\n\n" + points + "\t\t\t" + botPoints);

                    else if (points > botPoints) Console.WriteLine("\nYou won!\n\nYour points:\t\tBot points:\n\n" + points + "\t\t\t" + botPoints);

                    else Console.WriteLine("\nIt is a draw!\n\nYour points:\t\tBot points:\n\n" + points + "\t\t\t" + botPoints);

                } else Console.WriteLine("The number of rounds must be odd.");

            } catch (FormatException) {

                Console.WriteLine("Please enter a valid value");

            }

            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}