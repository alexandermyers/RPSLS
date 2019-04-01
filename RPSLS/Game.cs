using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        // Variables (HAS A)
        Rock rock;
        Paper paper;
        Scissors scissors;
        Lizard lizard;
        Spock spock;
        Player PlayerOne;
        Player PlayerTwo;
        Gesture Gesture;
        // string choiceOne;
        // string choiceTwo;
        int maxScore = 5;
        string playerOneName;
        string playerTwoName;
        


        // Constructor
        public Game(string input)
        {
            rock = new Rock();
            paper = new Paper();
            scissors = new Scissors();
            lizard = new Lizard();
            spock = new Spock();
            Gesture = new Gesture();
            PlayerOne = new Player();
            Console.WriteLine("Player one enter your name: ");
            playerOneName = Console.ReadLine();
            if (input == "1")
            {
                PlayerTwo = new Computer();
                playerTwoName = "Computer";
            }
            else if (input == "2")
            {
                Console.WriteLine("Player two enter your name: ");
                playerTwoName = Console.ReadLine();
                PlayerTwo = new Player();
            }

        }
        // Methods 
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Write("Player One ");
                
                PlayerOne.TakeTurn();

                Console.Clear();
                Console.Write("Player Two ");
                PlayerTwo.TakeTurn();
                Console.Clear();
                Console.WriteLine(PlayerOne.Choice.name + " vs " +PlayerTwo.Choice.name);
                if (PlayerOne.Choice.name == PlayerTwo.Choice.name)
                {
                    Console.WriteLine("MATCH TIE");
                    continue;
                }
                if (this.Compare(PlayerOne.Choice.name, PlayerTwo.Choice.name))
                {
                    PlayerOne.ScoreIncrease();
                }
                else
                {
                    PlayerTwo.ScoreIncrease();
                }
                Console.WriteLine("Player One: " + PlayerOne.GetScore() +  " Points! " + "Player Two: " + PlayerTwo.GetScore() + " Points!");
                if(PlayerOne.GetScore() == maxScore)
                {
                    running = false;
                    Console.WriteLine(playerOneName + " WINS!!!!!!");
                }
                else if(PlayerTwo.GetScore() == maxScore)
                {
                    running = false;
                    Console.WriteLine(playerTwoName + " WINS!!!!!!!");
                }
            }
            Console.ReadLine();
        }

        public bool Compare(string firstGesture, string secondGesture)
        {
            switch (firstGesture)
            {
                case "rock":
                    return this.rock.Compare(secondGesture);
                case "paper":
                    return this.paper.Compare(secondGesture);
                case "scissors":
                    return this.scissors.Compare(secondGesture);
                case "lizard":
                    return this.lizard.Compare(secondGesture);
                case "spock":
                    return this.spock.Compare(secondGesture);
                default:
                    return false;
            }
        }
    }
}