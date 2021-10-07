using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ImprimirArchivo

{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            //Seleccionar Archivo
            OpenFileDialog ofd = new OpenFileDialog();
            if (DialogResult.OK == ofd.ShowDialog(this))
            {
                textBox1.Text = ofd.FileName;

                PrintDialog pd = new PrintDialog();
                pd.PrinterSettings = new PrinterSettings();

                //Enviar archivo a impresora predetermianda
                RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, ofd.FileName);
                     
                    
                
                

                //Seleccionar impresora y enviar archivo
               /* if (DialogResult.OK == pd.ShowDialog(this))
                {
                    // Print the file to the printer.
                    RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, ofd.FileName);
                    
                }*/
            }
        }


        // imprimir solo una Cadena 
        private void button4_Click(object sender, EventArgs e)
        {
            string s = "Hello"; // device-dependent string, need a FormFeed?

            // Allow the user to select a printer.
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            if (DialogResult.OK == pd.ShowDialog(this))
            {
                // Send a printer-specific to the printer.
                RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, s);
            }
        }
    }
}
