namespace PrvaForma
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
            this.kliknebtn = new System.Windows.Forms.Button();
            this.porukattx = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // kliknebtn
            // 
            this.kliknebtn.Location = new System.Drawing.Point(458, 158);
            this.kliknebtn.Name = "kliknebtn";
            this.kliknebtn.Size = new System.Drawing.Size(75, 23);
            this.kliknebtn.TabIndex = 0;
            this.kliknebtn.Text = "Klikni me!";
            this.kliknebtn.UseVisualStyleBackColor = true;
            this.kliknebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // porukattx
            // 
            this.porukattx.AutoSize = true;
            this.porukattx.Location = new System.Drawing.Point(382, 163);
            this.porukattx.Name = "porukattx";
            this.porukattx.Size = new System.Drawing.Size(35, 13);
            this.porukattx.TabIndex = 1;
            this.porukattx.Text = "label1";
            this.porukattx.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Volim te!";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(170, 311);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(472, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.porukattx);
            this.Controls.Add(this.kliknebtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kliknebtn;
        private System.Windows.Forms.Label porukattx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

