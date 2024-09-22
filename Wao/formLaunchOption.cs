using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wao
{
    public partial class formLaunchOption : Form
    {
        private string exePath;

        public formLaunchOption(string exePath)
        {
            InitializeComponent();
            this.exePath = exePath; // Store the exePath for later use
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            // Confirm selection and return OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
