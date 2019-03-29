using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSTake2
{
    class Rock : Gesture
    {
        // Member Variables
        bool beatsPaper;
        bool beatsScissors;
        bool beatsLizard;
        bool beatsSpock;
        // Constructor
        public Rock()
        {
            beatsPaper = false;
            beatsScissors = true;
        }
        // Methods
    }
}
