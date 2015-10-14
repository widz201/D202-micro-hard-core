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
            //When enter is pressed it presses the accept button
            this.AcceptButton = btnAccept;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //Declares string to equal the password textbox text & declares another string as the system password which is password
            string password = txtPassword.Text;
            string systempassword = "password";
            //If statement to check whether the text entered into the password textbox is equal to the system password
            //If the password entered is correct displays the Edit/Remove Paper form
            //Otherwise if the wrong password is entered displays 'incorrect password' in the textbox
            if (password.Equals(systempassword))
            {
                frmRemovePaper removeForm = new frmRemovePaper();
                removeForm.Show();

                this.Close();
            }
            else
            {
                txtPassword.BackColor = Color.Red;
                txtPassword.Text = "Incorrect Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Closes the enter password form          
            this.Close();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            //When the textbox is clicked changes back color back to white and deletes the text which was displayed
            txtPassword.BackColor = Color.White;
            txtPassword.Text = "";
        }
    }
}
