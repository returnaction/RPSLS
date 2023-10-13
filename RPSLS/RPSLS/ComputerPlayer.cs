using RPSLS.Gestures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer(string name) : base(name) { }

        public override void ChooseGesture()
        {
            chosenGesture = gestures[Randomizer.RandomNumber()];
        }
    }
}
