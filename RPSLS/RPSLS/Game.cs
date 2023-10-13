using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;
        int numberOfPlayers;

        //Constructor
        public Game() { }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");

            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Rock crushes Lizard");

            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Paper disproves Spock");

            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Scissors cuts Paper");

            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Lizard eats Paper");

            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Spock smashes Scissors");

            Console.WriteLine("\nGame will be best out of 3!");
        }

        public void ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("\nChoose number of players 1 or 2:");

            while (true)
            {
                string temp = Console.ReadLine();

                if (temp == "1")
                {
                    numberOfPlayers = 1;
                    break;
                }
                if(temp == "2")
                {
                    numberOfPlayers = 2;
                    break;
                }
                else
                {
                    Console.WriteLine("\nWrong input. Choose between 1 or 2");
                }
            }
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if(numberOfHumanPlayers == 1)
            {
                playerOne = new HumanPlayer("Player");
                playerTwo = new ComputerPlayer("Computer");
            }
            else
            {
                playerOne = new HumanPlayer("Player 1");
                playerTwo = new HumanPlayer("Player 2");
            }
        }

        public void RoundResults()
        {
            Console.WriteLine($"{playerOne.name} chose {playerOne.chosenGesture.name} | {playerTwo.name} chose {playerTwo.chosenGesture.name}");
            Console.WriteLine($"{playerOne.name} score {playerOne.score} | {playerTwo.name} score {playerTwo.score}");
        }

        public void CompareGestures()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                Console.WriteLine();

                if(playerOne.chosenGesture.name == playerTwo.chosenGesture.name)
                {
                    Console.WriteLine("Tied, Try again");
                }
                else
                {
                    bool oneWins = playerOne.chosenGesture.WillBeat(playerTwo.chosenGesture);
                    if (oneWins)
                    {
                        playerOne.score++;
                        RoundResults();
                    }
                    else
                    {
                        playerTwo.score++;
                        RoundResults();
                    }
                }

                Console.WriteLine("________________________________________________");
            }
        }

        public void DisplayGameWinner()
        {
            if(playerOne.score == 2)
            {
                Console.WriteLine($"\nCongratulation {playerOne.name} is a winner!");
            }
            else
            {
                Console.WriteLine($"\nCongratualion {playerTwo.name} is a winner!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfPlayers);
            CompareGestures();
            DisplayGameWinner();
        }
    }
}
