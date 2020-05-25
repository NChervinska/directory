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
    
    public partial class DrugForm : Form
    {
        public Drug drug;
        Directory directory;
        List<string> ch = new List<string>();
        public DrugForm(Directory directory)
        {
            InitializeComponent();
            this.directory = directory;
            listChange.DataSource = directory.Drugs;
            listChange.ValueMember = "Name";
        }
        public DrugForm(Drug drug, Directory directory) : this(directory)
        {
            this.drug = drug;
            nameBox.Text = drug.Name;
            unitBox.Text = drug.Unit;
            totalBox.Text = Convert.ToString(drug.Total);
        }
        void Changed(object sender, EventArgs e)
        {

            ch.Add((string)listChange.SelectedValue);
        }
        private void OK_Click(object sender, EventArgs e)
        {
            listChange.SelectedIndexChanged += Changed;
            for (int i = 0; i < listChange.SelectedItems.Count; i++)
            {
                ch.Add($"{listChange.SelectedItems[i] as Drug}");
            }
            if (drug == null)
            {
                drug = new Drug { Name = nameBox.Text, Total = Convert.ToInt32(totalBox.Text), Unit = unitBox.Text, Change = ch};
                directory.Drugs.Add(drug);
            }
            drug.Name = nameBox.Text;
            drug.Unit = unitBox.Text;
            drug.Total = Convert.ToInt32(totalBox.Text);
            drug.Change = ch;
            Close();
        } 
        private void totalBox_KetPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }
    }
}
