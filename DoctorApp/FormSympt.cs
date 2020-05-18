using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorApp
{
    public partial class FormSympt : Form
    {
        public List<string> symptomNow = new List<string>();

        public FormSympt()
        {
            InitializeComponent();

            List<string> sym = new List<string>();
            for (int i = 0; i < 16; i++)
                sym.Add($"Symptom{i}");
            listSympt.DataSource = sym;

            foreach (var s in listSympt.SelectedIndices)
            {
                symptomNow.Add($"Symptom{s}");
            }
        }
        private void Ill_Click(object sender, EventArgs e)
        {
            var f3 = new FormIll();
            Hide();
            f3.ShowDialog();
            this.Visible = true;
        }
    }
}
