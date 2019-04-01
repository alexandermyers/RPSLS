using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RuleDisplay
    {
        // Variables

        // Constructor
        public RuleDisplay()
        {

        }
        // Method
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
            Console.WriteLine("The rules are as follows");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock ");
            Console.WriteLine("Enter number of players (1 or 2)");
            
        }
    }
}
 