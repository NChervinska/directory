﻿namespace DoctorApp
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
            this.SuspendLayout();
            // 
            // Ill
            // 
            this.Ill.Location = new System.Drawing.Point(400, 270);
            this.Ill.Name = "Ill";
            this.Ill.Size = new System.Drawing.Size(90, 40);
            this.Ill.TabIndex = 1;
            this.Ill.Text = "Готово";
            this.Ill.UseVisualStyleBackColor = true;
            this.Ill.Click += new System.EventHandler(this.Ill_Click);
            // 
            // listSympt
            // 
            this.listSympt.FormattingEnabled = true;
            this.listSympt.Location = new System.Drawing.Point(150, 50);
            this.listSympt.Name = "listSympt";
            this.listSympt.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listSympt.Size = new System.Drawing.Size(230, 173);
            this.listSympt.TabIndex = 2;
            this.listSympt.SelectedIndexChanged += new System.EventHandler(this.Changed);
            // 
            // FormSympt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.listSympt);
            this.Controls.Add(this.Ill);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "FormSympt";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.Text = "Hi, Doctor!";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Ill;
        public System.Windows.Forms.ListBox listSympt;
    }
}