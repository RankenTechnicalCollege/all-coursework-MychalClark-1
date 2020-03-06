namespace PT1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.radioLong = new System.Windows.Forms.RadioButton();
            this.radioShort = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastPayment = new System.Windows.Forms.Label();
            this.lblLastInterest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.radioLong);
            this.groupBox1.Controls.Add(this.radioShort);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Loan";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(19, 162);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create Loan";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // radioLong
            // 
            this.radioLong.AutoSize = true;
            this.radioLong.Location = new System.Drawing.Point(89, 134);
            this.radioLong.Name = "radioLong";
            this.radioLong.Size = new System.Drawing.Size(135, 21);
            this.radioLong.TabIndex = 6;
            this.radioLong.TabStop = true;
            this.radioLong.Text = "Long-Term Loan";
            this.radioLong.UseVisualStyleBackColor = true;
            this.radioLong.CheckedChanged += new System.EventHandler(this.radioLong_CheckedChanged);
            // 
            // radioShort
            // 
            this.radioShort.AutoSize = true;
            this.radioShort.Location = new System.Drawing.Point(89, 107);
            this.radioShort.Name = "radioShort";
            this.radioShort.Size = new System.Drawing.Size(137, 21);
            this.radioShort.TabIndex = 5;
            this.radioShort.TabStop = true;
            this.radioShort.Text = "Short-Term Loan";
            this.radioShort.UseVisualStyleBackColor = true;
            this.radioShort.CheckedChanged += new System.EventHandler(this.radioShort_CheckedChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(89, 68);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(331, 22);
            this.txtAmount.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(331, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLastInterest);
            this.groupBox2.Controls.Add(this.lblLastPayment);
            this.groupBox2.Controls.Add(this.btnPayment);
            this.groupBox2.Controls.Add(this.lblTerm);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(13, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Loan";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(19, 86);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(126, 23);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Make Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(15, 65);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(13, 17);
            this.lblTerm.TabIndex = 1;
            this.lblTerm.Text = "*";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(22, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "*";
            // 
            // lblLastPayment
            // 
            this.lblLastPayment.AutoSize = true;
            this.lblLastPayment.Location = new System.Drawing.Point(18, 125);
            this.lblLastPayment.Name = "lblLastPayment";
            this.lblLastPayment.Size = new System.Drawing.Size(13, 17);
            this.lblLastPayment.TabIndex = 3;
            this.lblLastPayment.Text = "*";
            // 
            // lblLastInterest
            // 
            this.lblLastInterest.AutoSize = true;
            this.lblLastInterest.Location = new System.Drawing.Point(18, 150);
            this.lblLastInterest.Name = "lblLastInterest";
            this.lblLastInterest.Size = new System.Drawing.Size(13, 17);
            this.lblLastInterest.TabIndex = 4;
            this.lblLastInterest.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RadioButton radioLong;
        private System.Windows.Forms.RadioButton radioShort;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastInterest;
        private System.Windows.Forms.Label lblLastPayment;
    }
}

