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
    public partial class frmPassword2 : Form
    {

        public frmPassword2()
        {
            InitializeComponent();
            this.AcceptButton = btnAccept;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string systempassword = "password";

            if (password.Equals (systempassword))
            {
                frmRemovePaper removeForm = new frmRemovePaper();
                removeForm.Show();

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
