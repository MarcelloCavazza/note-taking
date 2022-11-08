using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace note_taking
{
    public partial class Form1 : Form
    {
        private String title, description;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String cs = @"server=localhost;userid=root;password=;database=notes";
            String query = $"insert into note values(null, '{this.title}', '{this.description}', CURRENT_TIMESTAMP, null)";
            MySqlConnection conn = new MySqlConnection(cs);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Task created");
            conn.Close();

        }

        private void rTxtDescription_TextChanged(object sender, EventArgs e)
        { 
            this.description = rTxtDescription.Text.ToString();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            this.title = txtTitle.Text.ToString();
        }
    }
}
