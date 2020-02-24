namespace LB7
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCreate = new System.Windows.Forms.TextBox();
            this.txtRespell = new System.Windows.Forms.TextBox();
            this.btnRespell = new System.Windows.Forms.Button();
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtRedo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(563, 60);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreate
            // 
            this.txtCreate.Location = new System.Drawing.Point(189, 60);
            this.txtCreate.Name = "txtCreate";
            this.txtCreate.Size = new System.Drawing.Size(352, 22);
            this.txtCreate.TabIndex = 1;
            // 
            // txtRespell
            // 
            this.txtRespell.Location = new System.Drawing.Point(189, 146);
            this.txtRespell.Name = "txtRespell";
            this.txtRespell.Size = new System.Drawing.Size(352, 22);
            this.txtRespell.TabIndex = 3;
            // 
            // btnRespell
            // 
            this.btnRespell.Location = new System.Drawing.Point(563, 146);
            this.btnRespell.Name = "btnRespell";
            this.btnRespell.Size = new System.Drawing.Size(75, 23);
            this.btnRespell.TabIndex = 2;
            this.btnRespell.Text = "Respell";
            this.btnRespell.UseVisualStyleBackColor = true;
            this.btnRespell.Click += new System.EventHandler(this.btnRespell_Click);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(189, 233);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(13, 17);
            this.lblEnter.TabIndex = 4;
            this.lblEnter.Text = "*";
            // 
            // txtRedo
            // 
            this.txtRedo.Location = new System.Drawing.Point(189, 118);
            this.txtRedo.Name = "txtRedo";
            this.txtRedo.Size = new System.Drawing.Size(160, 22);
            this.txtRedo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "<-Respell This Name";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(192, 95);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(13, 17);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "*";
            this.lblError.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRedo);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtRespell);
            this.Controls.Add(this.btnRespell);
            this.Controls.Add(this.txtCreate);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCreate;
        private System.Windows.Forms.TextBox txtRespell;
        private System.Windows.Forms.Button btnRespell;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtRedo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
    }
}

