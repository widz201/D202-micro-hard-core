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
            frmAddPassword PasswordForm = new frmAddPassword();

            PasswordForm.Show();
        }

        private void editPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassword2 PasswordForm2 = new frmPassword2();

            PasswordForm2.Show();
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
                    string sPrereq = myReader.GetString(8);
                    lblPaperName.Text = sName;
                    lblPaperDesc.Text = sDescription;
                    lblPrereq.Text = sPrereq;
                    
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
                            panel2.BackColor = Color.Violet;
                            panel3.BackColor = Color.Violet;
                            panel4.BackColor = Color.Violet;
                            panel5.BackColor = Color.Violet;
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
                            panel2.BackColor = Color.LightCoral;
                            panel3.BackColor = Color.LightCoral;
                            panel4.BackColor = Color.LightCoral;
                            panel5.BackColor = Color.LightCoral;
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

        private void btnLoadPapers_Click_1(object sender, EventArgs e)
        {
            if (radAnalDes.Checked == true)
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper where [Catergory] = 3 ";
                SqlConnection connection = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, connection);
                SqlDataReader myReader;
                try
                {
                    lstPapers.Items.Clear();
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
            else if (radSoftwareArch.Checked == true)
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper where [Catergory] = 1 ";
                SqlConnection connection = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, connection);
                SqlDataReader myReader;
                try
                {
                    lstPapers.Items.Clear();
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
            else if (radWebDev.Checked == true)
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper where [Catergory] = 2 ";
                SqlConnection connection = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, connection);
                SqlDataReader myReader;
                try
                {
                    lstPapers.Items.Clear();
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
            else if (radNetworking.Checked == true)
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper where [Catergory] = 4 ";
                SqlConnection connection = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, connection);
                SqlDataReader myReader;
                try
                {
                    lstPapers.Items.Clear();
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
            else if (radDatabaseDev.Checked == true)
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper where [Catergory] = 5 ";
                SqlConnection connection = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, connection);
                SqlDataReader myReader;
                try
                {
                    lstPapers.Items.Clear();
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
            else if (radYear2.Checked == true)
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper where [Year] = 2 ";
                SqlConnection connection = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, connection);
                SqlDataReader myReader;
                try
                {
                    lstPapers.Items.Clear();
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
            else if (radYear3.Checked == true)
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper where [Year] = 3 ";
                SqlConnection connection = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, connection);
                SqlDataReader myReader;
                try
                {
                    lstPapers.Items.Clear();
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
            else if (radSemester1.Checked == true)
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper where [Semester] = 1 OR [Semester] = 0";
                SqlConnection connection = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, connection);
                SqlDataReader myReader;
                try
                {
                    lstPapers.Items.Clear();
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
            else if (radSemester2.Checked == true)
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper where [Semester] = 2 OR [Semester] = 0 ";
                SqlConnection connection = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, connection);
                SqlDataReader myReader;
                try
                {
                    lstPapers.Items.Clear();
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
            else
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper";
                SqlConnection connection = new SqlConnection(constring);
                SqlCommand cmdDatabase = new SqlCommand(Query, connection);
                SqlDataReader myReader;
                try
                {
                    lstPapers.Items.Clear();
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
        }

        private void radYear2_CheckedChanged(object sender, EventArgs e)
        {
            if (radYear2.Checked == true)
            {
                tbxD301.Visible = false;
                tbxD303.Visible = false;
                tbxD311.Visible = false;
                tbxI303.Visible = false;
                tbxI301.Visible = false;
                tbxI302.Visible = false;
                tbxI309.Visible = false;
                tbxI321.Visible = false;
                tbxT301.Visible = false;
                tbxT302.Visible = false;
                tbxT311.Visible = false;
                tbxD101.Visible = false;
                tbxD111.Visible = false;
                tbxI101.Visible = false;
                tbxI102.Visible = false;
                tbxI111.Visible = false;
                tbxI121.Visible = false;
                tbxT101.Visible = false;
                tbxT111.Visible = false; 
            }
            else
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = true;
                tbxD301.Visible = true;
                tbxD303.Visible = true;
                tbxD311.Visible = true;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI211.Visible = true;
                tbxI213.Visible = true;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI309.Visible = true;
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

        private void radSoftwareArch_CheckedChanged(object sender, EventArgs e)
        {
            if (radSoftwareArch.Checked == true)
            {
                tbxD303.Visible = false;
                tbxD311.Visible = false;
                tbxI303.Visible = false;
                tbxI309.Visible = false;
                tbxI321.Visible = false;
                tbxT301.Visible = false;
                tbxT302.Visible = false;
                tbxT311.Visible = false;
                tbxI203.Visible = false;
                tbxI211.Visible = false;
                tbxT201.Visible = false;
                tbxT211.Visible = false;
                tbxI213.Visible = false;
                tbxT205.Visible = false;
                tbxT206.Visible = false;


            }
            else
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = true;
                tbxD301.Visible = true;
                tbxD303.Visible = true;
                tbxD311.Visible = true;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI211.Visible = true;
                tbxI213.Visible = true;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI309.Visible = true;
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


        

        private void radYear3_CheckedChanged(object sender, EventArgs e)
        {
            if (radYear3.Checked == true)
            {
                tbxD101.Visible = false;
                tbxD111.Visible = false;
                tbxD201.Visible = false;
                tbxD202.Visible = false;
                tbxD211.Visible = false;
                tbxI101.Visible = false;
                tbxI102.Visible = false;
                tbxI111.Visible = false;
                tbxI121.Visible = false;
                tbxI202.Visible = false;
                tbxI203.Visible = false;
                tbxI211.Visible = false;
                tbxI213.Visible = false;
                tbxI221.Visible = false;
                tbxT101.Visible = false;
                tbxT111.Visible = false;
                tbxT201.Visible = false;
                tbxT205.Visible = false;
                tbxT206.Visible = false;
                tbxT211.Visible = false;
            }
            else
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = true;
                tbxD301.Visible = true;
                tbxD303.Visible = true;
                tbxD311.Visible = true;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI211.Visible = true;
                tbxI213.Visible = true;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI309.Visible = true;
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

        private void radSemester1_CheckedChanged(object sender, EventArgs e)
        {
            if (radSemester1.Checked == true)
            {
                tbxD101.Visible = false;
                tbxD111.Visible = true;
                tbxD201.Visible = true;
                tbxD202.Visible = false;
                tbxD211.Visible = true;
                tbxD301.Visible = true;
                tbxD303.Visible = false;
                tbxD311.Visible = true;
                tbxI101.Visible = true;
                tbxI102.Visible = false;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = false;
                tbxI203.Visible = true;
                tbxI211.Visible = true;
                tbxI213.Visible = false;
                tbxI221.Visible = false;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = false;
                tbxI309.Visible = true;
                tbxI321.Visible = true;
                tbxT101.Visible = false;
                tbxT111.Visible = false;
                tbxT201.Visible = true;
                tbxT205.Visible = true;
                tbxT206.Visible = true;
                tbxT211.Visible = false;
                tbxT301.Visible = true;
                tbxT302.Visible = true;
                tbxT311.Visible = true;
            }
            else
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = true;
                tbxD301.Visible = true;
                tbxD303.Visible = true;
                tbxD311.Visible = true;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI211.Visible = true;
                tbxI213.Visible = true;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI309.Visible = true;
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

        private void radSemester2_CheckedChanged(object sender, EventArgs e)
        {
            if (radSemester2.Checked == true)
            {
                tbxD101.Visible = true;
                tbxD111.Visible = false;
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = false;
                tbxD301.Visible = false;
                tbxD303.Visible = true;
                tbxD311.Visible = false;
                tbxI101.Visible = false;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = false;
                tbxI202.Visible = true;
                tbxI203.Visible = false;
                tbxI211.Visible = true;
                tbxI213.Visible = true;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI309.Visible = true;
                tbxI321.Visible = false;
                tbxT101.Visible = true;
                tbxT111.Visible = false;
                tbxT201.Visible = false;
                tbxT205.Visible = true;
                tbxT206.Visible = true;
                tbxT211.Visible = true;
                tbxT301.Visible = false;
                tbxT302.Visible = true;
                tbxT311.Visible = true;
            }
            else
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = true;
                tbxD301.Visible = true;
                tbxD303.Visible = true;
                tbxD311.Visible = true;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI211.Visible = true;
                tbxI213.Visible = true;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI309.Visible = true;
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

        private void radWebDev_CheckedChanged(object sender, EventArgs e)
        {
            if (radWebDev.Checked == true)
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
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
                tbxI211.Visible = true;
                tbxI213.Visible = true;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = false;
                tbxI309.Visible = false;
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
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = true;
                tbxD301.Visible = true;
                tbxD303.Visible = true;
                tbxD311.Visible = true;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI211.Visible = true;
                tbxI213.Visible = true;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI309.Visible = true;
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

        private void radAnalDes_CheckedChanged(object sender, EventArgs e)
        {
            if (radAnalDes.Checked == true)
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
                tbxD201.Visible = false;
                tbxD202.Visible = false;
                tbxD211.Visible = true;
                tbxD301.Visible = false;
                tbxD303.Visible = false;
                tbxD311.Visible = false;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI211.Visible = false;
                tbxI213.Visible = false;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI309.Visible = true;
                tbxI321.Visible = true;
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
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = true;
                tbxD301.Visible = true;
                tbxD303.Visible = true;
                tbxD311.Visible = true;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI211.Visible = true;
                tbxI213.Visible = true;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI309.Visible = true;
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

        private void radNetworking_CheckedChanged(object sender, EventArgs e)
        {
            if (radNetworking.Checked == true)
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
                tbxD201.Visible = false;
                tbxD202.Visible = false;
                tbxD211.Visible = true;
                tbxD301.Visible = false;
                tbxD303.Visible = false;
                tbxD311.Visible = false;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = false;
                tbxI211.Visible = false;
                tbxI213.Visible = false;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = false;
                tbxI309.Visible = false;
                tbxI321.Visible = false;
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

        private void radDatabaseDev_CheckedChanged(object sender, EventArgs e)
        {
            if (radDatabaseDev.Checked == true)
            {
                tbxD101.Visible = true;
                tbxD111.Visible = true;
                tbxD201.Visible = false;
                tbxD202.Visible = false;
                tbxD211.Visible = true;
                tbxD301.Visible = false;
                tbxD303.Visible = false;
                tbxD311.Visible = true;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = false;
                tbxI211.Visible = false;
                tbxI213.Visible = false;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = false;
                tbxI309.Visible = false;
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
                tbxD201.Visible = true;
                tbxD202.Visible = true;
                tbxD211.Visible = true;
                tbxD301.Visible = true;
                tbxD303.Visible = true;
                tbxD311.Visible = true;
                tbxI101.Visible = true;
                tbxI102.Visible = true;
                tbxI111.Visible = true;
                tbxI121.Visible = true;
                tbxI202.Visible = true;
                tbxI203.Visible = true;
                tbxI211.Visible = true;
                tbxI213.Visible = true;
                tbxI221.Visible = true;
                tbxI301.Visible = true;
                tbxI302.Visible = true;
                tbxI303.Visible = true;
                tbxI309.Visible = true;
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
