using DirectoryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoctorApp
{ 
    // Форма, гда врач выбирает болезнь
    public partial class FormIll : Form
    {
        List<string> sympt;
        Doctor doctor;
        Directory directory;
        Illness illNow;
        public FormIll(Directory directory, Doctor doctor, List<string> sympt)
        {
            InitializeComponent();

            this.doctor = doctor;
            this.directory = directory;
            this.sympt = sympt;

            List<Illness> ill = new List<Illness>();
            for (int i = 0; i < directory.Illnesses.Count; i++)
            {
                bool ToAdd = false;
                for (int j = 0; j < sympt.Count; j++)
                {
                    for (int k = 0; k < directory.Illnesses[i].Symptoms.Count; k++)
                    {
                        if (directory.Illnesses[i].Symptoms[k] == sympt[j])
                            ToAdd = true;
                    }
                }
                if (ToAdd)
                    ill.Add(directory.Illnesses[i]);
            }
            listIll.DataSource = ill;
            listIll.DisplayMember = "Name";
        }

        private void Next_Click(object sender, EventArgs e)
        {
            illNow = listIll.SelectedItem as Illness;
            var f4 = new ReciepForm(directory, doctor, illNow);
            Hide();
            f4.ShowDialog();
            this.Visible = true;
            this.Close();
        }
    }
}
