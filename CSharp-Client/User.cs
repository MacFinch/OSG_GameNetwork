using System;
using TI;

namespace Player
{
    public class User : Player
    {
        public TerminalInterface display;

        public User(TerminalInterface d)
        {
            display = d;
            display.InsertName();
            name = Console.ReadLine();
        }

        public override int[] MakeMove(string[][] gameState)
        {
            int r;
            int k;

            while (true)
            {
                string move = Console.ReadLine();
                if (move.Length == 2)
                {
                    if      (move.ToLower().Contains("a")) { r = 0; }
                    else if (move.ToLower().Contains("b")) { r = 1; }
                    else if (move.ToLower().Contains("c")) { r = 2; }
                    else
                    {
                        display.InvalidMoveError();
                        continue;
                    }
                    if      (move.Contains("1")) { k = 0; }
                    else if (move.Contains("2")) { k = 1; }
                    else if (move.Contains("3")) { k = 2; }
                    else
                    {
                        display.InvalidMoveError();
                        continue;
                    }



                }
                else
                {
                    display.InvalidMoveError();
                    continue;
                }
                break;
            }


            return new int[] { r, k };
        }
    }
}
