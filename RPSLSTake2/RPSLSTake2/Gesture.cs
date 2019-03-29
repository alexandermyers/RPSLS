using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSTake2
{
    class Gesture
    {
        //member variables (Has A)
        bool beatsPaper;
        bool beatsScissors;
        bool beatsLizard;
        bool beatsSpock;

        Rock Rock;
        Paper Paper;
        Scissors Scissors;
        Lizard Lizard;
        Spock Spock;

        //constructor
        public Gesture()
        {
            Rock = new Rock();
            Paper = new Paper();
            Scissors = new Scissors();
            Lizard = new Lizard();
            Spock = new Spock();
        }
        //memeber methods (Can Do)
        public string PickGesture()
        {
            Console.WriteLine("Select your choice! \nRock \nPaper \nScissors \nLizard \nSpock");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}
