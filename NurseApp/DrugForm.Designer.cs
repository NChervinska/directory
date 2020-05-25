namespace NurseApp
{
    partial class DrugForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.listChange = new System.Windows.Forms.ListBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(317, 38);
            this.nameBox.MaxLength = 10;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(116, 23);
            this.nameBox.TabIndex = 0;
            // 
            // totalBox
            // 
            this.totalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalBox.Location = new System.Drawing.Point(317, 105);
            this.totalBox.MaxLength = 10;
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(116, 23);
            this.totalBox.TabIndex = 1;
            this.totalBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalBox_KetPress);
            // 
            // unitBox
            // 
            this.unitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unitBox.Location = new System.Drawing.Point(317, 176);
            this.unitBox.MaxLength = 5;
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(116, 23);
            this.unitBox.TabIndex = 2;
            // 
            // listChange
            // 
            this.listChange.FormattingEnabled = true;
            this.listChange.Location = new System.Drawing.Point(43, 38);
            this.listChange.Name = "listChange";
            this.listChange.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listChange.Size = new System.Drawing.Size(160, 225);
            this.listChange.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.White;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OK.Location = new System.Drawing.Point(317, 232);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(116, 31);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // DrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.listChange);
            this.Controls.Add(this.unitBox);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DrugForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.Text = "REMEDIUM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.ListBox listChange;
        private System.Windows.Forms.Button OK;
    }
}