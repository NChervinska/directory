﻿using DirectoryLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoctorApp
{
    // Форма, где врач выбирает симптомы
    public partial class FormSympt : Form
    {
        List<string> symptomNow = new List<string>();
        public Directory direct;
        public Doctor doctor;

        public FormSympt(Directory direct, Doctor doctor)
        {
            InitializeComponent();

            this.direct = direct;
            this.doctor = doctor;

            List<string> sym = new List<string>();
            for (int i = 0; i < 16; i++)
                sym.Add($"Symptom{i}");
            listSympt.DataSource = sym;

        }
        private void Changed(object sender, EventArgs e)
        {
            symptomNow.Add((string)listSympt.SelectedValue);
        }
        private void Ill_Click(object sender, EventArgs e)
        {
            listSympt.SelectedIndexChanged += Changed;
            for (int i = 0; i < listSympt.SelectedItems.Count; i++)
            {
                symptomNow.Add($"{listSympt.SelectedItems[i]}");
            }
            if (listSympt.SelectedItems.Count == 0)
                MessageBox.Show("Choose symptoms!");
            else
            {
                var f3 = new FormIll(direct, doctor, symptomNow);
                Hide();
                f3.ShowDialog();
                this.Visible = true;
                this.Close();
            }

        }
    }
}
