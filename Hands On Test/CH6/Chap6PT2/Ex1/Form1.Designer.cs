namespace Ex1
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnMed = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.lblSmall = new System.Windows.Forms.Label();
            this.lblMed = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.groupInvoice = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSmallInvoice = new System.Windows.Forms.Label();
            this.lblMediumInvoice = new System.Windows.Forms.Label();
            this.lblLargeInvoice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "What size shirts do you need?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "$9.99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "$11.99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "$10.99";
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(19, 54);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(41, 42);
            this.btnSmall.TabIndex = 2;
            this.btnSmall.Text = "S";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnMed
            // 
            this.btnMed.Location = new System.Drawing.Point(90, 54);
            this.btnMed.Name = "btnMed";
            this.btnMed.Size = new System.Drawing.Size(41, 42);
            this.btnMed.TabIndex = 4;
            this.btnMed.Text = "M";
            this.btnMed.UseVisualStyleBackColor = true;
            this.btnMed.Click += new System.EventHandler(this.btnMed_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Location = new System.Drawing.Point(171, 54);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(41, 42);
            this.btnLarge.TabIndex = 6;
            this.btnLarge.Text = "L";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // lblSmall
            // 
            this.lblSmall.AutoSize = true;
            this.lblSmall.Location = new System.Drawing.Point(19, 103);
            this.lblSmall.Name = "lblSmall";
            this.lblSmall.Size = new System.Drawing.Size(13, 17);
            this.lblSmall.TabIndex = 7;
            this.lblSmall.Text = "*";
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Location = new System.Drawing.Point(87, 103);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(13, 17);
            this.lblMed.TabIndex = 8;
            this.lblMed.Text = "*";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Location = new System.Drawing.Point(168, 103);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(13, 17);
            this.lblLarge.TabIndex = 9;
            this.lblLarge.Text = "*";
            // 
            // groupInvoice
            // 
            this.groupInvoice.Controls.Add(this.lblTotal);
            this.groupInvoice.Controls.Add(this.lblTax);
            this.groupInvoice.Controls.Add(this.lblSub);
            this.groupInvoice.Controls.Add(this.label11);
            this.groupInvoice.Controls.Add(this.label10);
            this.groupInvoice.Controls.Add(this.label9);
            this.groupInvoice.Controls.Add(this.label8);
            this.groupInvoice.Controls.Add(this.lblLargeInvoice);
            this.groupInvoice.Controls.Add(this.lblMediumInvoice);
            this.groupInvoice.Controls.Add(this.lblSmallInvoice);
            this.groupInvoice.Controls.Add(this.label7);
            this.groupInvoice.Controls.Add(this.label6);
            this.groupInvoice.Controls.Add(this.label5);
            this.groupInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupInvoice.Location = new System.Drawing.Point(16, 141);
            this.groupInvoice.Name = "groupInvoice";
            this.groupInvoice.Size = new System.Drawing.Size(196, 220);
            this.groupInvoice.TabIndex = 10;
            this.groupInvoice.TabStop = false;
            this.groupInvoice.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Small @9.99 each";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Medium @10.99 each";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Large @11.99 each";
            // 
            // lblSmallInvoice
            // 
            this.lblSmallInvoice.AutoSize = true;
            this.lblSmallInvoice.Location = new System.Drawing.Point(23, 18);
            this.lblSmallInvoice.Name = "lblSmallInvoice";
            this.lblSmallInvoice.Size = new System.Drawing.Size(13, 17);
            this.lblSmallInvoice.TabIndex = 0;
            this.lblSmallInvoice.Text = "*";
            // 
            // lblMediumInvoice
            // 
            this.lblMediumInvoice.AutoSize = true;
            this.lblMediumInvoice.Location = new System.Drawing.Point(23, 49);
            this.lblMediumInvoice.Name = "lblMediumInvoice";
            this.lblMediumInvoice.Size = new System.Drawing.Size(13, 17);
            this.lblMediumInvoice.TabIndex = 2;
            this.lblMediumInvoice.Text = "*";
            // 
            // lblLargeInvoice
            // 
            this.lblLargeInvoice.AutoSize = true;
            this.lblLargeInvoice.Location = new System.Drawing.Point(23, 85);
            this.lblLargeInvoice.Name = "lblLargeInvoice";
            this.lblLargeInvoice.Size = new System.Drawing.Size(13, 17);
            this.lblLargeInvoice.TabIndex = 4;
            this.lblLargeInvoice.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "-----------------------------------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Subtotal:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tax:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total:";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(96, 129);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(13, 17);
            this.lblSub.TabIndex = 8;
            this.lblSub.Text = "*";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(67, 157);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(13, 17);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "*";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(76, 187);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 17);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "*";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(16, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(196, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupInvoice);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.lblSmall);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnMed);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnMed;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.Label lblSmall;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.GroupBox groupInvoice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLargeInvoice;
        private System.Windows.Forms.Label lblMediumInvoice;
        private System.Windows.Forms.Label lblSmallInvoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClear;
    }
}

