using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZipJamGUI
{
    public partial class Gui : Form
    {

        string extractName;
        string archiveName;

        public Gui()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // call archive exe
        }

        private void archiveInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string archiveFile = openFileDialog1.FileName;
                archiveInput.Text = archiveFile;
                archiveName = archiveFile;
                try
                {
                    string text = File.ReadAllText(archiveFile);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void Gui_Load(object sender, EventArgs e)
        {

        }

        private void fileSelect_2_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string extractFile = openFileDialog1.FileName;
                extractInput.Text = extractFile;
                extractName = extractFile;
                try
                {
                    string text = File.ReadAllText(extractFile);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void Extract_Click(object sender, EventArgs e)
        {
            //check file is a zip

            
            // call extract exe

        }

        private void extractInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
