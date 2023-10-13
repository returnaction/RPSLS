using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Gestures
{
    internal class Lizard : Gesture
    {
        public Lizard() => name = "lizard";
        
        internal override bool WillBeat(Gesture gesture)
        {
            if (gesture.name == "spock" || gesture.name == "paper")
                return true;
            else
                return false;
        }
    }
}
