using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Validation
    {
        // Variable
        string input;
        string playerInput;
        // Constructor
        public Validation()
        {

        }
        // Method
        public string InputValidation()
        {
            Console.WriteLine("Choose your gesture: 'rock' 'paper' 'scissors' 'lizard' 'spock'");
            input = Console.ReadLine();
            input = input.ToLower();
            switch (input)
            {
                case "rock":
                    return input;
                case "paper":
                    return input;
                case "scissors":
                    return input;
                case "lizard":
                    return input;
                case "spock":
                    return input;
                default:
                    Console.WriteLine("Invalid input");
                    input = this.InputValidation(); 
                    return input;
            }
        }
        public string PlayerValidation()
        {
            input = Console.ReadLine();
            if (input == "1" || input == "2")
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid number of players");
                input = this.PlayerValidation();
                return input;
            }

        }
    }
}
