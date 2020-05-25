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
            if(LoginBox.Text == "Nurse" && PasswordBox.Text == "12345")
            {
                var f3 = new MainForm(directory);
                Hide();
                f3.ShowDialog();
                this.Visible = true;
                this.Close();
            } 
            else
                MessageBox.Show("Вы ввели неправильный пароль или логин!");
        }
    } 
}
