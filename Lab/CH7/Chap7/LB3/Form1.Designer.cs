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
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblShiftError = new System.Windows.Forms.Label();
            this.lblEncodeError = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(39, 68);
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.Size = new System.Drawing.Size(536, 22);
            this.txtDecode.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(39, 167);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(536, 22);
            this.txtResult.TabIndex = 1;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(594, 68);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 2;
            this.btnDecode.Text = "DeCode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(242, 232);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(100, 22);
            this.txtShift.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shift";
            // 
            // lblShiftError
            // 
            this.lblShiftError.AutoSize = true;
            this.lblShiftError.Location = new System.Drawing.Point(242, 271);
            this.lblShiftError.Name = "lblShiftError";
            this.lblShiftError.Size = new System.Drawing.Size(13, 17);
            this.lblShiftError.TabIndex = 5;
            this.lblShiftError.Text = "*";
            // 
            // lblEncodeError
            // 
            this.lblEncodeError.AutoSize = true;
            this.lblEncodeError.Location = new System.Drawing.Point(39, 97);
            this.lblEncodeError.Name = "lblEncodeError";
            this.lblEncodeError.Size = new System.Drawing.Size(13, 17);
            this.lblEncodeError.TabIndex = 6;
            this.lblEncodeError.Text = "*";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(594, 166);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 7;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.lblEncodeError);
            this.Controls.Add(this.lblShiftError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtDecode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblShiftError;
        private System.Windows.Forms.Label lblEncodeError;
        private System.Windows.Forms.Button btnEncode;
    }
}

