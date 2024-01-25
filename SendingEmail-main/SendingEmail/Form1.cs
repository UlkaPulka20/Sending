

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendingEmail
{
    public partial class Form1 : Form
    {
        private Setting1 settings;
        private Sing_in sing_In;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void setting_Click(object sender, EventArgs e)
        {
            settings = new Setting1();
            settings.Visible = true;
        }

        private void send_Click(object sender, EventArgs e)
        {


            string ExecuteCommand(string command)
            {
                var processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = "1.bat";
                processStartInfo.Arguments = $"-Command \"{command}\"";
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;

                var process = new Process();
                process.StartInfo = processStartInfo;
                process.Start();
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sing_In = new Sing_in();
            sing_In.Visible = true;
        }
        private string filePath; // переменная для хранения пути к выбранному файл
        private void button2_Click(object sender, EventArgs e)
        {
           
                OpenFileDialog openFileDialog = new OpenFileDialog();
               

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            
        }

       
        }
    }
    


