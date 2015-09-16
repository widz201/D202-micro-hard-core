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

namespace SoftwareProcess
{
    public partial class frmStudentStudy : Form
    {
        public frmStudentStudy()
        {
            InitializeComponent();
            FillListbox();
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
            try
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
            catch
            {
                MessageBox.Show("You need to select a paper");
            }

            
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstSelected.Items.Remove(lstSelected.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            lstSelected.Items.Clear();


        }

        private void lstPapers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lstSelected.Items.Contains(lstPapers.Text))
                {
                    MessageBox.Show("You have already selected this paper!");
                }
                else
                {
                   lstPapers.SelectedItem = lstSelected.Items.Add(lstPapers.SelectedItem);
                }
            }
            catch
            {
                MessageBox.Show("You need to select a paper");
            }
            
            
        }

        private void lstInfoPapers_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
            string Query = "select * from tblPaper WHERE Paper_Name ='lstInfoPapers.SelectedText.ToString()'";
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
                    string sDescription = myReader.GetString(3);
                    int sCatergory = myReader.GetInt32(6);
                    lblPaperName.Text = sName;
                    lblPaperDesc.Text = sDescription;
                    
                    switch (sCatergory)
                    {
                        case 1:
                            lblCareerOpp.Text = "Software Architecture";
                            break;

                        case 2:
                            lblCareerOpp.Text = "Web Development";
                            break;

                        case 3:
                            lblCareerOpp.Text = "Analysis & Design";
                            break;

                        case 4:
                            lblCareerOpp.Text = "Networking";
                            break;

                        case 5:
                            lblCareerOpp.Text = "Database Development";
                            break;
                    }
                    
                      
                }
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }
        }

    }
}
