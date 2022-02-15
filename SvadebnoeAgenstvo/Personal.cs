using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvadebnoeAgenstvo
{
    public partial class Personal : Form
    {
        public Personal()
        {
            InitializeComponent();
        }
        public void loadform(object form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadform(new photo());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadform(new Game());
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            //MainForm mf = new MainForm();
            //label3.Text = mf.Loginf.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainf = new MainForm();
            mainf.Show();
        }
    }
}
