using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareProcess
{
    public partial class frmAddPassword : Form
    {
        public frmAddPassword()
        {
            InitializeComponent();
            this.AcceptButton = btnAccept;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string systempassword = "password";

            if (password.Equals(systempassword))
            {
                frmAddPaper AddForm = new frmAddPaper();
                AddForm.Show();

                this.Close();
            }
            else
            {
                txtPassword.BackColor = Color.Red;
                txtPassword.Text = "Incorrect Password";

                txtPassword.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
