
namespace Interface
{
    partial class TicTacToeWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeWindow));
            this.ILetYouWin = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.Easy = new System.Windows.Forms.Button();
            this.Coward = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.TICTACTOE = new System.Windows.Forms.Label();
            this.ChooseGameDifficulty = new System.Windows.Forms.Label();
            this.Impossible = new System.Windows.Forms.Button();
            this.TL = new System.Windows.Forms.Label();
            this.TC = new System.Windows.Forms.Label();
            this.TR = new System.Windows.Forms.Label();
            this.CL = new System.Windows.Forms.Label();
            this.CC = new System.Windows.Forms.Label();
            this.CR = new System.Windows.Forms.Label();
            this.BL = new System.Windows.Forms.Label();
            this.BC = new System.Windows.Forms.Label();
            this.BR = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.Panel();
            this.ChangeDifficulty = new System.Windows.Forms.Button();
            this.GameOutcome = new System.Windows.Forms.Label();
            this.StartNewGame = new System.Windows.Forms.Button();
            this.OneVsOne = new System.Windows.Forms.Button();
            this.Grid.SuspendLayout();
            this.SuspendLayout();
            // 
            // ILetYouWin
            // 
            this.ILetYouWin.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ILetYouWin.Location = new System.Drawing.Point(375, 193);
            this.ILetYouWin.Name = "ILetYouWin";
            this.ILetYouWin.Size = new System.Drawing.Size(250, 29);
            this.ILetYouWin.TabIndex = 1;
            this.ILetYouWin.Text = "I let you win";
            this.ILetYouWin.UseVisualStyleBackColor = true;
            this.ILetYouWin.Click += new System.EventHandler(this.ILetYouWin_Click);
            // 
            // Medium
            // 
            this.Medium.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Medium.Location = new System.Drawing.Point(375, 322);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(250, 29);
            this.Medium.TabIndex = 4;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.Click += new System.EventHandler(this.Medium_Click);
            // 
            // Easy
            // 
            this.Easy.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Easy.Location = new System.Drawing.Point(375, 279);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(250, 29);
            this.Easy.TabIndex = 3;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Coward
            // 
            this.Coward.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Coward.Location = new System.Drawing.Point(375, 236);
            this.Coward.Name = "Coward";
            this.Coward.Size = new System.Drawing.Size(250, 29);
            this.Coward.TabIndex = 2;
            this.Coward.Text = "Coward";
            this.Coward.UseVisualStyleBackColor = true;
            this.Coward.Click += new System.EventHandler(this.Coward_Click);
            // 
            // Hard
            // 
            this.Hard.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hard.Location = new System.Drawing.Point(375, 365);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(250, 29);
            this.Hard.TabIndex = 5;
            this.Hard.Text = "Hard";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.Click += new System.EventHandler(this.Hard_Click);
            // 
            // TICTACTOE
            // 
            this.TICTACTOE.AutoSize = true;
            this.TICTACTOE.BackColor = System.Drawing.Color.Transparent;
            this.TICTACTOE.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TICTACTOE.ForeColor = System.Drawing.Color.DarkRed;
            this.TICTACTOE.Location = new System.Drawing.Point(342, 27);
            this.TICTACTOE.Name = "TICTACTOE";
            this.TICTACTOE.Size = new System.Drawing.Size(316, 62);
            this.TICTACTOE.TabIndex = 6;
            this.TICTACTOE.Text = "TIC TAC TOE";
            this.TICTACTOE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChooseGameDifficulty
            // 
            this.ChooseGameDifficulty.AutoSize = true;
            this.ChooseGameDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.ChooseGameDifficulty.Font = new System.Drawing.Font("Verdana Pro Cond", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseGameDifficulty.Location = new System.Drawing.Point(371, 139);
            this.ChooseGameDifficulty.Name = "ChooseGameDifficulty";
            this.ChooseGameDifficulty.Size = new System.Drawing.Size(259, 31);
            this.ChooseGameDifficulty.TabIndex = 7;
            this.ChooseGameDifficulty.Text = "Choose game difficulty";
            // 
            // Impossible
            // 
            this.Impossible.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Impossible.Location = new System.Drawing.Point(375, 408);
            this.Impossible.Name = "Impossible";
            this.Impossible.Size = new System.Drawing.Size(250, 29);
            this.Impossible.TabIndex = 6;
            this.Impossible.Text = "(litterally) Impossible";
            this.Impossible.UseVisualStyleBackColor = true;
            this.Impossible.Click += new System.EventHandler(this.Impossible_Click);
            // 
            // TL
            // 
            this.TL.BackColor = System.Drawing.SystemColors.Control;
            this.TL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TL.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TL.Location = new System.Drawing.Point(34, 33);
            this.TL.Name = "TL";
            this.TL.Size = new System.Drawing.Size(80, 80);
            this.TL.TabIndex = 16;
            this.TL.Text = " ";
            this.TL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TL_MouseClick);
            this.TL.MouseEnter += new System.EventHandler(this.TL_MouseEnter);
            this.TL.MouseLeave += new System.EventHandler(this.TL_MouseLeave);
            // 
            // TC
            // 
            this.TC.BackColor = System.Drawing.SystemColors.Control;
            this.TC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TC.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TC.Location = new System.Drawing.Point(115, 33);
            this.TC.Name = "TC";
            this.TC.Size = new System.Drawing.Size(80, 80);
            this.TC.TabIndex = 16;
            this.TC.Text = " ";
            this.TC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TC_MouseClick);
            this.TC.MouseEnter += new System.EventHandler(this.TC_MouseEnter);
            this.TC.MouseLeave += new System.EventHandler(this.TC_MouseLeave);
            // 
            // TR
            // 
            this.TR.BackColor = System.Drawing.SystemColors.Control;
            this.TR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TR.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TR.Location = new System.Drawing.Point(196, 33);
            this.TR.Name = "TR";
            this.TR.Size = new System.Drawing.Size(80, 80);
            this.TR.TabIndex = 16;
            this.TR.Text = " ";
            this.TR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TR_MouseClick);
            this.TR.MouseEnter += new System.EventHandler(this.TR_MouseEnter);
            this.TR.MouseLeave += new System.EventHandler(this.TR_MouseLeave);
            // 
            // CL
            // 
            this.CL.BackColor = System.Drawing.SystemColors.Control;
            this.CL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CL.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CL.Location = new System.Drawing.Point(34, 114);
            this.CL.Name = "CL";
            this.CL.Size = new System.Drawing.Size(80, 80);
            this.CL.TabIndex = 16;
            this.CL.Text = " ";
            this.CL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CL_MouseClick);
            this.CL.MouseEnter += new System.EventHandler(this.CL_MouseEnter);
            this.CL.MouseLeave += new System.EventHandler(this.CL_MouseLeave);
            // 
            // CC
            // 
            this.CC.BackColor = System.Drawing.SystemColors.Control;
            this.CC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CC.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CC.Location = new System.Drawing.Point(115, 114);
            this.CC.Name = "CC";
            this.CC.Size = new System.Drawing.Size(80, 80);
            this.CC.TabIndex = 16;
            this.CC.Text = " ";
            this.CC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CC_MouseClick);
            this.CC.MouseEnter += new System.EventHandler(this.CC_MouseEnter);
            this.CC.MouseLeave += new System.EventHandler(this.CC_MouseLeave);
            // 
            // CR
            // 
            this.CR.BackColor = System.Drawing.SystemColors.Control;
            this.CR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CR.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CR.Location = new System.Drawing.Point(196, 114);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(80, 80);
            this.CR.TabIndex = 16;
            this.CR.Text = " ";
            this.CR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CR_MouseClick);
            this.CR.MouseEnter += new System.EventHandler(this.CR_MouseEnter);
            this.CR.MouseLeave += new System.EventHandler(this.CR_MouseLeave);
            // 
            // BL
            // 
            this.BL.BackColor = System.Drawing.SystemColors.Control;
            this.BL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BL.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BL.Location = new System.Drawing.Point(34, 195);
            this.BL.Name = "BL";
            this.BL.Size = new System.Drawing.Size(80, 80);
            this.BL.TabIndex = 16;
            this.BL.Text = " ";
            this.BL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BL_MouseClick);
            this.BL.MouseEnter += new System.EventHandler(this.BL_MouseEnter);
            this.BL.MouseLeave += new System.EventHandler(this.BL_MouseLeave);
            // 
            // BC
            // 
            this.BC.BackColor = System.Drawing.SystemColors.Control;
            this.BC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BC.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BC.Location = new System.Drawing.Point(115, 195);
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(80, 80);
            this.BC.TabIndex = 16;
            this.BC.Text = " ";
            this.BC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BC_MouseClick);
            this.BC.MouseEnter += new System.EventHandler(this.BC_MouseEnter);
            this.BC.MouseLeave += new System.EventHandler(this.BC_MouseLeave);
            // 
            // BR
            // 
            this.BR.BackColor = System.Drawing.SystemColors.Control;
            this.BR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BR.Font = new System.Drawing.Font("Arial Nova", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BR.Location = new System.Drawing.Point(196, 195);
            this.BR.Name = "BR";
            this.BR.Size = new System.Drawing.Size(80, 80);
            this.BR.TabIndex = 16;
            this.BR.Text = " ";
            this.BR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BR.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BR_MouseClick);
            this.BR.MouseEnter += new System.EventHandler(this.BR_MouseEnter);
            this.BR.MouseLeave += new System.EventHandler(this.BR_MouseLeave);
            // 
            // Grid
            // 
            this.Grid.Controls.Add(this.TL);
            this.Grid.Controls.Add(this.TR);
            this.Grid.Controls.Add(this.BC);
            this.Grid.Controls.Add(this.TC);
            this.Grid.Controls.Add(this.BR);
            this.Grid.Controls.Add(this.CL);
            this.Grid.Controls.Add(this.BL);
            this.Grid.Controls.Add(this.CR);
            this.Grid.Controls.Add(this.CC);
            this.Grid.Location = new System.Drawing.Point(157, 65);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(325, 320);
            this.Grid.TabIndex = 17;
            // 
            // ChangeDifficulty
            // 
            this.ChangeDifficulty.Location = new System.Drawing.Point(528, 311);
            this.ChangeDifficulty.Name = "ChangeDifficulty";
            this.ChangeDifficulty.Size = new System.Drawing.Size(198, 29);
            this.ChangeDifficulty.TabIndex = 18;
            this.ChangeDifficulty.Text = "Change difficulty";
            this.ChangeDifficulty.UseVisualStyleBackColor = true;
            this.ChangeDifficulty.Click += new System.EventHandler(this.ChangeDifficulty_Click);
            // 
            // GameOutcome
            // 
            this.GameOutcome.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GameOutcome.Location = new System.Drawing.Point(528, 194);
            this.GameOutcome.Name = "GameOutcome";
            this.GameOutcome.Size = new System.Drawing.Size(401, 41);
            this.GameOutcome.TabIndex = 19;
            this.GameOutcome.Text = "player X turn";
            this.GameOutcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartNewGame
            // 
            this.StartNewGame.Location = new System.Drawing.Point(745, 311);
            this.StartNewGame.Name = "StartNewGame";
            this.StartNewGame.Size = new System.Drawing.Size(198, 29);
            this.StartNewGame.TabIndex = 20;
            this.StartNewGame.Text = "Start new game";
            this.StartNewGame.UseVisualStyleBackColor = true;
            this.StartNewGame.Click += new System.EventHandler(this.StartNewGame_Click);
            // 
            // OneVsOne
            // 
            this.OneVsOne.Font = new System.Drawing.Font("Verdana Pro Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OneVsOne.Location = new System.Drawing.Point(686, 193);
            this.OneVsOne.Name = "OneVsOne";
            this.OneVsOne.Size = new System.Drawing.Size(250, 29);
            this.OneVsOne.TabIndex = 21;
            this.OneVsOne.Text = "1 vs 1";
            this.OneVsOne.UseVisualStyleBackColor = true;
            this.OneVsOne.Click += new System.EventHandler(this.OneVsOne_Click);
            // 
            // TicTacToeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.OneVsOne);
            this.Controls.Add(this.StartNewGame);
            this.Controls.Add(this.GameOutcome);
            this.Controls.Add(this.ChangeDifficulty);
            this.Controls.Add(this.Impossible);
            this.Controls.Add(this.ChooseGameDifficulty);
            this.Controls.Add(this.TICTACTOE);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Coward);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.ILetYouWin);
            this.Controls.Add(this.Grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToeWindow";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.TrisWindow_Load);
            this.Grid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ILetYouWin;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Coward;
        private System.Windows.Forms.Button Hard;
        private System.Windows.Forms.Label TICTACTOE;
        private System.Windows.Forms.Label ChooseGameDifficulty;
        private System.Windows.Forms.Button Impossible;
        private System.Windows.Forms.Label TL;
        private System.Windows.Forms.Label TC;
        private System.Windows.Forms.Label TR;
        private System.Windows.Forms.Label CL;
        private System.Windows.Forms.Label CC;
        private System.Windows.Forms.Label CR;
        private System.Windows.Forms.Label BL;
        private System.Windows.Forms.Label BC;
        private System.Windows.Forms.Label BR;
        private System.Windows.Forms.Panel Grid;
        private System.Windows.Forms.Button ChangeDifficulty;
        private System.Windows.Forms.Label GameOutcome;
        private System.Windows.Forms.Button StartNewGame;
        private System.Windows.Forms.Button OneVsOne;
    }
}

