namespace LB33
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
            this.kiloBox = new System.Windows.Forms.TextBox();
            this.milesbox = new System.Windows.Forms.TextBox();
            this.kiloButton = new System.Windows.Forms.Button();
            this.milesButton = new System.Windows.Forms.Button();
            this.transform = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Papyrus", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distance In Kilometers";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Papyrus", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance In Miles";
            // 
            // kiloBox
            // 
            this.kiloBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.kiloBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kiloBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.kiloBox.Location = new System.Drawing.Point(402, 110);
            this.kiloBox.Multiline = true;
            this.kiloBox.Name = "kiloBox";
            this.kiloBox.Size = new System.Drawing.Size(307, 21);
            this.kiloBox.TabIndex = 2;
            this.kiloBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kiloBox.TextChanged += new System.EventHandler(this.kiloBox_TextChanged);
            // 
            // milesbox
            // 
            this.milesbox.BackColor = System.Drawing.SystemColors.MenuText;
            this.milesbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.milesbox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.milesbox.Location = new System.Drawing.Point(23, 110);
            this.milesbox.Name = "milesbox";
            this.milesbox.Size = new System.Drawing.Size(307, 22);
            this.milesbox.TabIndex = 3;
            this.milesbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kiloButton
            // 
            this.kiloButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.kiloButton.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiloButton.ForeColor = System.Drawing.SystemColors.Window;
            this.kiloButton.Location = new System.Drawing.Point(402, 137);
            this.kiloButton.Name = "kiloButton";
            this.kiloButton.Size = new System.Drawing.Size(307, 51);
            this.kiloButton.TabIndex = 4;
            this.kiloButton.Text = "Convert To Miles";
            this.kiloButton.UseVisualStyleBackColor = false;
            this.kiloButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // milesButton
            // 
            this.milesButton.BackColor = System.Drawing.Color.DarkMagenta;
            this.milesButton.Font = new System.Drawing.Font("Snap ITC", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesButton.ForeColor = System.Drawing.SystemColors.Window;
            this.milesButton.Location = new System.Drawing.Point(23, 137);
            this.milesButton.Name = "milesButton";
            this.milesButton.Size = new System.Drawing.Size(307, 51);
            this.milesButton.TabIndex = 5;
            this.milesButton.Text = "Convert To Kilometers";
            this.milesButton.UseVisualStyleBackColor = false;
            this.milesButton.Click += new System.EventHandler(this.milesButton_Click);
            // 
            // transform
            // 
            this.transform.AutoSize = true;
            this.transform.Location = new System.Drawing.Point(20, 207);
            this.transform.Name = "transform";
            this.transform.Size = new System.Drawing.Size(20, 17);
            this.transform.TabIndex = 6;
            this.transform.Text = "3.";
            this.transform.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.transform.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "公里";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(731, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transform);
            this.Controls.Add(this.milesButton);
            this.Controls.Add(this.kiloButton);
            this.Controls.Add(this.milesbox);
            this.Controls.Add(this.kiloBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "Form1";
            this.Text = "Distance Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kiloBox;
        private System.Windows.Forms.TextBox milesbox;
        private System.Windows.Forms.Button kiloButton;
        private System.Windows.Forms.Button milesButton;
        private System.Windows.Forms.Label transform;
        private System.Windows.Forms.Label label4;
    }
}

