namespace TimetableOfClasses
{
    partial class Groups
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
            this.DG_Group = new System.Windows.Forms.DataGridView();
            this.Шифр = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Численность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Group)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Group
            // 
            this.DG_Group.AllowUserToAddRows = false;
            this.DG_Group.AllowUserToDeleteRows = false;
            this.DG_Group.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Шифр,
            this.Численность});
            this.DG_Group.Location = new System.Drawing.Point(12, 12);
            this.DG_Group.Name = "DG_Group";
            this.DG_Group.ReadOnly = true;
            this.DG_Group.Size = new System.Drawing.Size(375, 365);
            this.DG_Group.TabIndex = 0;
            // 
            // Шифр
            // 
            this.Шифр.HeaderText = "Шифр";
            this.Шифр.Name = "Шифр";
            this.Шифр.ReadOnly = true;
            this.Шифр.Width = 61;
            // 
            // Численность
            // 
            this.Численность.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Численность.HeaderText = "Численность";
            this.Численность.Name = "Численность";
            this.Численность.ReadOnly = true;
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 389);
            this.Controls.Add(this.DG_Group);
            this.Name = "Groups";
            this.Text = "Группы";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Group)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Шифр;
        private System.Windows.Forms.DataGridViewTextBoxColumn Численность;
    }
}