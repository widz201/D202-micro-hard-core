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
            private void frmStudentStudy_Load(object sender, EventArgs e)
            {
                SqlConnection con = new SqlConnection(@"Data  Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\visits.mdf;Integrated  Security=True;User Instance=True");
                    con.Open();

                SqlCommand cmd = new SqlCommand("SELECT Paper_ID, Paper_Name", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
            {
                tbxD111.Text = sdr["Paper_ID, Paper_Name"].ToString(); 
                //this.txtCustomerAddress.Text = sdr["CustomerAddress"].ToString();
                //this.txtArrivalTime.Text = sdr["ArrivalTime"].ToString();
            }
        
            sdr.Close();

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


        }

        private void chkWebDev_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
