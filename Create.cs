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
    public partial class Create : Form
    {
        private String description, title;
        private DBConnection connection = new DBConnection(); 
        public Create()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            connection.CreateNote(this.title, this.description);
            MessageBox.Show("Task created");

        }

        private void rTxtDescription_TextChanged(object sender, EventArgs e)
        { 
            this.description = rTxtDescription.Text.ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var createForm = new InitialScreen();
            createForm.Show();
            this.Hide();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            this.title = txtTitle.Text.ToString();
        }
    }
}
