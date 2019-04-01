using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Rock : Gesture
    {
        // Variables
        
        // Constructor
        public Rock()
        {
            this.beatsSpock = false;
            this.beatsPaper = false;
            this.beatsScissors = true;
            this.beatsLizard = true;
            name = "rock";
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
