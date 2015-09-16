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
            string selectedPaper = lstInfoPapers.SelectedItem.ToString();
            string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
            string Query = "select * from tblPaper where Paper_Name = '" + selectedPaper + "'";
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
                    string sDescription = myReader.GetString(2);
                    int sCatergory = myReader.GetInt32(6);
                    lblPaperName.Text = sName;
                    lblPaperDesc.Text = sDescription;
                    
                    switch (sCatergory)
                    {
                        case 1:
                            lblCareerOpp.Text = "Software Architecture";
                            panel2.BackColor = Color.PowderBlue;
                            panel3.BackColor = Color.PowderBlue;
                            panel4.BackColor = Color.PowderBlue;
                            panel5.BackColor = Color.PowderBlue;
                            break;

                        case 2:
                            lblCareerOpp.Text = "Web Development";
                            panel2.BackColor = Color.LightCoral;
                            panel3.BackColor = Color.LightCoral;
                            panel4.BackColor = Color.LightCoral;
                            panel5.BackColor = Color.LightCoral;
                            break;

                        case 3:
                            lblCareerOpp.Text = "Analysis and Design";
                            panel2.BackColor = Color.LightGreen;
                            panel3.BackColor = Color.LightGreen;
                            panel4.BackColor = Color.LightGreen;
                            panel5.BackColor = Color.LightGreen;
                            break;

                        case 4:
                            lblCareerOpp.Text = "Networking";
                            panel2.BackColor = Color.Violet;
                            panel3.BackColor = Color.Violet;
                            panel4.BackColor = Color.Violet;
                            panel5.BackColor = Color.Violet;
                            break;

                        case 5:
                            lblCareerOpp.Text = "Database Development";
                            panel2.BackColor = Color.Khaki;
                            panel3.BackColor = Color.Khaki;
                            panel4.BackColor = Color.Khaki;
                            panel5.BackColor = Color.Khaki;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to pull information from the database","Connection error");
            }
        }

        private void frmStudentStudy_Load(object sender, EventArgs e)
        {

        }

        private void chkWebDev_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWebDev.Checked == true)
            {

            }
        }

        private void chkAnal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnal.Checked == true)
            {
               
            }
        }

    }
}
