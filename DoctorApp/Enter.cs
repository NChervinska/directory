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
    public partial class Enter : Form
    {
        public Directory directory;
        public Doctor doctorNow;
        public Enter()
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
                var f2 = new FormSympt();
                Hide();
                f2.ShowDialog();
                this.Visible = true;
            }
            else
                MessageBox.Show("Вы ввели неправильный пароль!");
        }
    }
}
