using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        //Variables
        List<Gesture> GestureList;
        

        //Constructor
        public Computer()
        {
            this.GestureList = new List<Gesture>();
            

            this.GestureList.Insert(0, new Rock());
            this.GestureList.Insert(1, new Paper());
            this.GestureList.Insert(2, new Scissors());
            this.GestureList.Insert(3, new Lizard());
            this.GestureList.Insert(4, new Spock());
        }
        //Methods
        public override void TakeTurn()
        {
            Random rand = new Random();
            int choice = rand.Next(0,5);


            Choice =  GestureList[choice];
            
        }
        
    }
}
