namespace Piskvorky
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._cbGameMode = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._gameField = new Piskvorky.GameField();
            this._btnConfirmRounds = new System.Windows.Forms.Button();
            this._numRounds = new System.Windows.Forms.NumericUpDown();
            this._btnConfirmMode = new System.Windows.Forms.Button();
            this._btnConfirmNames = new System.Windows.Forms.Button();
            this._txtPlayer1 = new System.Windows.Forms.TextBox();
            this._txtPlayer0 = new System.Windows.Forms.TextBox();
            this._labelScore = new System.Windows.Forms.Label();
            this._labelPlayer0Char = new System.Windows.Forms.Label();
            this._labelPlayer1Char = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // _cbGameMode
            // 
            this._cbGameMode.FormattingEnabled = true;
            this._cbGameMode.Location = new System.Drawing.Point(3, 81);
            this._cbGameMode.Name = "_cbGameMode";
            this._cbGameMode.Size = new System.Drawing.Size(168, 24);
            this._cbGameMode.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._gameField);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._labelPlayer1Char);
            this.splitContainer1.Panel2.Controls.Add(this._labelPlayer0Char);
            this.splitContainer1.Panel2.Controls.Add(this._btnConfirmRounds);
            this.splitContainer1.Panel2.Controls.Add(this._numRounds);
            this.splitContainer1.Panel2.Controls.Add(this._btnConfirmMode);
            this.splitContainer1.Panel2.Controls.Add(this._btnConfirmNames);
            this.splitContainer1.Panel2.Controls.Add(this._txtPlayer1);
            this.splitContainer1.Panel2.Controls.Add(this._txtPlayer0);
            this.splitContainer1.Panel2.Controls.Add(this._labelScore);
            this.splitContainer1.Panel2.Controls.Add(this._cbGameMode);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 2;
            // 
            // _gameField
            // 
            this._gameField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gameField.GameSize = 7;
            this._gameField.Location = new System.Drawing.Point(0, 0);
            this._gameField.Name = "_gameField";
            this._gameField.Players = null;
            this._gameField.Size = new System.Drawing.Size(369, 450);
            this._gameField.TabIndex = 0;
            // 
            // _btnConfirmRounds
            // 
            this._btnConfirmRounds.Location = new System.Drawing.Point(131, 109);
            this._btnConfirmRounds.Name = "_btnConfirmRounds";
            this._btnConfirmRounds.Size = new System.Drawing.Size(184, 24);
            this._btnConfirmRounds.TabIndex = 8;
            this._btnConfirmRounds.Text = "Confirm number of rounds";
            this._btnConfirmRounds.UseVisualStyleBackColor = true;
            this._btnConfirmRounds.Click += new System.EventHandler(this._btnConfirmRounds_Click);
            // 
            // _numRounds
            // 
            this._numRounds.Location = new System.Drawing.Point(3, 111);
            this._numRounds.Name = "_numRounds";
            this._numRounds.Size = new System.Drawing.Size(122, 22);
            this._numRounds.TabIndex = 7;
            // 
            // _btnConfirmMode
            // 
            this._btnConfirmMode.Location = new System.Drawing.Point(177, 81);
            this._btnConfirmMode.Name = "_btnConfirmMode";
            this._btnConfirmMode.Size = new System.Drawing.Size(138, 24);
            this._btnConfirmMode.TabIndex = 6;
            this._btnConfirmMode.Text = "Confirm Mode";
            this._btnConfirmMode.UseVisualStyleBackColor = true;
            this._btnConfirmMode.Click += new System.EventHandler(this._btnConfirmMode_Click);
            // 
            // _btnConfirmNames
            // 
            this._btnConfirmNames.Location = new System.Drawing.Point(117, 51);
            this._btnConfirmNames.Name = "_btnConfirmNames";
            this._btnConfirmNames.Size = new System.Drawing.Size(133, 24);
            this._btnConfirmNames.TabIndex = 5;
            this._btnConfirmNames.Text = "Confirm Names";
            this._btnConfirmNames.UseVisualStyleBackColor = true;
            this._btnConfirmNames.Click += new System.EventHandler(this._btnConfirmNames_Click);
            // 
            // _txtPlayer1
            // 
            this._txtPlayer1.Location = new System.Drawing.Point(223, 12);
            this._txtPlayer1.Name = "_txtPlayer1";
            this._txtPlayer1.Size = new System.Drawing.Size(124, 22);
            this._txtPlayer1.TabIndex = 4;
            // 
            // _txtPlayer0
            // 
            this._txtPlayer0.Location = new System.Drawing.Point(3, 12);
            this._txtPlayer0.Name = "_txtPlayer0";
            this._txtPlayer0.Size = new System.Drawing.Size(138, 22);
            this._txtPlayer0.TabIndex = 3;
            // 
            // _labelScore
            // 
            this._labelScore.Location = new System.Drawing.Point(147, 12);
            this._labelScore.Name = "_labelScore";
            this._labelScore.Size = new System.Drawing.Size(70, 36);
            this._labelScore.TabIndex = 2;
            this._labelScore.Text = "label1";
            // 
            // _labelPlayer0Char
            // 
            this._labelPlayer0Char.Location = new System.Drawing.Point(3, 37);
            this._labelPlayer0Char.Name = "_labelPlayer0Char";
            this._labelPlayer0Char.Size = new System.Drawing.Size(41, 38);
            this._labelPlayer0Char.TabIndex = 9;
            this._labelPlayer0Char.Text = "label1";
            // 
            // _labelPlayer1Char
            // 
            this._labelPlayer1Char.Location = new System.Drawing.Point(316, 37);
            this._labelPlayer1Char.Name = "_labelPlayer1Char";
            this._labelPlayer1Char.Size = new System.Drawing.Size(31, 38);
            this._labelPlayer1Char.TabIndex = 10;
            this._labelPlayer1Char.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._numRounds)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label _labelPlayer0Char;
        private System.Windows.Forms.Label _labelPlayer1Char;

        private System.Windows.Forms.NumericUpDown _numRounds;
        private System.Windows.Forms.Button _btnConfirmRounds;

        private System.Windows.Forms.Button _btnConfirmNames;
        private System.Windows.Forms.Button _btnConfirmMode;

        private System.Windows.Forms.Label _labelScore;
        private System.Windows.Forms.TextBox _txtPlayer0;
        private System.Windows.Forms.TextBox _txtPlayer1;

        private Piskvorky.GameField _gameField;

        private System.Windows.Forms.SplitContainer splitContainer1;

        private System.Windows.Forms.ComboBox _cbGameMode;

        #endregion
    }
}