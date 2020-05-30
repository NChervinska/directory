using DirectoryLibrary.Models;
using System;
using System.Windows.Forms;

namespace NurseApp
{
    // Форма для добавления и удаления медикамента
    public partial class MainForm : Form
    {
        Directory directory;
        public MainForm(Directory directory)
        {
            InitializeComponent();

            this.directory = directory;
            directory.IsDirty = false;
            drugBindingSource.DataSource = directory.Drugs;
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            directory.Save();
            directory.IsDirty = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!directory.IsDirty)
                return;
            var res = MessageBox.Show("Save change before exiting?", "", MessageBoxButtons.YesNoCancel);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drug del = drugGridView.SelectedRows[0].DataBoundItem as Drug;
            if (del != null)
            {
                var res = MessageBox.Show($"Delete {del.Name}?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    directory.Drugs.Remove(del);
                    drugBindingSource.ResetBindings(false);
                    directory.IsDirty = true;
                }
            }
        }

        private void Report_Click(object sender, EventArgs e)
        {
            var f3 = new ReportForm(directory);
            Hide();
            f3.ShowDialog();
            this.Visible = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pf = new DrugForm(directory);
            if (pf.ShowDialog() == DialogResult.OK) { }
            drugBindingSource.ResetBindings(false);
            directory.IsDirty = true;
            var lastIdx = drugGridView.Rows.Count - 1;
            drugGridView.Rows[lastIdx].Selected = true;
            drugGridView.FirstDisplayedScrollingRowIndex = lastIdx;
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var toEdit = drugGridView.SelectedRows[0].DataBoundItem as Drug;
            if (toEdit != null)
            {
                var pf = new DrugForm(toEdit, directory);
                if (pf.ShowDialog() == DialogResult.OK) { }
                drugBindingSource.ResetBindings(false);
                directory.IsDirty = true;
            }
        }
    }
}