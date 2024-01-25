using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace SendingEmail
{
    public partial class Sing_in : Form
    {
        public Sing_in()
        {
            InitializeComponent();
        }
        public void ExecuteCommand(string command)
        {
            var processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "powershell.exe";
            processStartInfo.Arguments = $"-Command \"{command}\"";
            processStartInfo.UseShellExecute = false;
            processStartInfo.RedirectStandardOutput = true;

            var process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                ExecuteCommand("open_davs://ulyana.shumilova%40spb.gpsm.ru:Fx213hkw%%2B@srv2@.spb.gpsm.ru/");
}
        }
    }
}
