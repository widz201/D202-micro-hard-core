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
    public partial class frmAddPaper : Form
    {
        public frmAddPaper()
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
                    string sID = myReader.GetString(0);
                    string sName = myReader.GetString(1);
                    cboAPapers.Items.Add(sID + " " + sName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This isn't supposed to show up...." + Environment.NewLine + "You broke something");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAPapers.Items.Contains(cboAPapers.Text))
                {
                    MessageBox.Show("This pre-requisite has already been added");
        }
                else
        {
                    lstAPapers.Items.Add(cboAPapers.SelectedItem);
        }
            }
            catch
        {
                MessageBox.Show("You need to select a paper");
            }
        }

        private void btnPreRemove_Click(object sender, EventArgs e)
        {
            lstAPapers.Items.Remove(lstAPapers.Text);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int category = 0;
            int year = 0;
            if (chkAYear1.Checked == true)
            {
                year = 1;
            }
            else if (chkAYear2.Checked == true)
            {
                year = 2;
            }
            else if (chkAYear3.Checked == true)
            {
                year = 3;
            }
            if (chkSoftwareArch.Checked == true)
            {
                category = 1;
            }
            else if (chkWebDev.Checked == true)
            {
                category = 2;
            }
            else if (chkAnal.Checked == true)
            {
                category = 3;
            }
            else if (chkNetwork.Checked == true)
            {
                category = 4;
            }
            else if (chkDB.Checked == true)
            {
                category = 5;
            }
            
            //Puts all prerequsite papers in lstAPapers into a string
            List<string> values = new List<string>();

            foreach(object o in lstAPapers.Items)
            values.Add(o.ToString());

            string selectedItems = String.Join(", ", values);
            
            //Writes information into the database
            string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(constring)) 
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblPaper (Paper_ID, Paper_Name, Description, Year, Catergory, Prerequisite) VALUES (@PaperID, @PaperName, @Desc, @Year, @Category, @Prereq)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@PaperID", tbxPaperCode.Text);
                cmd.Parameters.AddWithValue("@PaperName", tbxPaperName.Text);
                cmd.Parameters.AddWithValue("@Desc", tbxDesc.Text);
                cmd.Parameters.AddWithValue("@Year", year);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Prereq", selectedItems.ToString());
                connection.Open();
                cmd.ExecuteNonQuery();
                tbxPaperName.Clear();
                tbxPaperCode.Clear();
                tbxDesc.Clear();
                chkSoftwareArch.Checked = false;
                chkNetwork.Checked = false;
                chkWebDev.Checked = false;
                chkDB.Checked = false;
                chkAnal.Checked = false;
                chkAYear1.Checked = false;
                chkAYear2.Checked = false;
                chkAYear3.Checked = false;
                chkACompulsory.Checked = false;
                lstAPapers.Items.Clear();
                MessageBox.Show("Paper successfully added");
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to add paper");
            }
        }

        }
    }
