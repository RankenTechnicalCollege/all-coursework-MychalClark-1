namespace PT3
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
            this.label2 = new System.Windows.Forms.Label();
            this.LengthB = new System.Windows.Forms.TextBox();
            this.WidthB = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Label();
            this.Fee = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.Season = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length (ft)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Width(ft)";
            // 
            // LengthB
            // 
            this.LengthB.Location = new System.Drawing.Point(126, 73);
            this.LengthB.Name = "LengthB";
            this.LengthB.Size = new System.Drawing.Size(100, 22);
            this.LengthB.TabIndex = 2;
            // 
            // WidthB
            // 
            this.WidthB.Location = new System.Drawing.Point(431, 73);
            this.WidthB.Name = "WidthB";
            this.WidthB.Size = new System.Drawing.Size(100, 22);
            this.WidthB.TabIndex = 3;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(217, 126);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(237, 23);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Area
            // 
            this.Area.AutoSize = true;
            this.Area.Location = new System.Drawing.Point(214, 152);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(0, 17);
            this.Area.TabIndex = 5;
            // 
            // Fee
            // 
            this.Fee.AutoSize = true;
            this.Fee.Location = new System.Drawing.Point(214, 169);
            this.Fee.Name = "Fee";
            this.Fee.Size = new System.Drawing.Size(0, 17);
            this.Fee.TabIndex = 6;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(214, 203);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(0, 17);
            this.Total.TabIndex = 7;
            // 
            // Season
            // 
            this.Season.AutoSize = true;
            this.Season.Location = new System.Drawing.Point(214, 186);
            this.Season.Name = "Season";
            this.Season.Size = new System.Drawing.Size(0, 17);
            this.Season.TabIndex = 8;
            this.Season.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Season);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Fee);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.WidthB);
            this.Controls.Add(this.LengthB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Greg\'s Lawncare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LengthB;
        private System.Windows.Forms.TextBox WidthB;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label Fee;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label Season;
    }
}

