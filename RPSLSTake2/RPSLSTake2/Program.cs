using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSTake2
{
    class Program
    {
        static void Main(string[] args)
        {
            Gesture gesture = new Gesture();
            Game game = new Game();
            game.DisplayRules();
            game.NumberPlayers();
            Console.Clear();
            gesture.PickGesture();
        }
    }
}
