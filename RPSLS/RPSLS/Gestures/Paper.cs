using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Gestures
{
    internal class Paper : Gesture
    {
        public Paper() => name = "paper";

        internal override bool WillBeat(Gesture gesture)
        {
            if (gesture.name == "rock" || gesture.name == "spock")
                return true;
            else
                return false;
        }
    }
}
