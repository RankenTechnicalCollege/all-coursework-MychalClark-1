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
            this.label1 = new System.Windows.Forms.Label();
            this.gpaBox = new System.Windows.Forms.TextBox();
            this.testScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.rejectOr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA";
            // 
            // gpaBox
            // 
            this.gpaBox.Location = new System.Drawing.Point(92, 124);
            this.gpaBox.Name = "gpaBox";
            this.gpaBox.Size = new System.Drawing.Size(100, 22);
            this.gpaBox.TabIndex = 1;
            // 
            // testScore
            // 
            this.testScore.Location = new System.Drawing.Point(463, 124);
            this.testScore.Name = "testScore";
            this.testScore.Size = new System.Drawing.Size(100, 22);
            this.testScore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admission Test Score";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(92, 271);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // rejectOr
            // 
            this.rejectOr.AutoSize = true;
            this.rejectOr.Location = new System.Drawing.Point(192, 276);
            this.rejectOr.Name = "rejectOr";
            this.rejectOr.Size = new System.Drawing.Size(0, 17);
            this.rejectOr.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rejectOr);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.testScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpaBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "College Admiission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gpaBox;
        private System.Windows.Forms.TextBox testScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label rejectOr;
    }
}

