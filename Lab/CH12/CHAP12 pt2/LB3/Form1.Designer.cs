namespace LB3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(354, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblE);
            this.groupBox.Controls.Add(this.lblF);
            this.groupBox.Controls.Add(this.lblQ);
            this.groupBox.Controls.Add(this.lblRight);
            this.groupBox.Controls.Add(this.lblLeft);
            this.groupBox.Controls.Add(this.lblType);
            this.groupBox.Controls.Add(this.lblName);
            this.groupBox.Location = new System.Drawing.Point(13, 58);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(462, 347);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "groupBox1";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(13, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "*";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(7, 92);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(13, 17);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "*";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(7, 140);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(13, 17);
            this.lblLeft.TabIndex = 2;
            this.lblLeft.Text = "*";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(6, 157);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(13, 17);
            this.lblRight.TabIndex = 3;
            this.lblRight.Text = "*";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(6, 213);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(13, 17);
            this.lblQ.TabIndex = 4;
            this.lblQ.Text = "*";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(6, 230);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(13, 17);
            this.lblF.TabIndex = 5;
            this.lblF.Text = "*";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(7, 247);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(13, 17);
            this.lblE.TabIndex = 6;
            this.lblE.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
    }
}

