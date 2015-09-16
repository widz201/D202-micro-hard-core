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
using System.Diagnostics;
//https://www.youtube.com/watch?v=dwG6eg5UofI
namespace SoftwareProcess
{
    public partial class frmStudentStudy : Form
    {
        public frmStudentStudy()
        {
            InitializeComponent();
            FillListbox();
            
        }
        public class List<ListItem>
        {

        }

        void FillListbox()
        {
            string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
            string Query = "select * from tblPaper";
            SqlConnection connection = new SqlConnection(constring);
            SqlCommand cmdDatabase = new SqlCommand(Query, connection);
            SqlDataReader myReader;
            try
            {
                connection.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string sName = myReader.GetString(1);
                    lstPapers.Items.Add(sName);
                    lstInfoPapers.Items.Add(sName);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
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
            if(lstSelected.Items.Contains(lstPapers.Text))
            {
                MessageBox.Show("You have already selected this paper!");
            }
            else
            {
                lstSelected.Items.Add(lstPapers.SelectedItem);
            }

            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstSelected.Items.Remove(lstSelected.Text);
        }

        private void lstInfoPapers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkYear2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYear2.Checked == true)
            {
                tbxD101.Visible = false;
                tbxD111.Visible = false;
                tbxD101.Visible = false;
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = true;
                tbxD301.Visible = false;
                tbxD303.Visible = false;
                tbxD311.Visible = false;
                tbxI101.Visible = false;
                tbxI121.Visible = false;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI221.Visible = true;
                tbxI102.Visible = false;
                tbxI301.Visible = false;
                tbxI302.Visible = false;
                tbxI303.Visible = false;
                tbxI321.Visible = false;
                tbxT101.Visible = false;
                tbxT111.Visible = false;
                tbxT201.Visible = true;
                tbxT205.Visible = true;
                tbxT206.Visible = true;
                tbxT211.Visible = true;
                tbxT301.Visible = false;
                tbxT302.Visible = false;
                tbxT311.Visible = false;
            }

        }

        private void chkWebDev_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWebDev.Checked == true)
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
                tbxD101.Visible = true;
                tbxD201.Visible = false;
                tbxD202.Visible = false;
                tbxD211.Visible = true;
                tbxD301.Visible = false;
                tbxD303.Visible = true;
                tbxD311.Visible = false;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = false;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = false;
                tbxI321.Visible = false;
                tbxT101.Visible = true;
                tbxT111.Visible = true;
                tbxT201.Visible = false;
                tbxT205.Visible = false;
                tbxT206.Visible = false;
                tbxT211.Visible = false;
                tbxT301.Visible = false;
                tbxT302.Visible = false;
                tbxT311.Visible = false;
            }
            else
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
                tbxD101.Visible = true;
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = true;
                tbxD301.Visible = true;
                tbxD303.Visible = true;
                tbxD311.Visible = true;
                tbxI111.Visible = true;
                tbxI101.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI221.Visible = true;
                tbxI102.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI321.Visible = true;
                tbxT101.Visible = true;
                tbxT111.Visible = true;
                tbxT201.Visible = true;
                tbxT205.Visible = true;
                tbxT206.Visible = true;
                tbxT211.Visible = true;
                tbxT301.Visible = true;
                tbxT302.Visible = true;
                tbxT311.Visible = true;
            }
        }
        
        
    }
}
