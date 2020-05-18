namespace DoctorApp
{
    partial class Enter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Enter));
            this.ListDoctor = new System.Windows.Forms.ListBox();
            this.Password = new System.Windows.Forms.MaskedTextBox();
            this.Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListDoctor
            // 
            this.ListDoctor.DataSource = this.ListDoctor.CustomTabOffsets;
            this.ListDoctor.FormattingEnabled = true;
            resources.ApplyResources(this.ListDoctor, "ListDoctor");
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
            this.Check.Name = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Enter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ListDoctor);
            this.Name = "Enter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListDoctor;
        private System.Windows.Forms.MaskedTextBox Password;
        private System.Windows.Forms.Button Check;
    }
}

