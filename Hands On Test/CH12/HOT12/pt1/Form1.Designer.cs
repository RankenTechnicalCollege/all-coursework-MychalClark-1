namespace pt1
{
    partial class PasswordCracker
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
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnCrack = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MD5 Hash";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(60, 75);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(455, 22);
            this.txtHash.TabIndex = 1;
            // 
            // btnCrack
            // 
            this.btnCrack.Location = new System.Drawing.Point(535, 74);
            this.btnCrack.Name = "btnCrack";
            this.btnCrack.Size = new System.Drawing.Size(75, 23);
            this.btnCrack.TabIndex = 2;
            this.btnCrack.Text = "Crack";
            this.btnCrack.UseVisualStyleBackColor = true;
            this.btnCrack.Click += new System.EventHandler(this.btnCrack_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(60, 104);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "*";
            // 
            // PasswordCracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 150);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCrack);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.label1);
            this.Name = "PasswordCracker";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnCrack;
        private System.Windows.Forms.Label lblResult;
    }
}

