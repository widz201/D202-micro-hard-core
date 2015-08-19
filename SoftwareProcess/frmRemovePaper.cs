using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareProcess
{
    public partial class frmRemovePaper : Form
    {
        public frmRemovePaper()
        {
            InitializeComponent();
        }

        private void btnERCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
