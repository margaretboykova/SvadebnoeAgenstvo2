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
    public partial class UserF : Form
    {
        public UserF()
        {
            InitializeComponent();
        }

        private void UserF_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "РФ", "Иное" });
            comboBox2.Items.AddRange(new string[] { "РФ", "Иное" });
            comboBox3.Items.AddRange(new string[] { "Псков", "Великие-Луки" });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `registwedding` ( `NameHusband`, `NameWife`, `BirtdayHusband`, `BirthdayWife`,`LiveHusband`, `LiveWife`,  `СitizenshipHusband`, `СitizenshipWife`, `DateWedding`, `CityWedding`, `PlaceWedding`) VALUES(@nh,@nw,@bh,@bw,@lh,@lw,@ch,@cw,@dw,@ciw,@pw)", db.getConnection());
            command.Parameters.Add("@nh", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@nw", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@bh", MySqlDbType.Date).Value = dateTimePicker1.Value.Date;
            command.Parameters.Add("@bw", MySqlDbType.Date).Value = dateTimePicker2.Value.Date;
            command.Parameters.Add("@lh", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@lw", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@ch", MySqlDbType.VarChar).Value = comboBox1.SelectedItem;
            command.Parameters.Add("@cw", MySqlDbType.VarChar).Value = comboBox2.SelectedItem;
            command.Parameters.Add("@dw", MySqlDbType.Date).Value = dateTimePicker3.Value.Date;
            command.Parameters.Add("@ciw", MySqlDbType.VarChar).Value = comboBox3.SelectedItem;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = comboBox4.SelectedItem;
            db.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Забронировано!");
            else
                MessageBox.Show("Не удалось забронировать");


            db.CloseConnect();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem == "Псков")
            { //Если объекты типа string
                comboBox4.Items.AddRange(new string[] { "Пароменская д.21/33", "Детская д.2" });
            }
            if (comboBox3.SelectedItem == "Великие-Луки")
            { //Если объекты типа string
                comboBox4.Items.AddRange(new string[] { "А.Матросова д.5" });
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.MinDate = DateTime.Now;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersFS ufs = new UsersFS();
            ufs.Show();
        }
    }
}
