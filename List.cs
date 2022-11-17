using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace note_taking
{
    public partial class List : Form
    {
        private DBConnection connection = new DBConnection();
        public List()
        {
            InitializeComponent();
            DataTable listData = new DataTable();
            listData = connection.ListNote();
            if(listData.Rows.Count > 0)
            {
                dtgList.DataSource = listData;
            }
            else
            {
                MessageBox.Show("Nenhuma nota encontrada!");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var createForm = new InitialScreen();
            createForm.Show();
            this.Hide();
        }

        private void dtgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
