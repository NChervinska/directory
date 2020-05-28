namespace DoctorApp
{
    partial class FormStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.ListDoctor = new System.Windows.Forms.ListBox();
            this.Password = new System.Windows.Forms.MaskedTextBox();
            this.Check = new System.Windows.Forms.Button();
            this.medc = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // ListDoctor
            // 
            this.ListDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ListDoctor.DataSource = this.ListDoctor.CustomTabOffsets;
            resources.ApplyResources(this.ListDoctor, "ListDoctor");
            this.ListDoctor.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.ListDoctor, resources.GetString("ListDoctor.HelpString"));
            this.ListDoctor.Name = "ListDoctor";
            this.helpProvider.SetShowHelp(this.ListDoctor, ((bool)(resources.GetObject("ListDoctor.ShowHelp"))));
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.helpProvider.SetHelpString(this.Password, resources.GetString("Password.HelpString"));
            this.Password.Name = "Password";
            this.helpProvider.SetShowHelp(this.Password, ((bool)(resources.GetObject("Password.ShowHelp"))));
            this.Password.UseSystemPasswordChar = true;
            // 
            // Check
            // 
            resources.ApplyResources(this.Check, "Check");
            this.Check.BackColor = System.Drawing.Color.White;
            this.helpProvider.SetHelpString(this.Check, resources.GetString("Check.HelpString"));
            this.Check.Name = "Check";
            this.helpProvider.SetShowHelp(this.Check, ((bool)(resources.GetObject("Check.ShowHelp"))));
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // medc
            // 
            resources.ApplyResources(this.medc, "medc");
            this.medc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.medc, resources.GetString("medc.HelpString"));
            this.medc.Name = "medc";
            this.helpProvider.SetShowHelp(this.medc, ((bool)(resources.GetObject("medc.ShowHelp"))));
            this.medc.UseVisualStyleBackColor = false;
            this.medc.Click += new System.EventHandler(this.medc_Click);
            // 
            // FormStart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.medc);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ListDoctor);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStart";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListDoctor;
        private System.Windows.Forms.MaskedTextBox Password;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button medc;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}

