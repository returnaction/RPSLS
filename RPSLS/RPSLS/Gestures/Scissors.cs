using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Gestures
{
    internal class Scissors : Gesture
    {
        public Scissors() => name = "scissors";

        internal override bool WillBeat(Gesture gesture)
        {
            if (gesture.name == "lizard" || gesture.name == "paper")
                return true;
            else
                return false;
        }
    }
}
