namespace LB5
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
            this.Rock = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.Siccors = new System.Windows.Forms.Button();
            this.AiPick = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AiScore = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.Winner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rock
            // 
            this.Rock.Location = new System.Drawing.Point(136, 77);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(75, 23);
            this.Rock.TabIndex = 0;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = true;
            this.Rock.Click += new System.EventHandler(this.Rock_Click);
            // 
            // Paper
            // 
            this.Paper.Location = new System.Drawing.Point(325, 77);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(75, 23);
            this.Paper.TabIndex = 1;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = true;
            this.Paper.Click += new System.EventHandler(this.Paper_Click);
            // 
            // Siccors
            // 
            this.Siccors.Location = new System.Drawing.Point(518, 77);
            this.Siccors.Name = "Siccors";
            this.Siccors.Size = new System.Drawing.Size(75, 23);
            this.Siccors.TabIndex = 2;
            this.Siccors.Text = "Siccors";
            this.Siccors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Siccors.UseVisualStyleBackColor = true;
            this.Siccors.Click += new System.EventHandler(this.Siccors_Click);
            // 
            // AiPick
            // 
            this.AiPick.AutoSize = true;
            this.AiPick.Location = new System.Drawing.Point(136, 127);
            this.AiPick.Name = "AiPick";
            this.AiPick.Size = new System.Drawing.Size(0, 17);
            this.AiPick.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player 1 Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Computer Score:";
            // 
            // AiScore
            // 
            this.AiScore.AutoSize = true;
            this.AiScore.Location = new System.Drawing.Point(623, 196);
            this.AiScore.Name = "AiScore";
            this.AiScore.Size = new System.Drawing.Size(16, 17);
            this.AiScore.TabIndex = 6;
            this.AiScore.Text = "0";
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Location = new System.Drawing.Point(234, 196);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(16, 17);
            this.PlayerScore.TabIndex = 7;
            this.PlayerScore.Text = "0";
            // 
            // Winner
            // 
            this.Winner.AutoSize = true;
            this.Winner.Location = new System.Drawing.Point(139, 274);
            this.Winner.Name = "Winner";
            this.Winner.Size = new System.Drawing.Size(0, 17);
            this.Winner.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Winner);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.AiScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AiPick);
            this.Controls.Add(this.Siccors);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Button Siccors;
        private System.Windows.Forms.Label AiPick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AiScore;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label Winner;
    }
}

