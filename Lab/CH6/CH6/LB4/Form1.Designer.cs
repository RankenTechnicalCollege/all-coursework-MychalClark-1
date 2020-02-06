namespace LB4
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblFortune1 = new System.Windows.Forms.Label();
            this.lblFortune2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(427, 144);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblFortune1
            // 
            this.lblFortune1.AutoSize = true;
            this.lblFortune1.Location = new System.Drawing.Point(12, 202);
            this.lblFortune1.Name = "lblFortune1";
            this.lblFortune1.Size = new System.Drawing.Size(0, 17);
            this.lblFortune1.TabIndex = 1;
            // 
            // lblFortune2
            // 
            this.lblFortune2.AutoSize = true;
            this.lblFortune2.Location = new System.Drawing.Point(12, 238);
            this.lblFortune2.Name = "lblFortune2";
            this.lblFortune2.Size = new System.Drawing.Size(0, 17);
            this.lblFortune2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFortune2);
            this.Controls.Add(this.lblFortune1);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblFortune1;
        private System.Windows.Forms.Label lblFortune2;
    }
}

