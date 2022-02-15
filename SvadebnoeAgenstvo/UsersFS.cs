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
    public partial class UsersFS : Form
    {
        public UsersFS()
        {
            InitializeComponent();
        }

        private void UsersFS_Load(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            label1.Text = mf.Loginf.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personal p = new Personal();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserF uf = new UserF();
            uf.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainf = new MainForm();
            mainf.Show();
        }
    }
}
