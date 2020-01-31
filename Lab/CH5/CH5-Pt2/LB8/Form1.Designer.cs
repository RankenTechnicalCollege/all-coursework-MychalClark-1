namespace LB8
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
            System.Windows.Forms.Label label2;
            this.label1 = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.btnDan = new System.Windows.Forms.Button();
            this.btnEd = new System.Windows.Forms.Button();
            this.btnFran = new System.Windows.Forms.Button();
            this.labelDan = new System.Windows.Forms.Label();
            this.labelEd = new System.Windows.Forms.Label();
            this.labelFran = new System.Windows.Forms.Label();
            this.Grand = new System.Windows.Forms.Label();
            this.most = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 17);
            label2.TabIndex = 2;
            label2.Text = "Who Made The Sale?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "How Much was The Sale?";
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(16, 34);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(167, 22);
            this.txtSale.TabIndex = 1;
            // 
            // btnDan
            // 
            this.btnDan.Location = new System.Drawing.Point(19, 98);
            this.btnDan.Name = "btnDan";
            this.btnDan.Size = new System.Drawing.Size(164, 23);
            this.btnDan.TabIndex = 3;
            this.btnDan.Text = "Danielle";
            this.btnDan.UseVisualStyleBackColor = true;
            this.btnDan.Click += new System.EventHandler(this.btnDan_Click);
            // 
            // btnEd
            // 
            this.btnEd.Location = new System.Drawing.Point(19, 127);
            this.btnEd.Name = "btnEd";
            this.btnEd.Size = new System.Drawing.Size(164, 23);
            this.btnEd.TabIndex = 4;
            this.btnEd.Text = "Edward";
            this.btnEd.UseVisualStyleBackColor = true;
            this.btnEd.Click += new System.EventHandler(this.btnEd_Click);
            // 
            // btnFran
            // 
            this.btnFran.Location = new System.Drawing.Point(19, 156);
            this.btnFran.Name = "btnFran";
            this.btnFran.Size = new System.Drawing.Size(164, 23);
            this.btnFran.TabIndex = 5;
            this.btnFran.Text = "Francis";
            this.btnFran.UseVisualStyleBackColor = true;
            this.btnFran.Click += new System.EventHandler(this.btnFran_Click);
            // 
            // labelDan
            // 
            this.labelDan.AutoSize = true;
            this.labelDan.Location = new System.Drawing.Point(210, 104);
            this.labelDan.Name = "labelDan";
            this.labelDan.Size = new System.Drawing.Size(102, 17);
            this.labelDan.TabIndex = 6;
            this.labelDan.Text = "Danielle Sales:";
            this.labelDan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEd
            // 
            this.labelEd.AutoSize = true;
            this.labelEd.Location = new System.Drawing.Point(210, 133);
            this.labelEd.Name = "labelEd";
            this.labelEd.Size = new System.Drawing.Size(98, 17);
            this.labelEd.TabIndex = 7;
            this.labelEd.Text = "Edward Sales:";
            this.labelEd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFran
            // 
            this.labelFran.AutoSize = true;
            this.labelFran.Location = new System.Drawing.Point(210, 162);
            this.labelFran.Name = "labelFran";
            this.labelFran.Size = new System.Drawing.Size(97, 17);
            this.labelFran.TabIndex = 8;
            this.labelFran.Text = "Francis Sales:";
            this.labelFran.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Grand
            // 
            this.Grand.AutoSize = true;
            this.Grand.Location = new System.Drawing.Point(150, 209);
            this.Grand.Name = "Grand";
            this.Grand.Size = new System.Drawing.Size(88, 17);
            this.Grand.TabIndex = 9;
            this.Grand.Text = "Grand Total:";
            // 
            // most
            // 
            this.most.AutoSize = true;
            this.most.Location = new System.Drawing.Point(153, 230);
            this.most.Name = "most";
            this.most.Size = new System.Drawing.Size(0, 17);
            this.most.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 450);
            this.Controls.Add(this.most);
            this.Controls.Add(this.Grand);
            this.Controls.Add(this.labelFran);
            this.Controls.Add(this.labelEd);
            this.Controls.Add(this.labelDan);
            this.Controls.Add(this.btnFran);
            this.Controls.Add(this.btnEd);
            this.Controls.Add(this.btnDan);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtSale);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Button btnDan;
        private System.Windows.Forms.Button btnEd;
        private System.Windows.Forms.Button btnFran;
        private System.Windows.Forms.Label labelDan;
        private System.Windows.Forms.Label labelEd;
        private System.Windows.Forms.Label labelFran;
        private System.Windows.Forms.Label Grand;
        private System.Windows.Forms.Label most;
    }
}

