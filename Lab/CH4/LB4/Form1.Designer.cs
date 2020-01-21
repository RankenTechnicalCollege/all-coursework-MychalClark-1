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
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box4 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter numer of eggs laid by each chicken:";
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(178, 102);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(100, 22);
            this.Box1.TabIndex = 2;
            // 
            // Box4
            // 
            this.Box4.Location = new System.Drawing.Point(526, 102);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(100, 22);
            this.Box4.TabIndex = 3;
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(294, 102);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(100, 22);
            this.Box2.TabIndex = 4;
            // 
            // Box3
            // 
            this.Box3.Location = new System.Drawing.Point(410, 102);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(100, 22);
            this.Box3.TabIndex = 5;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(358, 147);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 97);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(306, 291);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 17);
            this.Result.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box4);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.TextBox Box4;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label Result;
    }
}

