using System;
using System.Collections.Generic;
using System.Text;

namespace AutoTris
{
    public class NPCMind
    {
        public enum Difficulties { LetWin = 0, Coward = 1, Easy = 2, Medium = 3, Hard = 4, Impossible = 5 };

        //fill the play tree with all the possible moves
        private static void FillPlayTree(PlayTree playTree, byte depth, char lastPlay = 'O'/*who played last*/)
        {
            if (depth == 0 || IsFull(playTree.currGrid))
                return;
            else
            {
                FillPlayTreeBranch(playTree, lastPlay == 'O' ? 'X' : 'O');
                for (int i = 0; i < playTree.nextMove.Length; i++)
                {
                    FillPlayTree(playTree.nextMove[i], (byte)(depth - (byte)1), lastPlay == 'O' ? 'X' : 'O');
                }
            }
        }

        private static void FillPlayTreeBranch(PlayTree playTreeBranch, char player/*X or O*/)
        {
            int emptyCellCount = 0;
            byte r = 0;
            byte c = 0;

            for (int i = 0; i < 3; i++)
                for (int t = 0; t < 3; t++)
                    if (playTreeBranch.currGrid[i, t] == ' ')
                        emptyCellCount++;       //counting disponble cells
            playTreeBranch.nextMove = new PlayTree[emptyCellCount];

            //initializing all new branches----------------------
            for (int i = 0; i < emptyCellCount; i++)
            {
                playTreeBranch.nextMove[i] = new PlayTree { currGrid = new char[3, 3] };
                for (int t = 0; t < 3; t++)
                {
                    for (int j = 0; j < 3; j++)
                        (playTreeBranch.nextMove[i]).currGrid[t, j] = playTreeBranch.currGrid[t, j];
                }
                while ((playTreeBranch.nextMove[i]).currGrid[r, c] != ' ')
                {
                    if (c < 2)
                        c++;
                    else
                    {
                        c = 0;
                        r++;
                    }
                }
                (playTreeBranch.nextMove[i]).currGrid[r, c] = player;
                playTreeBranch.nextMove[i].rowInsertion = r;
                playTreeBranch.nextMove[i].columnInsertion = c;

                if (c < 2)
                    c++;
                else
                {
                    c = 0;
                    r++;
                }
            }

        }

        //choose the NPC's next move and return the updated grid
        private static char[,] ChooseNextMove(PlayTree playTree, bool letWin = false)
        {
            Random choose = new Random();
            char[,] nextGrid = new char[3, 3];
            int[] possibilities;
            int index = 1;

            if (playTree.nextMove != null)
            {
                possibilities = new int[playTree.nextMove.Length];

                for (int i = 1; i < playTree.nextMove.Length; i++)
                {
                    if ((!letWin && playTree.nextMove[i].remnantTreeWinRate > playTree.nextMove[possibilities[0]].remnantTreeWinRate) || (letWin && playTree.nextMove[i].remnantTreeWinRate < playTree.nextMove[possibilities[0]].remnantTreeWinRate))
                    {
                        index = 0;
                        possibilities[index] = i;
                        index++;
                    }
                    else if (playTree.nextMove[i].remnantTreeWinRate == playTree.nextMove[possibilities[0]].remnantTreeWinRate)
                    {
                        possibilities[index] = i;
                        index++;
                    }
                }

                index = possibilities[choose.Next(index)];

                for (int r = 0; r < 3; r++)
                    for (int c = 0; c < 3; c++)
                        nextGrid[r, c] = playTree.nextMove[index].currGrid[r, c];
            }
            else
                nextGrid = playTree.currGrid;

            return nextGrid;
        }

        private static decimal EvaluateDrawStatus(PlayTree playTree)
        {
            char sign;
            decimal value = 0m;
            char[,] currGrid = playTree.currGrid;
            if (playTree.nextMove != null)
                return 0;
            else
            {
                if ((sign = currGrid[0, 0]) != ' ')  //up-left
                {
                    if (currGrid[0, 1] == currGrid[0, 0] && currGrid[0, 2] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[2, 0] == currGrid[0, 0] && currGrid[1, 0] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[1, 1] == currGrid[0, 0] && currGrid[2, 2] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[1, 0] == currGrid[0, 0] && currGrid[2, 0] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[0, 2] == currGrid[0, 0] && currGrid[0, 1] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[2, 2] == currGrid[0, 0] && currGrid[1, 1] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                }
                if ((sign = currGrid[0, 2]) != ' ')  //up-right
                {
                    if (currGrid[0, 1] == currGrid[0, 2] && currGrid[0, 0] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[1, 1] == currGrid[0, 2] && currGrid[2, 0] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[1, 2] == currGrid[0, 2] && currGrid[2, 2] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[2, 0] == currGrid[0, 2] && currGrid[1, 1] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[2, 2] == currGrid[0, 2] && currGrid[1, 2] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                }
                if ((sign = currGrid[2, 1]) != ' ')  //down-centre
                {
                    if (currGrid[0, 1] == currGrid[2, 1] && currGrid[1, 1] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[1, 1] == currGrid[2, 1] && currGrid[0, 1] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[2, 0] == currGrid[2, 1] && currGrid[2, 2] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[2, 2] == currGrid[2, 1] && currGrid[2, 0] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                }
                if ((sign = currGrid[1, 0]) != ' ')  //centre-left
                {
                    if (currGrid[1, 1] == currGrid[1, 0] && currGrid[1, 2] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[1, 2] == currGrid[1, 0] && currGrid[1, 1] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[2, 0] == currGrid[1, 0] && currGrid[0, 0] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                }
                if ((sign = currGrid[2, 2]) != ' ')  //down-right
                {
                    if (currGrid[1, 1] == currGrid[2, 2] && currGrid[0, 0] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[2, 0] == currGrid[2, 2] && currGrid[2, 1] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[1, 2] == currGrid[2, 2] && currGrid[0, 2] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                }
                if ((sign = currGrid[1, 1]) != ' ')  //centre-centre
                {
                    if (currGrid[0, 1] == currGrid[1, 1] && currGrid[2, 1] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                    if (currGrid[1, 2] == currGrid[1, 1] && currGrid[1, 0] == ' ')
                    {
                        value += (sign == 'X') ? 0.15m : -0.15m;
                    }
                }
            }
            if (value >= 1 || value <= -1)
            {
                value = value + 0m;
            }

            return value;
        }

        //go through the play tree, attributing to every leaf of the tree the state of the game
        private static void SetPlayTreeState(PlayTree playTree)
        {
            char winner = '/';

            if (GameIsOver(playTree.currGrid, out winner) || playTree.nextMove == null) //first checked gameIsOver to check if someone wins
            {
                switch (winner)
                {
                    case 'X':
                        playTree.state = PlayTree.Status.Win;
                        playTree.moveValue = playTree.remnantTreeWinRate = 1m;
                        break;
                    case 'O':
                        playTree.state = PlayTree.Status.Lose;
                        playTree.moveValue = playTree.remnantTreeWinRate = -1m;
                        break;
                    case '/':
                        playTree.state = PlayTree.Status.Draw;
                        playTree.moveValue = playTree.remnantTreeWinRate = EvaluateDrawStatus(playTree);
                        break;
                }
                playTree.nextMove = null;
            }
            else
            {
                for (int i = 0; i < playTree.nextMove.Length; i++)
                    SetPlayTreeState(playTree.nextMove[i]);
            }

            return;
        }

        //go thorugh the tree attributing to all non-leaf tree grids the respective
        //move's value
        private static decimal EvaluateCurrentGrid(PlayTree playTree)
        {
            if (playTree.nextMove == null)
                return playTree.moveValue;
            else
            {
                for (int i = 0; i < playTree.nextMove.Length; i++)
                {
                    playTree.remnantTreeWinRate += EvaluateCurrentGrid(playTree.nextMove[i]);
                }
                return playTree.remnantTreeWinRate /= playTree.nextMove.Length;
            }
        }

        private static bool IsFull(char[,] currentGrid)
        {
            for (int i = 0; i < 3; i++)
                for (int t = 0; t < 3; t++)
                    if (currentGrid[i, t] == ' ')
                        return false;

            return true;
        }

        public static void NPCNextMove(ref char[,] currentGrid, Difficulties difficulty)
        {
            PlayTree playTree = new PlayTree { currGrid = currentGrid };
            byte diff = 0;

            if (difficulty == Difficulties.Coward)
            {
                RandomMove(currentGrid);
            }
            else
            {
                switch (difficulty)
                {
                    case Difficulties.LetWin:
                        diff = (byte)9;
                        break;
                    case Difficulties.Easy:
                        diff = (byte)1;
                        break;
                    case Difficulties.Medium:
                        diff = (byte)3;
                        break;
                    case Difficulties.Hard:
                        diff = (byte)5;
                        break;
                    case Difficulties.Impossible:
                        diff = (byte)9;
                        break;
                }

                FillPlayTree(playTree, diff);
                SetPlayTreeState(playTree);
                EvaluateCurrentGrid(playTree);

                currentGrid = ChooseNextMove(playTree, (difficulty == Difficulties.LetWin));
            }
        }

        public static void RandomMove(char[,] currentGrid)
        {
            Random ran = new Random();
            int row, col;

            do
            {
                row = (ran.Next() % 3);
                col = (ran.Next() % 3);
            } while (currentGrid[row, col] != ' ');

            currentGrid[row, col] = 'X';
        }

        public static bool GameIsOver(char[,] currentGrid, out char winner/*'X' 'O' '/'*/)
        {
            bool isOver = false;

            if ((winner = currentGrid[1, 1]) != ' ')
            {
                if (currentGrid[1, 0] == currentGrid[1, 1])
                {
                    if (currentGrid[1, 2] == currentGrid[1, 1])
                        return isOver = true;
                }
                if (currentGrid[0, 0] == currentGrid[1, 1])
                {
                    if (currentGrid[2, 2] == currentGrid[1, 1])
                        return isOver = true;
                }
                if (currentGrid[0, 1] == currentGrid[1, 1])
                {
                    if (currentGrid[2, 1] == currentGrid[1, 1])
                        return isOver = true;
                }
                if (currentGrid[0, 2] == currentGrid[1, 1])
                {
                    if (currentGrid[2, 0] == currentGrid[1, 1])
                        return isOver = true;
                }
            }
            if ((winner = currentGrid[0, 0]) != ' ')
            {
                if (currentGrid[0, 1] == currentGrid[0, 0])
                {
                    if (currentGrid[0, 2] == currentGrid[0, 1])
                        return isOver = true;
                }
                if (currentGrid[1, 0] == currentGrid[0, 0])
                {
                    if (currentGrid[2, 0] == currentGrid[1, 0])
                        return isOver = true;
                }
            }
            if ((winner = currentGrid[2, 2]) != ' ')
            {
                if (currentGrid[2, 1] == currentGrid[2, 2])
                {
                    if (currentGrid[2, 0] == currentGrid[2, 1])
                        return isOver = true;
                }
                if (currentGrid[0, 2] == currentGrid[2, 2])
                {
                    if (currentGrid[1, 2] == currentGrid[0, 2])
                        return isOver = true;
                }
            }
            if (IsFull(currentGrid))
            {
                isOver = true;
            }

            winner = '/';

            return isOver;
        }
    }
}
