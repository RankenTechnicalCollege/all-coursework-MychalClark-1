namespace LB2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.btnVal = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Number [100,999]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity[1,12]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estimated Delivery Days[1,30]";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(211, 0);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 3;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(211, 81);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 22);
            this.txtDays.TabIndex = 4;
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(211, 39);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(100, 22);
            this.txtQuan.TabIndex = 5;
            // 
            // btnVal
            // 
            this.btnVal.Location = new System.Drawing.Point(211, 129);
            this.btnVal.Name = "btnVal";
            this.btnVal.Size = new System.Drawing.Size(100, 23);
            this.btnVal.TabIndex = 6;
            this.btnVal.Text = "Validate";
            this.btnVal.UseVisualStyleBackColor = true;
            this.btnVal.Click += new System.EventHandler(this.btnVal_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(116, 180);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(13, 17);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 221);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnVal);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Button btnVal;
        private System.Windows.Forms.Label lblResult;
    }
}

