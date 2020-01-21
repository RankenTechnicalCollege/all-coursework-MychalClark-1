namespace LB4
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
            this.windSpeed = new System.Windows.Forms.TextBox();
            this.estimate = new System.Windows.Forms.Button();
            this.cate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wind Speed";
            // 
            // windSpeed
            // 
            this.windSpeed.Location = new System.Drawing.Point(86, 133);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(100, 22);
            this.windSpeed.TabIndex = 1;
            // 
            // estimate
            // 
            this.estimate.Location = new System.Drawing.Point(209, 133);
            this.estimate.Name = "estimate";
            this.estimate.Size = new System.Drawing.Size(75, 23);
            this.estimate.TabIndex = 2;
            this.estimate.Text = "Estimate";
            this.estimate.UseVisualStyleBackColor = true;
            this.estimate.Click += new System.EventHandler(this.estimate_Click);
            // 
            // cate
            // 
            this.cate.Location = new System.Drawing.Point(317, 133);
            this.cate.Name = "cate";
            this.cate.Size = new System.Drawing.Size(100, 22);
            this.cate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cate);
            this.Controls.Add(this.estimate);
            this.Controls.Add(this.windSpeed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox windSpeed;
        private System.Windows.Forms.Button estimate;
        private System.Windows.Forms.TextBox cate;
        private System.Windows.Forms.Label label2;
    }
}

