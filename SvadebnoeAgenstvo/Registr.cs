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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainf = new MainForm();
            mainf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Loginf.Text == "" || Passf.Text == "" || Namef.Text == "" || Surnamef.Text == "" || comboBoxSex.SelectedItem == "")
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                if (checkUser())
                    return;
                DB db = new DB();
                MySqlCommand command = new MySqlCommand(" INSERT INTO `users` ( `Login`, `Password`, `Name`, `Surname`,`Sex`) VALUES(@login,@pass,@name,@surname,@sex)", db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Loginf.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Passf.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = Namef.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = Surnamef.Text;
                command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = comboBoxSex.SelectedItem;
                db.OpenConnect();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был создан");
                else
                    MessageBox.Show("Аккаунт не был создан");


                db.CloseConnect();
            }
        }
        public Boolean checkUser()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Login`=@uL ", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Loginf.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть!");
                return true;
            }
            else
            {
                
                return false;

            }
        }

        private void Registr_Load(object sender, EventArgs e)
        {
            comboBoxSex.Items.AddRange(new string[] { "Мужской", "Женский"});
        }
    }
}
