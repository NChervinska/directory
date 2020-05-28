using DirectoryLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Directory = DirectoryLibrary.Models.Directory;

namespace DoctorApp
{
    // Форма, где врач выписывает рецепт
    public partial class ReciepForm : Form
    {
        Directory directory;
        Doctor doctor;
        Illness ill;
        List<Drug> drug = new List<Drug>();
        public ReciepForm(Directory directory, Doctor doctor, Illness ill)
        {
            InitializeComponent();

            this.directory = directory;
            this.doctor = doctor;
            this.ill = ill;
            string symp = ill.Symptoms[0];
            for (int i = 1; i < ill.Symptoms.Count; i++)
                symp += $", {ill.Symptoms[i]}";
            SympBox.Text = symp;
            DoctorBox.Text = doctor.Name;
            illBox.Text = ill.Name;
            for (int i = 0; i < ill.Portions.Count; i++)
            {
                var portion = ill.Portions[i];
                if (ill.Portions[i].Drug.Total - ill.Portions[i].Amount > 0)
                    drug.Add(new Drug { Name = portion.Drug.Name, Total = portion.Amount, Unit = portion.Drug.Unit, Change = null });
                for (int j = 0; j < portion.Drug.Change.Count; j++)
                {
                    Drug dr = GetDrugByName(portion.Drug.Change[j]);
                    if (dr.Total - portion.Amount > 0)
                        drug.Add(new Drug { Name = dr.Name, Total = portion.Amount, Unit = dr.Unit, Change = null });
                }
            }
            if (drug == null)
                DrugGriedView.DataSource = "Лекарств нет";
            else
                DrugGriedView.DataSource = drug;
        }
        private Drug GetDrugByName(string drug)
        {
            if (drug.Substring(0, 4) == "Drug")
            {
                int ind = Convert.ToInt32(drug.Substring(4));
                return directory.Drugs[ind];
            }
            return directory.Drugs[0];
        }

        private void Save_Click(object sender, EventArgs e)
        {
            List<Portion> portions = new List<Portion>();
            
            using (var wr = new StreamWriter("NewRecipe.txt"))
            {
                wr.WriteLine(doctor.Name);
                wr.WriteLine(ill.Name);
                foreach (DataGridViewRow row in DrugGriedView.SelectedRows)
                {
                    int ind = row.Index;
                    wr.WriteLine($"{drug[ind].Name} {drug[ind].Total} {drug[ind].Unit}");
                    portions.Add(new Portion { Drug = GetDrugByName(drug[ind].Name), Amount = drug[ind].Total });
                }
                wr.WriteLine(DateTime.Now);
                if (ComentBox.Text != "Напишите комментарий" && ComentBox.Text != null)
                    wr.WriteLine(ComentBox.Text);
                ill.Portions = portions; 
                directory.Recipes.Add(new Recipe(doctor, ill));
            }
            Close();
        }
    }
}
