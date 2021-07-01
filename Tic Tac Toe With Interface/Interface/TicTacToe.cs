using System;
using System.Drawing;
using System.Windows.Forms;
using NPC;

namespace Interface
{
    public partial class TicTacToeWindow : Form
    {
        private enum GameStatuses { InProgress, Win, Lose, Draw};
        private char[,] currentGrid;
        private bool NPCMakeFirstMove;
        private bool isOneVsOne;
        private string playerTurn;
        private NPCMind.Difficulties difficulty;
        private GameStatuses gameStatus;

        public TicTacToeWindow()
        {
            InitializeComponent();
        }

        private void TrisWindow_Load(object sender, EventArgs e)
        {
            currentGrid = new char[,] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            gameStatus = GameStatuses.InProgress;
            isOneVsOne = false;
            playerTurn = "O";

            TICTACTOE.Show();
            ChooseGameDifficulty.Show();
            ILetYouWin.Show();
            Coward.Show();
            Easy.Show();
            Medium.Show();
            Hard.Show();
            Impossible.Show();
            OneVsOne.Show();

            TL.Text = TC.Text = TR.Text = CL.Text = CC.Text = CR.Text = BL.Text = BC.Text = BR.Text = " ";
            TL.Hide();
            TC.Hide();
            TR.Hide();
            CL.Hide();
            CC.Hide();
            CR.Hide();
            BL.Hide();
            BC.Hide();
            BR.Hide();
            GameOutcome.Hide();
            ChangeDifficulty.Hide();
            StartNewGame.Hide();
        }
        #region FirstScreenManagement
        private void ILetYouWin_Click(object sender, EventArgs e)
        {
            difficulty = NPCMind.Difficulties.LetWin;
            DecideFirstMove();
        }

        private void Coward_Click(object sender, EventArgs e)
        {
            difficulty = NPCMind.Difficulties.Coward;
            DecideFirstMove();
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            difficulty = NPCMind.Difficulties.Easy;
            DecideFirstMove();
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            difficulty = NPCMind.Difficulties.Medium;
            DecideFirstMove();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            difficulty = NPCMind.Difficulties.Hard;
            DecideFirstMove();
        }

        private void Impossible_Click(object sender, EventArgs e)
        {
            difficulty = NPCMind.Difficulties.Impossible;
            HideFirstScreen();
            NPCTurn();
        }
        #endregion

        #region EnterGrid
        private void TL_MouseEnter(object sender, EventArgs e)
        {
            EnterLabelOfGrid(TL, playerTurn);
        }

        private void TC_MouseEnter(object sender, EventArgs e)
        {
            EnterLabelOfGrid(TC, playerTurn);
        }

        private void TR_MouseEnter(object sender, EventArgs e)
        {
            EnterLabelOfGrid(TR, playerTurn);
        }

        private void CL_MouseEnter(object sender, EventArgs e)
        {
            if((sender as Label).Name=="CL")
            {
                _ = 1;
            }
            EnterLabelOfGrid(CL, playerTurn);
        }

        private void CC_MouseEnter(object sender, EventArgs e)
        {
            EnterLabelOfGrid(CC, playerTurn);
        }

        private void CR_MouseEnter(object sender, EventArgs e)
        {
            EnterLabelOfGrid(CR, playerTurn);
        }

        private void BL_MouseEnter(object sender, EventArgs e)
        {
            EnterLabelOfGrid(BL, playerTurn);
        }

        private void BC_MouseEnter(object sender, EventArgs e)
        {
            EnterLabelOfGrid(BC, playerTurn);
        }

        private void BR_MouseEnter(object sender, EventArgs e)
        {
            EnterLabelOfGrid(BR, playerTurn);
        }
        #endregion

        #region LeaveGrid
        private void TL_MouseLeave(object sender, EventArgs e)
        {
            LeaveLabelOfGrid(TL);
        }

        private void TC_MouseLeave(object sender, EventArgs e)
        {
            LeaveLabelOfGrid(TC);
        }

        private void TR_MouseLeave(object sender, EventArgs e)
        {
            LeaveLabelOfGrid(TR);
        }

        private void CL_MouseLeave(object sender, EventArgs e)
        {
            LeaveLabelOfGrid(CL);
        }

        private void CC_MouseLeave(object sender, EventArgs e)
        {
            LeaveLabelOfGrid(CC);
        }

        private void CR_MouseLeave(object sender, EventArgs e)
        {
            LeaveLabelOfGrid(CR);
        }

        private void BL_MouseLeave(object sender, EventArgs e)
        {
            LeaveLabelOfGrid(BL);
        }

        private void BC_MouseLeave(object sender, EventArgs e)
        {
            LeaveLabelOfGrid(BC);
        }

        private void BR_MouseLeave(object sender, EventArgs e)
        {
            LeaveLabelOfGrid(BR);
        }
        #endregion

        #region MouseClickes
        private void TL_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnLabelOfTheGrid(TL,playerTurn);
        }

        private void TC_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnLabelOfTheGrid(TC, playerTurn);
        }

        private void TR_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnLabelOfTheGrid(TR, playerTurn);
        }

        private void CL_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnLabelOfTheGrid(CL, playerTurn);
        }

        private void CC_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnLabelOfTheGrid(CC, playerTurn);
        }

        private void CR_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnLabelOfTheGrid(CR, playerTurn);
        }

        private void BL_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnLabelOfTheGrid(BL, playerTurn);
        }

        private void BC_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnLabelOfTheGrid(BC, playerTurn);
        }

        private void BR_MouseClick(object sender, MouseEventArgs e)
        {
            ClickOnLabelOfTheGrid(BR, playerTurn);
        }
        private void ChangeDifficulty_Click(object sender, EventArgs e)
        {
            TrisWindow_Load(null, null);
        }

        private void StartNewGame_Click(object sender, EventArgs e)
        {
            LoadANewGame();
        }
        #endregion

        #region MyMethods
        private void LoadANewGame()
        {
            currentGrid = new char[,] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            gameStatus = GameStatuses.InProgress;

            TL.Text = TC.Text = TR.Text = CL.Text = CC.Text = CR.Text = BL.Text = BC.Text = BR.Text = " ";

            if (isOneVsOne)
            {
                playerTurn = "X";
                GameOutcome.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                GameOutcome.ForeColor = Color.Black;
                //GameOutcome.Show();
                ShowPlayerTurn();
            }
            else
            {            
                GameOutcome.Hide();
                if (NPCMakeFirstMove)
                {
                    NPCTurn();
                }
            }
        }

        private void DecideFirstMove()
        {
            DialogResult answer = MessageBox.Show("Do you want to make the first move?",
                "Who moves?", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            HideFirstScreen();

            if (NPCMakeFirstMove = (answer == DialogResult.No))
            {
                NPCTurn();
            }
        }

        private void NPCTurn()
        {
            if (gameStatus == GameStatuses.InProgress)
            {
                char[,] oldGrid = new char[3, 3];
                Array.Copy(currentGrid, oldGrid, 9);
                NPCMind.NPCNextMove(ref currentGrid, difficulty);
                Label label = GetLabelFromNum(CheckEffectuatedMove(oldGrid, currentGrid));
                label.Font = this.TL.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point);
                label.ForeColor = Color.Black;
                label.Text = "X";
                CheckGameStatus();
            }
        }

        private (int,int) CheckEffectuatedMove(char[,] oldGrid,char[,] newGrid)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int t = 0; t < 3; t++)
                {
                    if (oldGrid[i,t]!=newGrid[i,t])
                    {
                        return (i, t);
                    }
                }
            }
            throw new ApplicationException("Seems that NPC didn't make any move");
        }

        private void CheckGameStatus()
        {
            if (NPCMind.GameIsOver(currentGrid, out char winner))
            {
                GameOutcome.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                switch (winner)
                {
                    case '/':
                        gameStatus = GameStatuses.Draw;
                        GameOutcome.ForeColor = Color.Gray;
                        GameOutcome.Text = "Draw";
                        GameOutcome.Show();
                        break;
                    case 'X':
                        gameStatus = GameStatuses.Lose;
                        GameOutcome.ForeColor = isOneVsOne ? Color.Green : Color.Red;
                        GameOutcome.Text = isOneVsOne ? $"Player X wins!" : "You loose!";
                        GameOutcome.Show();
                        break;
                    case 'O':
                        gameStatus = GameStatuses.Win;
                        GameOutcome.ForeColor = Color.Green;
                        GameOutcome.Text = isOneVsOne ? $"Player O wins!" : "You win!";
                        GameOutcome.Show();
                        break;
                    default:
                        throw new ApplicationException($"Unexpected result of the game, declared winner: \"{winner}\"");
                }
            }
            else
            {
                gameStatus = GameStatuses.InProgress;
            }
        }

        private void HideFirstScreen()
        {
            TICTACTOE.Hide();
            ChooseGameDifficulty.Hide();
            ILetYouWin.Hide();
            Coward.Hide();
            Easy.Hide();
            Medium.Hide();
            Hard.Hide();
            Impossible.Hide();
            OneVsOne.Hide();

            TL.Show();
            TC.Show();
            TR.Show();
            CL.Show();
            CC.Show();
            CR.Show();
            BL.Show();
            BC.Show();
            BR.Show();
            ChangeDifficulty.Show();
            StartNewGame.Show();
        }

        private void EnterLabelOfGrid(Label caller, string player)
        {
            if (gameStatus == GameStatuses.InProgress)
            {
                (int, int) index = GetNumFromLabel(caller);
                if (currentGrid[index.Item1, index.Item2] == ' ')
                {
                    caller.Font = this.TL.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point);
                    caller.ForeColor = Color.LightGray;
                    caller.Text = player;
                }
            }
        }

        private void LeaveLabelOfGrid(Label caller)
        {
            if (gameStatus == GameStatuses.InProgress)
            {
                (int, int) index = GetNumFromLabel(caller);
                if (currentGrid[index.Item1, index.Item2] == ' ')
                {
                    caller.Text = " ";
                }
            }
        }

        private void ClickOnLabelOfTheGrid(Label caller, string player)
        {
            if (gameStatus == GameStatuses.InProgress)
            {
                (int, int) index = GetNumFromLabel(caller);
                if (currentGrid[index.Item1, index.Item2] == ' ')
                {
                    caller.Font = this.TL.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point);
                    caller.ForeColor = Color.Black;
                    caller.Text = player;
                    currentGrid[index.Item1, index.Item2] = player[0];
                    CheckGameStatus();
                    if (!isOneVsOne)
                    {
                        NPCTurn();
                    }
                    else
                    {
                        if (gameStatus == GameStatuses.InProgress)
                        {
                            playerTurn = playerTurn == "X" ? "O" : "X";
                            ShowPlayerTurn();
                        }
                    }
                }
            }
        }

        private (int,int) GetNumFromLabel(Label LName)
        {
            if (LName == TL)
                return (0, 0);
            else if (LName == TC)
                return (0, 1);
            else if (LName == TR)
                return (0, 2);
            else if (LName == CL)
                return (1, 0);
            else if (LName == CC)
                return (1, 1);
            else if (LName == CR)
                return (1, 2);
            else if (LName == BL)
                return (2, 0);
            else if (LName == BC)
                return (2, 1);
            else  //(TBName == BR)
                return (2, 2);
        }
        private Label GetLabelFromNum((int, int) Number)
        {
            if (Number == (0, 0))
                return TL;
            else if (Number == (0, 1))
                return TC;
            else if (Number == (0, 2))
                return TR;
            else if (Number == (1, 0))
                return CL;
            else if (Number == (1, 1))
                return CC;
            else if (Number == (1, 2))
                return CR;
            else if (Number == (2, 0))
                return BL;
            else if (Number == (2, 1))
                return BC;
            else  //(TBName == (2, 2))
                return BR;
        }
        #endregion

        #region OneVsOne
        private void OneVsOne_Click(object sender, EventArgs e)
        {
            HideFirstScreen();
            isOneVsOne = true;
            playerTurn = "X";
            GameOutcome.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            GameOutcome.ForeColor = Color.Black;
            GameOutcome.Show();
            ShowPlayerTurn();
        }

        private void ShowPlayerTurn()
        {
            GameOutcome.Text = $"Player {playerTurn} turn";
        }

        #endregion
    }
}
