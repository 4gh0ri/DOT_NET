using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Program_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Font Dialog
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult fontResult = fontDialog1.ShowDialog();
            if (fontResult == DialogResult.OK)
            {
                label1.Font = fontDialog1.Font;
            }
        }
        // Open File Dialog
        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                Filter = "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }
        //Save File Dialog
        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
        }
    }
}
