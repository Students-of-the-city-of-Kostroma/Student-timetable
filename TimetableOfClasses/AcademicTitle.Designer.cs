namespace TimetableOfClasses
{
    partial class AcademicTitle
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
            this.DG_AcademicTitle = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_AcademicTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_AcademicTitle
            // 
            this.DG_AcademicTitle.AllowUserToAddRows = false;
            this.DG_AcademicTitle.AllowUserToDeleteRows = false;
            this.DG_AcademicTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_AcademicTitle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_AcademicTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_AcademicTitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Reduction});
            this.DG_AcademicTitle.Location = new System.Drawing.Point(12, 12);
            this.DG_AcademicTitle.Name = "DG_AcademicTitle";
            this.DG_AcademicTitle.ReadOnly = true;
            this.DG_AcademicTitle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_AcademicTitle.Size = new System.Drawing.Size(562, 215);
            this.DG_AcademicTitle.TabIndex = 0;
            this.DG_AcademicTitle.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DG_AcademicTitle_RowPrePaint);
            this.DG_AcademicTitle.DoubleClick += new System.EventHandler(this.DG_AcademicTitle_DoubleClick);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Полная запись ученого звания";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Reduction
            // 
            this.Reduction.DataPropertyName = "Reduction";
            this.Reduction.HeaderText = "Сокращенная запись ученого звания";
            this.Reduction.Name = "Reduction";
            this.Reduction.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Location = new System.Drawing.Point(499, 233);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.Location = new System.Drawing.Point(337, 233);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Change
            // 
            this.Change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Change.Location = new System.Drawing.Point(418, 233);
            this.Change.Name = "Change";
            this.Change.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Change.Size = new System.Drawing.Size(75, 23);
            this.Change.TabIndex = 3;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // AcademicTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 268);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DG_AcademicTitle);
            this.Name = "AcademicTitle";
            this.Text = "Ученые звания";
            ((System.ComponentModel.ISupportInitialize)(this.DG_AcademicTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_AcademicTitle;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reduction;
    }
}