namespace chap_10
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
            this.CboHeros = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblDislikes = new System.Windows.Forms.Label();
            this.lblSuper = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CboHeros
            // 
            this.CboHeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboHeros.FormattingEnabled = true;
            this.CboHeros.Location = new System.Drawing.Point(31, 36);
            this.CboHeros.Name = "CboHeros";
            this.CboHeros.Size = new System.Drawing.Size(121, 24);
            this.CboHeros.TabIndex = 0;
            this.CboHeros.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Likes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dislikes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Biogtaphy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "SuperPower:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(290, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(31, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Selecet PHero";
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Location = new System.Drawing.Point(84, 111);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(13, 17);
            this.lblLikes.TabIndex = 7;
            this.lblLikes.Text = "*";
            // 
            // lblDislikes
            // 
            this.lblDislikes.AutoSize = true;
            this.lblDislikes.Location = new System.Drawing.Point(93, 156);
            this.lblDislikes.Name = "lblDislikes";
            this.lblDislikes.Size = new System.Drawing.Size(13, 17);
            this.lblDislikes.TabIndex = 8;
            this.lblDislikes.Text = "*";
            // 
            // lblSuper
            // 
            this.lblSuper.AutoSize = true;
            this.lblSuper.Location = new System.Drawing.Point(126, 219);
            this.lblSuper.Name = "lblSuper";
            this.lblSuper.Size = new System.Drawing.Size(13, 17);
            this.lblSuper.TabIndex = 11;
            this.lblSuper.Text = "*";
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Location = new System.Drawing.Point(31, 335);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(13, 17);
            this.lblBio.TabIndex = 12;
            this.lblBio.Text = "*";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(13, 421);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(8, 17);
            this.lblUrl.TabIndex = 13;
            this.lblUrl.Text = "&";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblSuper);
            this.Controls.Add(this.lblDislikes);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CboHeros);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboHeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblDislikes;
        private System.Windows.Forms.Label lblSuper;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.Label lblUrl;
    }
}

