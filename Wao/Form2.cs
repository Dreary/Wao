using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wao
{
    public partial class Form2 : Form
    {
        public string ServerName { get; private set; }
        public string ServerIP { get; private set; }
        public string ServerPort { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point mousePoint;
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);

            if ((e.Button & MouseButtons.Left) != MouseButtons.Left) return;

            this.Location = new Point(this.Left - (mousePoint.X - e.X),
            this.Top - (mousePoint.Y - e.Y));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ServerName = textBox1.Text;
            ServerIP = textBox2.Text;
            ServerPort = textBox3.Text;

            // Simple validation to ensure all fields are filled
            if (string.IsNullOrWhiteSpace(ServerName) ||
                string.IsNullOrWhiteSpace(ServerIP) ||
                string.IsNullOrWhiteSpace(ServerPort))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Close Form2 and return DialogResult.OK to indicate success
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
