using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Gestures
{
    internal class Rock : Gesture
    {
        public Rock() => name = "rock";

        internal override bool WillBeat(Gesture gesture)
        {
            if (gesture.name == "scissors" || gesture.name == "lizard")
                return true;
            else
                return false;
        }
    }
}
