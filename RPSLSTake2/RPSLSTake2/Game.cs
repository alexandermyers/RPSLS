using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSTake2
{
    class Game
    {
        //member variables (Has A)
        Player player1;
        Player player2;
        Player computer;

        //constructor
        public Game()
        {

        }
        //memeber methods (Can Do)
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock!");
            Console.WriteLine("Rules: \n Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock");
            Console.WriteLine("How many people are plaing? (1 or 2): ");
        }
        public int NumberPlayers()
        {
            int numberPlayers = int.Parse(Console.ReadLine());
            return numberPlayers;
        }
    }
}
