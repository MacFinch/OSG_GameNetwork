namespace Player
{
    public abstract class Player
    {
        public string name;

        public abstract int[] MakeMove(string[][] gameState);

    }
}
