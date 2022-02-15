
namespace SvadebnoeAgenstvo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Loginf = new System.Windows.Forms.TextBox();
            this.Passf = new System.Windows.Forms.TextBox();
            this.buttonEntry = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelGoRegistr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Loginf
            // 
            this.Loginf.Location = new System.Drawing.Point(294, 168);
            this.Loginf.Name = "Loginf";
            this.Loginf.Size = new System.Drawing.Size(256, 27);
            this.Loginf.TabIndex = 0;
            // 
            // Passf
            // 
            this.Passf.Location = new System.Drawing.Point(294, 228);
            this.Passf.Name = "Passf";
            this.Passf.Size = new System.Drawing.Size(256, 27);
            this.Passf.TabIndex = 1;
            this.Passf.UseSystemPasswordChar = true;
            // 
            // buttonEntry
            // 
            this.buttonEntry.Location = new System.Drawing.Point(294, 326);
            this.buttonEntry.Name = "buttonEntry";
            this.buttonEntry.Size = new System.Drawing.Size(94, 29);
            this.buttonEntry.TabIndex = 2;
            this.buttonEntry.Text = "Войти";
            this.buttonEntry.UseVisualStyleBackColor = true;
            this.buttonEntry.Click += new System.EventHandler(this.buttonEntry_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(180, 168);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(52, 20);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Логин";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(192, 235);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(62, 20);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Пароль";
            // 
            // labelGoRegistr
            // 
            this.labelGoRegistr.AutoSize = true;
            this.labelGoRegistr.Location = new System.Drawing.Point(435, 330);
            this.labelGoRegistr.Name = "labelGoRegistr";
            this.labelGoRegistr.Size = new System.Drawing.Size(142, 20);
            this.labelGoRegistr.TabIndex = 5;
            this.labelGoRegistr.Text = "Зарегистироваться";
            this.labelGoRegistr.Click += new System.EventHandler(this.labelGoRegistr_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGoRegistr);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonEntry);
            this.Controls.Add(this.Passf);
            this.Controls.Add(this.Loginf);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       public System.Windows.Forms.TextBox Loginf;
        private System.Windows.Forms.TextBox Passf;
        private System.Windows.Forms.Button buttonEntry;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelGoRegistr;
    }
}

