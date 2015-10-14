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
            //Calls method to fill list box
            FillListbox();
        }

        void FillListbox()
        {
            //Method to create new database connection and query to select all data from the Paper table.
            //Declare data reader then using a try catch statement open the connection and execute the data reader to read from the database.
            //Declare variables sID to hold the paper code (using the reader to get the data from the database) and sName to hold the Paper Name.
            //Gets the Papers combo box to take the data from the variables (sID and sName) and display it together in the combo box.
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
            //Closes the add paper form
            this.Close();
        }

        private void btnPreAdd_Click(object sender, EventArgs e)
        {
            //Uses a try catch to see if the prequisite has already been added from the combo to the list box.
            //If the prerequisite isn't already in the list box it adds it to the list box.
            //Catches if there is no prerequisite selected when the Prerequisite Add button is pressed.
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
            //Removes the item selected in the add papers listbox
            lstAPapers.Items.Remove(lstAPapers.Text);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //declares variables and sets them to 
                int category = 0;
                int year = 0;
                int semester = 0;
                int lecturer = 0;
                string archive = "N";

                //Selects year
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

                //Selects Semester
                if (radSem1.Checked == true)
                {
                    semester = 1;
                }
                else if (radSem2.Checked == true)
                {
                    semester = 2;
                }
                else if (radSemBoth.Checked == true)
                {
                    semester = 0;
                }

                //Selects to Archive paper
                if (chkArchive.Checked == true)
                {
                    archive = "Y";
                }
                else
                {
                    archive = "N";
                }

                //Selects Lecturer
                if ((cboLecturer.SelectedItem.ToString()) == "SC")
                {
                    lecturer = 1;
                }
                else if ((cboLecturer.SelectedItem.ToString()) == "AS")
                {
                    lecturer = 2;
                }
                else if ((cboLecturer.SelectedItem.ToString()) == "GR")
                {
                    lecturer = 3;
                }
                else if ((cboLecturer.SelectedItem.ToString()) == "RD")
                {
                    lecturer = 4;
                }
                else if ((cboLecturer.SelectedItem.ToString()) == "KT")
                {
                    lecturer = 5;
                };

                //Puts all prerequsite papers in lstAPapers into a string
                List<string> values = new List<string>();

                foreach (object o in lstAPapers.Items)
                    values.Add(o.ToString());

                string selectedItems = String.Join(", ", values);

                //Writes information into the database
                string constring = "Data Source=tfs;Initial Catalog=study1;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(constring))
                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO tblPaper (Paper_ID, Paper_Name, Description, Year, Catergory, Prerequisite, Semester, Archived, Lecturer) VALUES (@PaperID, @PaperName, @Desc, @Year, @Category, @Prereq, @Semester, @Archived, @Lecturer)");
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = connection;
                        cmd.Parameters.AddWithValue("@PaperID", tbxPaperCode.Text);
                        cmd.Parameters.AddWithValue("@PaperName", tbxPaperName.Text);
                        cmd.Parameters.AddWithValue("@Desc", tbxDesc.Text);
                        cmd.Parameters.AddWithValue("@Year", year);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@Prereq", selectedItems.ToString());
                        cmd.Parameters.AddWithValue("@Semester", semester);
                        cmd.Parameters.AddWithValue("@Archived", archive);
                        cmd.Parameters.AddWithValue("@Lecturer", lecturer);
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
                        radSem1.Checked = false;
                        radSem2.Checked = false;
                        radSemBoth.Checked = false;
                        chkArchive.Checked = false;
                        MessageBox.Show("Paper successfully added");
                        cboAPapers.SelectedIndex = -1;
                        cboLecturer.SelectedIndex = -1;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to add paper");
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Please complete all fields");
            }
        }

        private void frmAddPaper_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        }
    }
