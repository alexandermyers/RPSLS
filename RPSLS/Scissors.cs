using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Scissors : Gesture
    {
        // Variables
        
        // Constructor
        public Scissors()
        {
            this.beatsRock = false;
            this.beatsPaper = true;
            this.beatsSpock = false;
            this.beatsLizard = false;
            name = "scissors";
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

