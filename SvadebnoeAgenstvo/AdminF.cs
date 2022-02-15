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
    public partial class AdminF : Form
    {
        public AdminF()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
            LoadDataIntoDataGridView2();
            LoadDataIntoDataGridView3();
        }
        private void LoadDataIntoDataGridView()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=wedding");
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from users";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView1.DataSource = dtRecords;

        }
        private void LoadDataIntoDataGridView2()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=wedding");
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from registwedding";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView2.DataSource = dtRecords;


        }
        private void LoadDataIntoDataGridView3()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=wedding");
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "Select * from serwed";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);
            dataGridView3.DataSource = dtRecords;

        }
        private void AdminF_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
