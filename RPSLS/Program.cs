using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            Validation validation = new Validation();
            RuleDisplay ruleDisplay = new RuleDisplay();
            ruleDisplay.DisplayRules();
            
            Game Game = new Game(validation.PlayerValidation());
            // ivalidation.InputValidation("");
            Game.Run();
        }
    }
}
