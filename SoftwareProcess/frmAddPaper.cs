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
                    string sName = myReader.GetString(1);
                    cboAPapers.Items.Add(sName);
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
            
        }

        private void btnPreRemove_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddPaper_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
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
            string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(constring)) 
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO tblPaper (Paper_ID, Paper_Name, Description, Year) VALUES (@PaperID, @PaperName, @Desc, @Year)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@PaperID", tbxPaperCode.Text);
                cmd.Parameters.AddWithValue("@PaperName", tbxPaperName.Text);
                cmd.Parameters.AddWithValue("@Desc", tbxDesc.Text);
                cmd.Parameters.AddWithValue("@Year", year);
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

            }

            
        }

        private void chkAYear1_CheckedChanged(object sender, EventArgs e)
        {
           


        }

        private void lstAPapers_Click(object sender, EventArgs e)
        {
            
        }
    }
}
