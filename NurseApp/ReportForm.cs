using DirectoryLibrary.Models;
using System;
using System.Collections.Generic;
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
            dataGridView.DataSource = directory.Recipes;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            List<Drug> dr = new List<Drug>();
            Recipe toShow = dataGridView.SelectedRows[0].DataBoundItem as Recipe;
            for (int i = 0; i < toShow.Illness.Portions.Count; i++)
            {
                Drug x = new Drug { Name = toShow.Illness.Portions[i].Drug.Name, Total = toShow.Illness.Portions[i].Amount };
                dr.Add(x);
            }
            drugBindingSource.DataSource = dr;
            drugBindingSource.ResetBindings(false);
        }
    }
}
