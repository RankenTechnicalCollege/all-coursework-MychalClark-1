namespace LB4
{
    partial class PokemonForm
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
            this.btnRespawn = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRespawn
            // 
            this.btnRespawn.Location = new System.Drawing.Point(622, 393);
            this.btnRespawn.Name = "btnRespawn";
            this.btnRespawn.Size = new System.Drawing.Size(166, 45);
            this.btnRespawn.TabIndex = 0;
            this.btnRespawn.Text = "Respawn";
            this.btnRespawn.UseVisualStyleBackColor = true;
            this.btnRespawn.Click += new System.EventHandler(this.btnRespawn_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(622, 199);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(166, 34);
            this.btnAttack.TabIndex = 1;
            this.btnAttack.Text = "*";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 396);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(277, 416);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(13, 17);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "*";
            // 
            // PokemonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnRespawn);
            this.Name = "PokemonForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRespawn;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
    }
}

