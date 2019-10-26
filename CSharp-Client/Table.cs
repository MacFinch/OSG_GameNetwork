using System;

namespace TicTacToe
{
    public class Table
    {

        public Player.Player playerX;
        public Player.Player playerO;
        public string[][] tableState = { new string[] { " ", " ", " " },
                                         new string[] { " ", " ", " " },
                                         new string[] { " ", " ", " " } };
        public int moveCount;
    



        public Table(Player.Player p1, Player.Player p2)
        {
            DecideOrder(p1, p2);
            moveCount = 0;
        }

        private void DecideOrder(Player.Player p1, Player.Player p2)
        {
            Random rdm = new Random();
            int x = rdm.Next(0, 2);
            if (x == 1)
            {
                playerX = p1;
                playerO = p2;
            }
            else if (x == 0)
            {
                playerX = p2;
                playerO = p1;
            }
        }
       
        public int AddMove(int w, int k)
            /*
             * Adding move to the table in row w and collumn k. Automatically checks who is to move.
             * Returns 1 for succes and -1 for error if the field is already occupied.
             */
        {
            if (tableState[w][k] == " ")
            {
                if (moveCount % 2 == 0)
                {
                    tableState[w][k] = "X";
                }
                else
                {
                    tableState[w][k] = "O";
                }

                moveCount++;
                return 1;
            }
            else
            {
              
                return -1;
            }
        }

        public bool Winner()
        {
            for (int x = 0; x < tableState.Length; x++)
            {
                if (tableState[x][0] == tableState[x][1] &&
                    tableState[x][1] == tableState[x][2] &&
                    tableState[x][0] != " ")
                {
                    return true;
                }
                if (tableState[0][x] == tableState[1][x] &&
                    tableState[1][x] == tableState[2][x] &&
                    tableState[0][x] != " ")
                {
                    return true;
                }
            }
            if (tableState[0][0] == tableState[1][1] &&
                tableState[1][1] == tableState[2][2] &&
                tableState[0][0] != " ")
            
            {
                return true;
            }
            if (tableState[0][2] == tableState[1][1] &&
                tableState[1][1] == tableState[2][0] &&
                tableState[0][2] != " ")
            {
                return true;
            }


            return false;
        }

        public bool Draw()
        {
            if(moveCount == 9)
            {
                return true;
            } else
            {
                return false;
            }
            
        }

        public Player.Player NextToPlay()
        {
            if (moveCount % 2 == 0)
            {
                return playerX;
            }
            else
            {
                return playerO;
            }
        }

        public Player.Player ThisPlayer()
        {
            if(NextToPlay() == playerX)
            {
                return playerO;
            }
            else
            {
                return playerX;
            }
        }



    }
}
