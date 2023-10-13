using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Gestures
{
    internal class Spock : Gesture
    {
        public Spock() => name = "spock";
        internal override bool WillBeat(Gesture gesture)
        {
            if (gesture.name == "rock" || gesture.name == "scissors")
                return true;
            else
                return false;
        }
    }
}
