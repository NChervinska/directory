using DirectoryLibrary.Models;
using System;
using System.IO;
using System.Windows.Forms;
using Directory = DirectoryLibrary.Models.Directory;

namespace DoctorApp
{
    // Форма для входа
    public partial class FormStart : Form
    {
        Directory directory;
        Doctor doctorNow;
        public FormStart()
        {
            InitializeComponent();

            directory = new Directory();
            directory.FillTestData(100);

            ListDoctor.DataSource = directory.Doctors;
            ListDoctor.DisplayMember = "Name";
            
        }

        private void Check_Click(object sender, EventArgs e)
        {
            doctorNow = ListDoctor.SelectedItem as Doctor;
            var pass = Password.Text;
            if (pass == doctorNow.Password)
            {
                var f2 = new FormSympt(directory, doctorNow);
                Hide();
                f2.ShowDialog();
                this.Visible = true;
            }
            else
                MessageBox.Show("You entered the wrong password!");
        }

        private void medc_Click(object sender, EventArgs e)
        {
            var f2 = new NurseApp.LoginForm(directory);
            Hide();
            f2.ShowDialog();
            this.Visible = true;
        }
    }
}
