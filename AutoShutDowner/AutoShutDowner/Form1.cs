using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoShutDowner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        { // converting the textbox string to int

            int time = Convert.ToInt32(this.textBox1.Text);
            // converting sec to mins by * 60. yy is the time in minutes
            int yy=time * 60;

            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C  shutdown /s /t " + yy;
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();
            string q = "";
            while (!process.HasExited)
            {
               // progressBar1.Value = 20;
                q += process.StandardOutput.ReadToEnd();
            }
          //  label1.Text = q;
            //  MessageBox.Show(q); 
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process process = new System.Diagnostics.Process();

            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C shutdown /a ";
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();
            string q = "";
            while (!process.HasExited)
            {
                // progressBar1.Value = 20;
                q += process.StandardOutput.ReadToEnd();
            }
          
            //  MessageBox.Show(q); 
        }

        private void button3_Click(object sender, EventArgs e)
        {    // convertign to int
            int y = Convert.ToInt32(this.textBox1.Text);
            // secs >>> to mins
            int x = y * 60;
        MessageBox.Show("The Window will be Hidden and Your PC will be shut down after " + x + " minutes");
        this.Hide();
        }
    }
}
