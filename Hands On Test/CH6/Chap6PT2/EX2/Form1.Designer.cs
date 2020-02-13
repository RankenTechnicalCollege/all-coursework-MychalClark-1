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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.groupInvoice = new System.Windows.Forms.GroupBox();
            this.lblNumInvoice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.groupInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(123, 99);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(239, 22);
            this.txtCode.TabIndex = 2;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(123, 64);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(239, 22);
            this.txtNum.TabIndex = 3;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(378, 64);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(143, 52);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(123, 128);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(13, 17);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "*";
            // 
            // groupInvoice
            // 
            this.groupInvoice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupInvoice.Controls.Add(this.lblCost);
            this.groupInvoice.Controls.Add(this.lblTotal);
            this.groupInvoice.Controls.Add(this.lblTax);
            this.groupInvoice.Controls.Add(this.lblSub);
            this.groupInvoice.Controls.Add(this.label7);
            this.groupInvoice.Controls.Add(this.label6);
            this.groupInvoice.Controls.Add(this.label5);
            this.groupInvoice.Controls.Add(this.label4);
            this.groupInvoice.Controls.Add(this.label3);
            this.groupInvoice.Controls.Add(this.lblNumInvoice);
            this.groupInvoice.Location = new System.Drawing.Point(3, 175);
            this.groupInvoice.Name = "groupInvoice";
            this.groupInvoice.Size = new System.Drawing.Size(518, 181);
            this.groupInvoice.TabIndex = 6;
            this.groupInvoice.TabStop = false;
            // 
            // lblNumInvoice
            // 
            this.lblNumInvoice.AutoSize = true;
            this.lblNumInvoice.Location = new System.Drawing.Point(10, 22);
            this.lblNumInvoice.Name = "lblNumInvoice";
            this.lblNumInvoice.Size = new System.Drawing.Size(13, 17);
            this.lblNumInvoice.TabIndex = 0;
            this.lblNumInvoice.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "T-Shirts @               each";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "----------------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Subtotal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tax:";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(86, 64);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(13, 17);
            this.lblSub.TabIndex = 6;
            this.lblSub.Text = "*";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(86, 82);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(13, 17);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "*";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(86, 99);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 17);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "*";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(101, 22);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(13, 17);
            this.lblCost.TabIndex = 9;
            this.lblCost.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 369);
            this.Controls.Add(this.groupInvoice);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupInvoice.ResumeLayout(false);
            this.groupInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.GroupBox groupInvoice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumInvoice;
        private System.Windows.Forms.Label lblCost;
    }
}

