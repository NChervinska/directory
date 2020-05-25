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
    public partial class ReportForm : Form
    {
        Directory directory;
        public ReportForm(Directory directory)
        {
            InitializeComponent();

            this.directory = directory;
        }
    }
}
