using System;
using TicTacToe;
namespace TI
{
    public class TerminalInterface
    {
        public static Table table;

        public void AddTable(Table t)
        {
            table = t;
        }

        public void GameState()
        {
            Console.Clear();
            PrintTableState();

            Console.WriteLine("Player {0} to move: ", table.NextToPlay().name);

        }

        public void Winner()
        {
            Console.Clear();
            PrintTableState();
            Console.WriteLine("Player {0} won the game. Press any key to finish.", table.ThisPlayer().name);
            Console.ReadLine();
        }
        public void Draw()
        {
            Console.Clear();
            PrintTableState();
            Console.WriteLine("We have draw. Press any key to finish.");
            Console.ReadLine();
        }


        private void PrintTableState()
        {
            Console.WriteLine("Player {0} is X, Player {1} is O", table.playerX.name, table.playerO.name);
            Console.WriteLine("__| 1 | 2 | 3 |");
            string[] row = { "A", "B", "C" };
            int r = 0;
            foreach (string[] x in table.tableState)
            {
                Console.WriteLine("{0} | {1} | {2} | {3} |", row[r], x[0], x[1], x[2]);
                r++;
            }
        }

        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the best TicTacToe game in the Universe!");
            Console.WriteLine("Please select the game mode.");
            Console.WriteLine("1. For local multyplayer.");
            Console.WriteLine("2. For cutting edge AI opponent.");
        }

        public void ModeSelectionError()
        {
            Console.Clear();
            Menu();
            Console.WriteLine("ERROR: Invalid format.");
            Console.WriteLine("Please enter single digit number coresponding with the game mode of choice.");
        }

        public void InvalidMoveError()
        {
            Console.Clear();
            GameState();
            Console.WriteLine("Invalid Move. Try again.");
        }

        public void InsertName()
        {
            Console.Clear();
            Menu();
            Console.Write("Insert Your name: ");
        }
    }
}
