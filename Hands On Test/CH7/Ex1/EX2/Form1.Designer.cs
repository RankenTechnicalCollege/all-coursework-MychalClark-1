namespace EX2
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
            this.btnArit = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnCast = new System.Windows.Forms.Button();
            this.Null = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtCast = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnArit
            // 
            this.btnArit.Location = new System.Drawing.Point(38, 48);
            this.btnArit.Name = "btnArit";
            this.btnArit.Size = new System.Drawing.Size(241, 23);
            this.btnArit.TabIndex = 0;
            this.btnArit.Text = "Arithmetic";
            this.btnArit.UseVisualStyleBackColor = true;
            this.btnArit.Click += new System.EventHandler(this.btnArit_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(38, 149);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(241, 23);
            this.btnFormat.TabIndex = 1;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnCast
            // 
            this.btnCast.Location = new System.Drawing.Point(38, 231);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(241, 23);
            this.btnCast.TabIndex = 2;
            this.btnCast.Text = "InvalidCast";
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // Null
            // 
            this.Null.Location = new System.Drawing.Point(38, 315);
            this.Null.Name = "Null";
            this.Null.Size = new System.Drawing.Size(241, 23);
            this.Null.TabIndex = 3;
            this.Null.Text = "NullReference";
            this.Null.UseVisualStyleBackColor = true;
            this.Null.Click += new System.EventHandler(this.Null_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(429, 98);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(51, 17);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "errrors";
            // 
            // txtCast
            // 
            this.txtCast.Location = new System.Drawing.Point(38, 203);
            this.txtCast.Name = "txtCast";
            this.txtCast.Size = new System.Drawing.Size(328, 22);
            this.txtCast.TabIndex = 5;
            this.txtCast.Text = "99999999999";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCast);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.Null);
            this.Controls.Add(this.btnCast);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnArit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArit;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnCast;
        private System.Windows.Forms.Button Null;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtCast;
    }
}

