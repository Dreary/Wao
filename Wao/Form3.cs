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
    public partial class Form3 : Form
    {
        public string ServerName { get; set; }
        public string ServerIP { get; set; }
        public string ServerPort { get; set; }

        public Form3(string serverName, string ip, string port)
        {
            InitializeComponent();
            txtName.Text = serverName;
            txtIp.Text = ip;
            txtPort.Text = port;
        }

        private void serverEditBtn_Click(object sender, EventArgs e)
        {
            ServerName = txtName.Text;
            ServerIP = txtIp.Text;
            ServerPort = txtPort.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimiseBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
