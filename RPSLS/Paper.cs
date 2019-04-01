using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Paper : Gesture
    {
        // Variables
        
        // Constructor
        public Paper()
        {
            this.beatsRock = true;
            this.beatsSpock = true;
            this.beatsScissors = false;
            this.beatsLizard = false;
            name = "paper";
        }
        // Methods
        public bool Compare(string secondPlayer)
        {
            switch (secondPlayer)
            {
                case "rock":
                    return this.beatsRock;
                case "paper":
                    return this.beatsPaper;
                case "scissors":
                    return this.beatsScissors;
                case "lizard":
                    return this.beatsLizard;
                case "spock":
                    return this.beatsSpock;
                default:
                    return false;

            }
        }
    }
}
