using System;
namespace Player
{
    public class RandomAI : Player
    {
        public RandomAI()
        {
            name = "RandomAI";
        }

        public override int[] MakeMove(string[][] gameState)
        {
        
            Random rdm = new Random();
            while (true)
            {
                int w = rdm.Next(0, 3);
                int k = rdm.Next(0, 3);
                if (gameState[w][k] == " ")
                {
                    return new int[2]{ w, k};
                }

            }
        }
    }
}
