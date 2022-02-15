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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        MainForm mf = new MainForm();
        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `serwed` ( `NameSer`, `CityWed`, `PlaceWed`, `NamePerson`,`PlusPhoto`,`PlusVideo`,`LoginUser`) VALUES(@ns,@ciw,@pw,@np,@pph,@pv,@lu)", db.getConnection());
            command.Parameters.Add("@ns", MySqlDbType.VarChar).Value = "Развлечение";
            command.Parameters.Add("@ciw", MySqlDbType.VarChar).Value = comboBox1.SelectedItem;
            command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = comboBox2.SelectedItem;
            command.Parameters.Add("@np", MySqlDbType.VarChar).Value = comboBox3.SelectedItem;
            command.Parameters.Add("@pph", MySqlDbType.Bit).Value = "0";
            command.Parameters.Add("@pv", MySqlDbType.Bit).Value = "0";
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = mf.Loginf.Text;
            db.OpenConnect();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");


            db.CloseConnect();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Псков", "Великие-Луки" });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Псков")
            { //Если объекты типа string
                comboBox2.Items.AddRange(new string[] { "Пароменская д.21/33", "Детская д.2" });
            }
            if (comboBox1.SelectedItem == "Великие-Луки")
            { //Если объекты типа string
                comboBox2.Items.AddRange(new string[] { "А.Матросова д.5" });
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Пароменская д.21/33")
            { //Если объекты типа string
                comboBox3.Items.AddRange(new string[] { "Алексеев Андрей Сергеевич", "Терентьев Леонид Ильич" });
            }
            if (comboBox2.SelectedItem == "Детская д.2")
            { //Если объекты типа string
                comboBox3.Items.AddRange(new string[] { "Воля Павел Павлович" });
            }
            if (comboBox2.SelectedItem == "А.Матросова д.5")
            { //Если объекты типа string
                comboBox3.Items.AddRange(new string[] { "Красавов Анатолий Анатольевич" });
            }
        }
    }
}
