using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) { }

        public override void ChooseGesture()
        {
            Console.WriteLine($"\n{name}, choose a gesture: ");

            while (true)
            {
                for (int i = 0; i < gestures.Count; i++)
                {
                    Console.WriteLine($"Press: {i+1} for {gestures[i].name}");
                }

                string userUnput = Console.ReadLine();

                if (userUnput == "1")
                {
                    chosenGesture = gestures[0];
                    break;
                }
                else if (userUnput == "2")
                {
                    chosenGesture = gestures[1];
                    break;
                }
                else if (userUnput == "3")
                {
                    chosenGesture = gestures[2];
                    break;
                }
                else if (userUnput == "4")
                {
                    chosenGesture = gestures[3];
                    break;
                }
                else if (userUnput == "5")
                {
                    chosenGesture = gestures[4];
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input, try again");
                }
            }
        }
    }
}
