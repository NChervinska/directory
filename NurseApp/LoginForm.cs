using DirectoryLibrary.Models;
using System;
using System.Windows.Forms;

namespace NurseApp
{
    // Форма для входа медсестры
    public partial class LoginForm : Form
    {
        Directory directory;
        public LoginForm(Directory directory)
        {
            InitializeComponent();

            this.directory = directory;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Nurse" && PasswordBox.Text == "12345")
            {
                var f3 = new MainForm(directory);
                Hide();
                f3.ShowDialog();
                this.Visible = true;
                this.Close();
            }
            else
                MessageBox.Show("You entered the wrong password or username!");
        }
    }
}
