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

namespace DoctorApp
{
    public partial class FormIll : Form
    {
        public List<string> sympt;
        public Doctor doctor;
        public Directory directory;
        public FormIll(Directory directory, Doctor doctor, List<string> sympt)
        {
            InitializeComponent();

            this.doctor = doctor;
            this.directory = directory;
            this.sympt = sympt;
            List<Illness> ill = new List<Illness>();
            for(int i = 0; i < directory.Illnesses.Count; i++)
            {
                bool x = false;
                for(int j = 0; j < sympt.Count; j++)
                {
                    for(int k = 0; k < directory.Illnesses[i].Symptoms.Count; k++)
                    {
                        if (directory.Illnesses[i].Symptoms[k] == sympt[j])
                            x = true; 
                    }  
                }
                if(x == true)
                    ill.Add(directory.Illnesses[i]);
            }
            IllBindingSource.DataSource = ill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
