namespace NPC
{
    public class PlayTree
    {
        public enum Status { Lose, Draw, Win };

        public char[,] currGrid;            //current state of the grid
        public PlayTree[] nextMove;         //next possibles states of the grid
        public byte rowInsertion;           //indexes of the insertion from the previous bord to this one
        public byte columnInsertion;
        public Status state;                //the state of the game, if npc won, lose or it's draw
        public decimal moveValue;           //the value of the leaf of the playTree, win=1, lose=0, draw=0,5
        public decimal remnantTreeWinRate;  //percentage of winning taking this branch

        public PlayTree()
        {
            currGrid = new char[,] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            state = Status.Draw;
        }
    }
}
