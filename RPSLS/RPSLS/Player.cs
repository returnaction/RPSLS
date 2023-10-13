using RPSLS.Gestures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Player
    {
        //Member Variabes (HAS A)
        public string name;
        public int score;
        public List<Gesture> gestures;
        public Gesture chosenGesture;

        //Constructor
        public Player(string name)
        {
            this.name = name;
            gestures = new List<Gesture>
            {   new Rock(),
                new Paper(),
                new Scissors(),
                new Lizard(),
                new Spock()
            };
            score = 0;
        }

        //Member Methods (CAN DO)
        public abstract void ChooseGesture();
    }
}
