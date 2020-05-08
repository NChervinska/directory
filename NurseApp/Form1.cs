using DirectoryLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NurseApp
{
    public partial class Form1 : Form
    {
        Directory directory;
        public Form1()
        {
            InitializeComponent();
            directory = new Directory();
            directory.FillTestData(100);
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            var f2 = new Form();
            Hide();
            f2.ShowDialog();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            directory.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Save data before exit?", "", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    directory.Save();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}