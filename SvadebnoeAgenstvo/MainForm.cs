using MySql.Data.MySqlClient;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            string LoginUser = Loginf.Text;
            string PassUser = Passf.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login`=@uL AND `Password`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("Не удалось войти", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            if (Loginf.Text == "Admin")
            {
                this.Hide();
                AdminF aform = new AdminF();
                aform.Show();
            }
            else
            {
                this.Hide();
                UsersFS ufs = new UsersFS();
                ufs.Show();
            }

        }

        private void labelGoRegistr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registr register = new Registr();
            register.Show();
        }
    }
}
