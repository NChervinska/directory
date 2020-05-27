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
            this.Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListDoctor
            // 
            this.ListDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ListDoctor.DataSource = this.ListDoctor.CustomTabOffsets;
            resources.ApplyResources(this.ListDoctor, "ListDoctor");
            this.ListDoctor.FormattingEnabled = true;
            this.ListDoctor.Name = "ListDoctor";
            // 
            // Password
            // 
            resources.ApplyResources(this.Password, "Password");
            this.Password.Name = "Password";
            this.Password.UseSystemPasswordChar = true;
            // 
            // Check
            // 
            resources.ApplyResources(this.Check, "Check");
            this.Check.BackColor = System.Drawing.Color.White;
            this.Check.Name = "Check";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // medc
            // 
            resources.ApplyResources(this.medc, "medc");
            this.medc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.medc.Name = "medc";
            this.medc.UseVisualStyleBackColor = false;
            this.medc.Click += new System.EventHandler(this.medc_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Help, "Help");
            this.Help.Name = "Help";
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // FormStart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.Help);
            this.Controls.Add(this.medc);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ListDoctor);
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
        private System.Windows.Forms.Button Help;
    }
}

