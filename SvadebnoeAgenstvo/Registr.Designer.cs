
namespace SvadebnoeAgenstvo
{
    partial class Registr
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
            this.labelPass = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.Passf = new System.Windows.Forms.TextBox();
            this.Loginf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Surnamef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Namef = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(34, 136);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(62, 20);
            this.labelPass.TabIndex = 8;
            this.labelPass.Text = "Пароль";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(34, 76);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(52, 20);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Логин";
            // 
            // Passf
            // 
            this.Passf.Location = new System.Drawing.Point(148, 136);
            this.Passf.Name = "Passf";
            this.Passf.Size = new System.Drawing.Size(162, 27);
            this.Passf.TabIndex = 6;
            this.Passf.UseSystemPasswordChar = true;
            // 
            // Loginf
            // 
            this.Loginf.Location = new System.Drawing.Point(148, 76);
            this.Loginf.Name = "Loginf";
            this.Loginf.Size = new System.Drawing.Size(162, 27);
            this.Loginf.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ваш пол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Фамилия";
            // 
            // Surnamef
            // 
            this.Surnamef.Location = new System.Drawing.Point(484, 136);
            this.Surnamef.Name = "Surnamef";
            this.Surnamef.Size = new System.Drawing.Size(162, 27);
            this.Surnamef.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Имя";
            // 
            // Namef
            // 
            this.Namef.Location = new System.Drawing.Point(484, 76);
            this.Namef.Name = "Namef";
            this.Namef.Size = new System.Drawing.Size(162, 27);
            this.Namef.TabIndex = 13;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.AutoCompleteCustomSource.AddRange(new string[] {
            "Женский",
            "Мужской"});
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(148, 198);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(151, 28);
            this.comboBoxSex.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(269, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Вернуться";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Namef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Surnamef);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.Passf);
            this.Controls.Add(this.Loginf);
            this.Name = "Registr";
            this.Text = "Registr";
            this.Load += new System.EventHandler(this.Registr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox Passf;
        private System.Windows.Forms.TextBox Loginf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Surnamef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Namef;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}