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
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioUnframed = new System.Windows.Forms.RadioButton();
            this.radioMatted = new System.Windows.Forms.RadioButton();
            this.radioFramed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupMat = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioBlack = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.radioWhite = new System.Windows.Forms.RadioButton();
            this.radioGreen = new System.Windows.Forms.RadioButton();
            this.radioRed = new System.Windows.Forms.RadioButton();
            this.radioPine = new System.Windows.Forms.RadioButton();
            this.radioSilver = new System.Windows.Forms.RadioButton();
            this.radioGold = new System.Windows.Forms.RadioButton();
            this.radioSteel = new System.Windows.Forms.RadioButton();
            this.radioOak = new System.Windows.Forms.RadioButton();
            this.radioSimple = new System.Windows.Forms.RadioButton();
            this.radioVintage = new System.Windows.Forms.RadioButton();
            this.radioEclectric = new System.Windows.Forms.RadioButton();
            this.radioAntique = new System.Windows.Forms.RadioButton();
            this.radioModern = new System.Windows.Forms.RadioButton();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblChoice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupMat.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width(in)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height(in)";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(96, 10);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(393, 22);
            this.txtWidth.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(96, 57);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(393, 22);
            this.txtHeight.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFramed);
            this.groupBox1.Controls.Add(this.radioMatted);
            this.groupBox1.Controls.Add(this.radioUnframed);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioUnframed
            // 
            this.radioUnframed.AutoSize = true;
            this.radioUnframed.Checked = true;
            this.radioUnframed.Location = new System.Drawing.Point(7, 22);
            this.radioUnframed.Name = "radioUnframed";
            this.radioUnframed.Size = new System.Drawing.Size(91, 21);
            this.radioUnframed.TabIndex = 0;
            this.radioUnframed.TabStop = true;
            this.radioUnframed.Text = "Unframed";
            this.radioUnframed.UseVisualStyleBackColor = true;
            // 
            // radioMatted
            // 
            this.radioMatted.AutoSize = true;
            this.radioMatted.Location = new System.Drawing.Point(7, 58);
            this.radioMatted.Name = "radioMatted";
            this.radioMatted.Size = new System.Drawing.Size(72, 21);
            this.radioMatted.TabIndex = 1;
            this.radioMatted.Text = "Matted";
            this.radioMatted.UseVisualStyleBackColor = true;
            // 
            // radioFramed
            // 
            this.radioFramed.AutoSize = true;
            this.radioFramed.Location = new System.Drawing.Point(7, 94);
            this.radioFramed.Name = "radioFramed";
            this.radioFramed.Size = new System.Drawing.Size(77, 21);
            this.radioFramed.TabIndex = 2;
            this.radioFramed.Text = "Framed";
            this.radioFramed.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioRed);
            this.groupBox2.Controls.Add(this.radioGreen);
            this.groupBox2.Controls.Add(this.radioWhite);
            this.groupBox2.Controls.Add(this.radioBlue);
            this.groupBox2.Controls.Add(this.radioBlack);
            this.groupBox2.Location = new System.Drawing.Point(20, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 163);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupMat
            // 
            this.groupMat.Controls.Add(this.radioOak);
            this.groupMat.Controls.Add(this.radioSteel);
            this.groupMat.Controls.Add(this.radioGold);
            this.groupMat.Controls.Add(this.radioSilver);
            this.groupMat.Controls.Add(this.radioPine);
            this.groupMat.Location = new System.Drawing.Point(184, 236);
            this.groupMat.Name = "groupMat";
            this.groupMat.Size = new System.Drawing.Size(119, 163);
            this.groupMat.TabIndex = 6;
            this.groupMat.TabStop = false;
            this.groupMat.Text = "Material";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioModern);
            this.groupBox4.Controls.Add(this.radioAntique);
            this.groupBox4.Controls.Add(this.radioEclectric);
            this.groupBox4.Controls.Add(this.radioVintage);
            this.groupBox4.Controls.Add(this.radioSimple);
            this.groupBox4.Location = new System.Drawing.Point(355, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 163);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Style";
            // 
            // radioBlack
            // 
            this.radioBlack.AutoSize = true;
            this.radioBlack.Checked = true;
            this.radioBlack.Location = new System.Drawing.Point(3, 34);
            this.radioBlack.Name = "radioBlack";
            this.radioBlack.Size = new System.Drawing.Size(63, 21);
            this.radioBlack.TabIndex = 0;
            this.radioBlack.TabStop = true;
            this.radioBlack.Text = "Black";
            this.radioBlack.UseVisualStyleBackColor = true;
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(3, 115);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(57, 21);
            this.radioBlue.TabIndex = 1;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            // 
            // radioWhite
            // 
            this.radioWhite.AutoSize = true;
            this.radioWhite.Location = new System.Drawing.Point(3, 142);
            this.radioWhite.Name = "radioWhite";
            this.radioWhite.Size = new System.Drawing.Size(65, 21);
            this.radioWhite.TabIndex = 2;
            this.radioWhite.Text = "White";
            this.radioWhite.UseVisualStyleBackColor = true;
            // 
            // radioGreen
            // 
            this.radioGreen.AutoSize = true;
            this.radioGreen.Location = new System.Drawing.Point(3, 88);
            this.radioGreen.Name = "radioGreen";
            this.radioGreen.Size = new System.Drawing.Size(69, 21);
            this.radioGreen.TabIndex = 4;
            this.radioGreen.Text = "Green";
            this.radioGreen.UseVisualStyleBackColor = true;
            // 
            // radioRed
            // 
            this.radioRed.AutoSize = true;
            this.radioRed.Location = new System.Drawing.Point(3, 61);
            this.radioRed.Name = "radioRed";
            this.radioRed.Size = new System.Drawing.Size(55, 21);
            this.radioRed.TabIndex = 5;
            this.radioRed.Text = "Red";
            this.radioRed.UseVisualStyleBackColor = true;
            // 
            // radioPine
            // 
            this.radioPine.AutoSize = true;
            this.radioPine.Checked = true;
            this.radioPine.Location = new System.Drawing.Point(3, 34);
            this.radioPine.Name = "radioPine";
            this.radioPine.Size = new System.Drawing.Size(57, 21);
            this.radioPine.TabIndex = 0;
            this.radioPine.TabStop = true;
            this.radioPine.Text = "Pine";
            this.radioPine.UseVisualStyleBackColor = true;
            // 
            // radioSilver
            // 
            this.radioSilver.AutoSize = true;
            this.radioSilver.Location = new System.Drawing.Point(1, 115);
            this.radioSilver.Name = "radioSilver";
            this.radioSilver.Size = new System.Drawing.Size(64, 21);
            this.radioSilver.TabIndex = 1;
            this.radioSilver.Text = "Silver";
            this.radioSilver.UseVisualStyleBackColor = true;
            // 
            // radioGold
            // 
            this.radioGold.AutoSize = true;
            this.radioGold.Location = new System.Drawing.Point(1, 142);
            this.radioGold.Name = "radioGold";
            this.radioGold.Size = new System.Drawing.Size(59, 21);
            this.radioGold.TabIndex = 2;
            this.radioGold.Text = "Gold";
            this.radioGold.UseVisualStyleBackColor = true;
            // 
            // radioSteel
            // 
            this.radioSteel.AutoSize = true;
            this.radioSteel.Location = new System.Drawing.Point(1, 88);
            this.radioSteel.Name = "radioSteel";
            this.radioSteel.Size = new System.Drawing.Size(61, 21);
            this.radioSteel.TabIndex = 3;
            this.radioSteel.Text = "Steel";
            this.radioSteel.UseVisualStyleBackColor = true;
            // 
            // radioOak
            // 
            this.radioOak.AutoSize = true;
            this.radioOak.Location = new System.Drawing.Point(0, 61);
            this.radioOak.Name = "radioOak";
            this.radioOak.Size = new System.Drawing.Size(55, 21);
            this.radioOak.TabIndex = 4;
            this.radioOak.Text = "Oak";
            this.radioOak.UseVisualStyleBackColor = true;
            // 
            // radioSimple
            // 
            this.radioSimple.AutoSize = true;
            this.radioSimple.Checked = true;
            this.radioSimple.Location = new System.Drawing.Point(16, 34);
            this.radioSimple.Name = "radioSimple";
            this.radioSimple.Size = new System.Drawing.Size(71, 21);
            this.radioSimple.TabIndex = 1;
            this.radioSimple.TabStop = true;
            this.radioSimple.Text = "Simple";
            this.radioSimple.UseVisualStyleBackColor = true;
            // 
            // radioVintage
            // 
            this.radioVintage.AutoSize = true;
            this.radioVintage.Location = new System.Drawing.Point(16, 115);
            this.radioVintage.Name = "radioVintage";
            this.radioVintage.Size = new System.Drawing.Size(77, 21);
            this.radioVintage.TabIndex = 2;
            this.radioVintage.Text = "Vintage";
            this.radioVintage.UseVisualStyleBackColor = true;
            this.radioVintage.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // radioEclectric
            // 
            this.radioEclectric.AutoSize = true;
            this.radioEclectric.Location = new System.Drawing.Point(16, 142);
            this.radioEclectric.Name = "radioEclectric";
            this.radioEclectric.Size = new System.Drawing.Size(77, 21);
            this.radioEclectric.TabIndex = 3;
            this.radioEclectric.Text = "Eclectic";
            this.radioEclectric.UseVisualStyleBackColor = true;
            // 
            // radioAntique
            // 
            this.radioAntique.AutoSize = true;
            this.radioAntique.Location = new System.Drawing.Point(16, 88);
            this.radioAntique.Name = "radioAntique";
            this.radioAntique.Size = new System.Drawing.Size(77, 21);
            this.radioAntique.TabIndex = 4;
            this.radioAntique.Text = "Antique";
            this.radioAntique.UseVisualStyleBackColor = true;
            // 
            // radioModern
            // 
            this.radioModern.AutoSize = true;
            this.radioModern.Location = new System.Drawing.Point(16, 61);
            this.radioModern.Name = "radioModern";
            this.radioModern.Size = new System.Drawing.Size(77, 21);
            this.radioModern.TabIndex = 5;
            this.radioModern.Text = "Modern";
            this.radioModern.UseVisualStyleBackColor = true;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(23, 418);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(101, 28);
            this.btnCal.TabIndex = 8;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(326, 418);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(64, 25);
            this.lblCost.TabIndex = 9;
            this.lblCost.Text = "Cost:";
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblChoice.Location = new System.Drawing.Point(23, 461);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(13, 17);
            this.lblChoice.TabIndex = 10;
            this.lblChoice.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 490);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupMat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "PhotoShop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupMat.ResumeLayout(false);
            this.groupMat.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFramed;
        private System.Windows.Forms.RadioButton radioMatted;
        private System.Windows.Forms.RadioButton radioUnframed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioRed;
        private System.Windows.Forms.RadioButton radioGreen;
        private System.Windows.Forms.RadioButton radioWhite;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.RadioButton radioBlack;
        private System.Windows.Forms.GroupBox groupMat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioOak;
        private System.Windows.Forms.RadioButton radioSteel;
        private System.Windows.Forms.RadioButton radioGold;
        private System.Windows.Forms.RadioButton radioSilver;
        private System.Windows.Forms.RadioButton radioPine;
        private System.Windows.Forms.RadioButton radioModern;
        private System.Windows.Forms.RadioButton radioAntique;
        private System.Windows.Forms.RadioButton radioEclectric;
        private System.Windows.Forms.RadioButton radioVintage;
        private System.Windows.Forms.RadioButton radioSimple;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblChoice;
    }
}

