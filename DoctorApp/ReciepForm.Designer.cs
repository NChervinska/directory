namespace DoctorApp
{
    partial class ReciepForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReciepForm));
            this.ComentBox = new System.Windows.Forms.TextBox();
            this.SympBox = new System.Windows.Forms.TextBox();
            this.DoctorBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.DrugGriedView = new System.Windows.Forms.DataGridView();
            this.illBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.DrugGriedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComentBox
            // 
            this.ComentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComentBox.BackColor = System.Drawing.Color.White;
            this.ComentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpProvider.SetHelpString(this.ComentBox, "Enter commets");
            this.ComentBox.Location = new System.Drawing.Point(34, 281);
            this.ComentBox.Multiline = true;
            this.ComentBox.Name = "ComentBox";
            this.helpProvider.SetShowHelp(this.ComentBox, true);
            this.ComentBox.Size = new System.Drawing.Size(197, 53);
            this.ComentBox.TabIndex = 0;
            this.ComentBox.Text = "Напишите комментарий";
            // 
            // SympBox
            // 
            this.SympBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SympBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SympBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SympBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SympBox.Location = new System.Drawing.Point(34, 215);
            this.SympBox.Multiline = true;
            this.SympBox.Name = "SympBox";
            this.SympBox.ReadOnly = true;
            this.SympBox.Size = new System.Drawing.Size(197, 53);
            this.SympBox.TabIndex = 1;
            // 
            // DoctorBox
            // 
            this.DoctorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoctorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DoctorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorBox.Location = new System.Drawing.Point(408, 215);
            this.DoctorBox.Name = "DoctorBox";
            this.DoctorBox.ReadOnly = true;
            this.DoctorBox.Size = new System.Drawing.Size(114, 16);
            this.DoctorBox.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpProvider.SetHelpString(this.Save, "Click if all ready");
            this.Save.Location = new System.Drawing.Point(432, 294);
            this.Save.Name = "Save";
            this.helpProvider.SetShowHelp(this.Save, true);
            this.Save.Size = new System.Drawing.Size(90, 40);
            this.Save.TabIndex = 5;
            this.Save.Text = "Готово";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DrugGriedView
            // 
            this.DrugGriedView.AllowUserToDeleteRows = false;
            this.DrugGriedView.AllowUserToResizeColumns = false;
            this.DrugGriedView.AllowUserToResizeRows = false;
            this.DrugGriedView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DrugGriedView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DrugGriedView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DrugGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DrugGriedView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DrugGriedView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.DrugGriedView, "Choose drugs");
            this.DrugGriedView.Location = new System.Drawing.Point(234, 10);
            this.DrugGriedView.Name = "DrugGriedView";
            this.DrugGriedView.ReadOnly = true;
            this.DrugGriedView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.DrugGriedView, true);
            this.DrugGriedView.Size = new System.Drawing.Size(344, 150);
            this.DrugGriedView.TabIndex = 7;
            // 
            // illBox
            // 
            this.illBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.illBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.illBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.illBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.illBox.Location = new System.Drawing.Point(408, 237);
            this.illBox.Name = "illBox";
            this.illBox.ReadOnly = true;
            this.illBox.Size = new System.Drawing.Size(114, 16);
            this.illBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ReciepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.illBox);
            this.Controls.Add(this.DrugGriedView);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DoctorBox);
            this.Controls.Add(this.SympBox);
            this.Controls.Add(this.ComentBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "ReciepForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.Text = "REMEDIUM";
            ((System.ComponentModel.ISupportInitialize)(this.DrugGriedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ComentBox;
        private System.Windows.Forms.TextBox SympBox;
        private System.Windows.Forms.TextBox DoctorBox;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        public System.Windows.Forms.DataGridView DrugGriedView;
        private System.Windows.Forms.TextBox illBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}