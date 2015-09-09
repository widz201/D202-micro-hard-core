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
                MessageBox.Show("NIGGER");
            }
        }
        private void btnERCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstERPapers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
