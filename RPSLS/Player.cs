using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        // Variables
        public Gesture Choice;
        int score;
        Validation Validation;
        
        // Constructor
        public Player()
        {
            Choice = new Gesture();
            Validation = new Validation();
            score = 0;
        }
        // Methods
        public virtual void TakeTurn()
        {
            string input;
            input = Validation.InputValidation();

            switch (input)
            {
                case "rock":
                    Choice = new Rock();
                    break;
                case "paper":
                    Choice = new Paper();
                    break;
                case "scissors":
                    Choice = new Scissors();
                    break;
                case "lizard":
                    Choice = new Lizard();
                    break;
                case "spock":
                    Choice = new Spock();
                    break;
                default:
                    Console.WriteLine("Try reading.");
                    TakeTurn();
                    break;
            }

        }
        public int ScoreIncrease()
        {
            this.score++;
            return this.score;
        }
        public int GetScore()
        {
            return this.score;
        }
    }   
}
