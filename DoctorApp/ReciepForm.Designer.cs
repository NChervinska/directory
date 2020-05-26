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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ComentBox = new System.Windows.Forms.TextBox();
            this.SympBox = new System.Windows.Forms.TextBox();
            this.DoctorBox = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.DrugGriedView = new System.Windows.Forms.DataGridView();
            this.TextBoxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.illBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DrugGriedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComentBox
            // 
            this.ComentBox.BackColor = System.Drawing.Color.White;
            this.ComentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComentBox.Location = new System.Drawing.Point(33, 244);
            this.ComentBox.Multiline = true;
            this.ComentBox.Name = "ComentBox";
            this.ComentBox.Size = new System.Drawing.Size(197, 53);
            this.ComentBox.TabIndex = 0;
            this.ComentBox.Text = "Напишите комментарий";
            // 
            // SympBox
            // 
            this.SympBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SympBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SympBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SympBox.Location = new System.Drawing.Point(33, 179);
            this.SympBox.Multiline = true;
            this.SympBox.Name = "SympBox";
            this.SympBox.ReadOnly = true;
            this.SympBox.Size = new System.Drawing.Size(197, 53);
            this.SympBox.TabIndex = 1;
            // 
            // DoctorBox
            // 
            this.DoctorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoctorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DoctorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorBox.Location = new System.Drawing.Point(399, 198);
            this.DoctorBox.Name = "DoctorBox";
            this.DoctorBox.ReadOnly = true;
            this.DoctorBox.Size = new System.Drawing.Size(114, 16);
            this.DoctorBox.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.Location = new System.Drawing.Point(423, 257);
            this.Save.Name = "Save";
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
            this.DrugGriedView.AutoGenerateColumns = false;
            this.DrugGriedView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DrugGriedView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DrugGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrugGriedView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextBoxName,
            this.TextBoxTotal,
            this.TextBoxUnit});
            this.DrugGriedView.DataSource = this.drugBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DrugGriedView.DefaultCellStyle = dataGridViewCellStyle4;
            this.DrugGriedView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DrugGriedView.Location = new System.Drawing.Point(33, 23);
            this.DrugGriedView.Name = "DrugGriedView";
            this.DrugGriedView.ReadOnly = true;
            this.DrugGriedView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DrugGriedView.Size = new System.Drawing.Size(344, 150);
            this.DrugGriedView.TabIndex = 7;
            // 
            // TextBoxName
            // 
            this.TextBoxName.DataPropertyName = "Name";
            this.TextBoxName.HeaderText = "Name";
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.ReadOnly = true;
            this.TextBoxName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TextBoxName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.DataPropertyName = "Total";
            this.TextBoxTotal.HeaderText = "Total";
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.ReadOnly = true;
            this.TextBoxTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TextBoxTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TextBoxUnit
            // 
            this.TextBoxUnit.DataPropertyName = "Unit";
            this.TextBoxUnit.HeaderText = "Unit";
            this.TextBoxUnit.Name = "TextBoxUnit";
            this.TextBoxUnit.ReadOnly = true;
            this.TextBoxUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TextBoxUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataSource = typeof(DirectoryLibrary.Models.Drug);
            // 
            // illBox
            // 
            this.illBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.illBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.illBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.illBox.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.illBox.Location = new System.Drawing.Point(399, 220);
            this.illBox.Name = "illBox";
            this.illBox.ReadOnly = true;
            this.illBox.Size = new System.Drawing.Size(114, 16);
            this.illBox.TabIndex = 8;
            // 
            // ReciepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.illBox);
            this.Controls.Add(this.DrugGriedView);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DoctorBox);
            this.Controls.Add(this.SympBox);
            this.Controls.Add(this.ComentBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "ReciepForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.Text = "REMEDIUM";
            ((System.ComponentModel.ISupportInitialize)(this.DrugGriedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource drugBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextBoxTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextBoxUnit;
        public System.Windows.Forms.DataGridView DrugGriedView;
        private System.Windows.Forms.TextBox illBox;
    }
}