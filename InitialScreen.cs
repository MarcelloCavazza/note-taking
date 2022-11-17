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
    public partial class InitialScreen : Form
    {
        public InitialScreen()
        {
            InitializeComponent();
        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            var createForm = new Create();
            createForm.Show();
            this.Hide();
        }

        private void btnListNote_Click(object sender, EventArgs e)
        {
            var createForm = new List();
            createForm.Show();
            this.Hide();
        }
    }
}
