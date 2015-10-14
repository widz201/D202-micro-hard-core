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
            //Calls method to fill list box
            FillListbox();
        }
        void FillListbox()
        {
            //Method to create new database connection and query to select all data from the Paper table.
            //Declare data reader then using a try catch statement open the connection and execute the data reader to read from the database.
            //While the data reader is working it gets the string from the first column(PaperName) and holds it in the variable 'sName' then adds it to the list 'lstERPapers',
            //it loops through the records in the column adding the rest of the paper names to the list.
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
            //This button will eventually pass the paper information through to the add paper screen in order to allow it to be edited
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (btnArchive.Text == "Archived")
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

                btnArchive.Text = "Active";
            }
            else
            {
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                string Query = "select * from tblPaper where Archived = 'N'";
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

                btnArchive.Text = "Archived";
            }

        }


    }
}
