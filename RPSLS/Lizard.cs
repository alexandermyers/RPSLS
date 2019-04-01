using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Lizard : Gesture
    {
        // Variables
        
        // Constructor
        public Lizard()
        {
            this.beatsRock = false;
            this.beatsPaper = true;
            this.beatsScissors = false;
            this.beatsSpock = true;
            name = "lizard";
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
