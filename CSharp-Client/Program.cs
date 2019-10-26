using Player;
using System;
using TI;

namespace TicTacToe
{
    class Program
    {
        public static Player.Player player1;
        public static Player.Player player2;
        public static Table table;
        public static TerminalInterface display;


        static void Main(string[] args)
        {
            display = new TerminalInterface();

            ModeSelection();
            display.AddTable(table);



            while (true)
            {
                Player.Player nextPlayer = table.NextToPlay();

                display.GameState();
                while (true)
                {
                    int[] move = nextPlayer.MakeMove(table.tableState);
                    if (table.AddMove(move[0], move[1]) == -1)
                    {
                        display.InvalidMoveError();
                    }
                    else
                    {
                        break;
                    }
                }
                if (table.Winner())
                {
                    display.Winner();
                    break;
                }
                else if (table.Draw())
                {
                    display.Draw();
                    break;
                }

            }
        }

        static void ModeSelection()
        {
            display.Menu();
            while (true)
            {
                string mode = Console.ReadLine();
                if (mode == "1")
                {
                    player1 = new User(display);
                    player2 = new User(display);
                    break;
                }
                else if (mode == "2")
                {
                    player1 = new User(display);
                    player2 = new RandomAI();
                    break;
                }
                else
                {
                    display.ModeSelectionError();
                }

             }
             table = new Table(player1, player2);
        }






    }
}
