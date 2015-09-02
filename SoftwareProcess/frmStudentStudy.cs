using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SoftwareProcess
{
    public partial class frmStudentStudy : Form
    {
        public frmStudentStudy()
        {
            InitializeComponent();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAdminAdd_Click(object sender, EventArgs e)
        {
            frmAddPaper addForm = new frmAddPaper();

            addForm.Show();
        }

        private void editPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemovePaper removeForm = new frmRemovePaper();

            removeForm.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
