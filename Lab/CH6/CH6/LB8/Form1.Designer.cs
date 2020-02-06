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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDrawers = new System.Windows.Forms.TextBox();
            this.lblWood = new System.Windows.Forms.Label();
            this.lblDrawers = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Of WOod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of Drawers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost Of WOod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cost of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Cost";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(80, 97);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 22);
            this.txtType.TabIndex = 5;
            // 
            // txtDrawers
            // 
            this.txtDrawers.Location = new System.Drawing.Point(318, 97);
            this.txtDrawers.Name = "txtDrawers";
            this.txtDrawers.Size = new System.Drawing.Size(100, 22);
            this.txtDrawers.TabIndex = 6;
            // 
            // lblWood
            // 
            this.lblWood.AutoSize = true;
            this.lblWood.Location = new System.Drawing.Point(77, 246);
            this.lblWood.Name = "lblWood";
            this.lblWood.Size = new System.Drawing.Size(13, 17);
            this.lblWood.TabIndex = 7;
            this.lblWood.Text = "*";
            // 
            // lblDrawers
            // 
            this.lblDrawers.AutoSize = true;
            this.lblDrawers.Location = new System.Drawing.Point(351, 246);
            this.lblDrawers.Name = "lblDrawers";
            this.lblDrawers.Size = new System.Drawing.Size(13, 17);
            this.lblDrawers.TabIndex = 8;
            this.lblDrawers.Text = "*";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(551, 246);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 17);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "*";
            this.lblTotal.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(80, 154);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(188, 30);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Estimate";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDrawers);
            this.Controls.Add(this.lblWood);
            this.Controls.Add(this.txtDrawers);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtDrawers;
        private System.Windows.Forms.Label lblWood;
        private System.Windows.Forms.Label lblDrawers;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEnter;
    }
}

