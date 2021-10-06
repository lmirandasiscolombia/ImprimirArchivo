using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;
 

namespace ImprimirArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         

           /* PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            pd.PrinterSettings.PrinterName = "doPDF11";
           */
            Process printjob = new Process();
            printjob.StartInfo.FileName = openFileDialog1.FileName;
            //printjob.StartInfo.Arguments = pd.PrinterSettings.PrinterName;
            printjob.StartInfo.UseShellExecute = true;
            printjob.StartInfo.CreateNoWindow = true;
            printjob.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            printjob.StartInfo.Verb = "Print";
            printjob.Start();

        }

     

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }
    }
}
