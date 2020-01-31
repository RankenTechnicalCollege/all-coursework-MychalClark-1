namespace LB6
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
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.Button();
            this.Nscores = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.Label();
            this.Lowest = new System.Windows.Forms.Label();
            this.Highest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter A Test Score Or enter 999 to show results";
            // 
            // Score
            // 
            this.Score.Location = new System.Drawing.Point(15, 82);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(100, 22);
            this.Score.TabIndex = 1;
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(15, 121);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(75, 23);
            this.r.TabIndex = 2;
            this.r.Text = "Enter";
            this.r.UseVisualStyleBackColor = true;
            this.r.Click += new System.EventHandler(this.r_Click);
            // 
            // Nscores
            // 
            this.Nscores.AutoSize = true;
            this.Nscores.Location = new System.Drawing.Point(15, 151);
            this.Nscores.Name = "Nscores";
            this.Nscores.Size = new System.Drawing.Size(0, 17);
            this.Nscores.TabIndex = 3;
            this.Nscores.Click += new System.EventHandler(this.Nscores_Click);
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Location = new System.Drawing.Point(15, 177);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(0, 17);
            this.Sum.TabIndex = 4;
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Location = new System.Drawing.Point(15, 204);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(0, 17);
            this.Average.TabIndex = 5;
            this.Average.Click += new System.EventHandler(this.Average_Click);
            // 
            // Lowest
            // 
            this.Lowest.AutoSize = true;
            this.Lowest.Location = new System.Drawing.Point(15, 231);
            this.Lowest.Name = "Lowest";
            this.Lowest.Size = new System.Drawing.Size(0, 17);
            this.Lowest.TabIndex = 6;
            // 
            // Highest
            // 
            this.Highest.AutoSize = true;
            this.Highest.Location = new System.Drawing.Point(15, 259);
            this.Highest.Name = "Highest";
            this.Highest.Size = new System.Drawing.Size(0, 17);
            this.Highest.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Highest);
            this.Controls.Add(this.Lowest);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.Nscores);
            this.Controls.Add(this.r);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.Button r;
        private System.Windows.Forms.Label Nscores;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.Label Lowest;
        private System.Windows.Forms.Label Highest;
    }
}

