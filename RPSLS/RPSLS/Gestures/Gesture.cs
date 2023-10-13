using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Gestures
{
    internal abstract class Gesture
    {
        public string name;

        internal abstract bool WillBeat(Gesture gesture);
    }
}
