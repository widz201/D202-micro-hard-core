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
    public partial class frmRemovePaper : Form
    {
        public frmRemovePaper()
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
                    lstERPapers.Items.Add(sName);
                    
                        

                }
            }
            catch (Exception)
            {
                MessageBox.Show("This isn't supposed to show up...." + Environment.NewLine + "You broke something");
            }
        }
        private void btnERCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEREdit_Click(object sender, EventArgs e)
        {
            
        }

        private void lstERPapers_Click(object sender, EventArgs e)
        {
           
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            lstERPapers.Items.Clear();
            string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
            string Query = "select * from tblPaper where Archived = 'Y'";
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
                    lstERPapers.Items.Add(sName);

                }
            }
            catch
            {
                MessageBox.Show("Unable to show archived items");
            } 
        }


    }
}
