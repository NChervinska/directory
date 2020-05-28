namespace DoctorApp
{
    partial class FormSympt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ill = new System.Windows.Forms.Button();
            this.listSympt = new System.Windows.Forms.ListBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // Ill
            // 
            this.Ill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Ill.BackColor = System.Drawing.Color.White;
            this.Ill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpProvider.SetHelpString(this.Ill, "Click to continue");
            this.Ill.Location = new System.Drawing.Point(404, 274);
            this.Ill.Name = "Ill";
            this.helpProvider.SetShowHelp(this.Ill, true);
            this.Ill.Size = new System.Drawing.Size(90, 40);
            this.Ill.TabIndex = 1;
            this.Ill.Text = "Готово";
            this.Ill.UseVisualStyleBackColor = false;
            this.Ill.Click += new System.EventHandler(this.Ill_Click);
            // 
            // listSympt
            // 
            this.listSympt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listSympt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listSympt.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.listSympt, "choose symptoms");
            this.listSympt.ItemHeight = 16;
            this.listSympt.Location = new System.Drawing.Point(150, 50);
            this.listSympt.Name = "listSympt";
            this.listSympt.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.helpProvider.SetShowHelp(this.listSympt, true);
            this.listSympt.Size = new System.Drawing.Size(230, 164);
            this.listSympt.TabIndex = 2;
            this.listSympt.SelectedIndexChanged += new System.EventHandler(this.Changed);
            // 
            // FormSympt
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.listSympt);
            this.Controls.Add(this.Ill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "FormSympt";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.helpProvider.SetShowHelp(this, false);
            this.ShowIcon = false;
            this.Text = "REMEDIUM";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Ill;
        public System.Windows.Forms.ListBox listSympt;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}