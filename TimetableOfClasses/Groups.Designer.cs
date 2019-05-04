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
			this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Semestr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Students = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MinNumberOfClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaxNumberOfClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Weekends = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btDelete = new System.Windows.Forms.Button();
			this.btAdd = new System.Windows.Forms.Button();
			this.btUpdate = new System.Windows.Forms.Button();
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
			this.DG_Group.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DG_Group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DG_Group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Group,
            this.Semestr,
            this.Specialty,
            this.Shift,
            this.Students,
            this.MinNumberOfClass,
            this.MaxNumberOfClass,
            this.Weekends});
			this.DG_Group.Location = new System.Drawing.Point(12, 12);
			this.DG_Group.MultiSelect = false;
			this.DG_Group.Name = "DG_Group";
			this.DG_Group.ReadOnly = true;
			this.DG_Group.RowHeadersWidth = 60;
			this.DG_Group.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DG_Group.Size = new System.Drawing.Size(397, 347);
			this.DG_Group.TabIndex = 0;
			this.DG_Group.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Group_ColumnHeaderMouseClick);
			this.DG_Group.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DG_Group_DataBindingComplete);
			this.DG_Group.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DG_Group_RowPrePaint);
			// 
			// Group
			// 
			this.Group.DataPropertyName = "Group";
			this.Group.HeaderText = "Группа";
			this.Group.Name = "Group";
			this.Group.ReadOnly = true;
			// 
			// Semestr
			// 
			this.Semestr.DataPropertyName = "Semestr";
			this.Semestr.HeaderText = "Семестр";
			this.Semestr.Name = "Semestr";
			this.Semestr.ReadOnly = true;
			// 
			// Specialty
			// 
			this.Specialty.DataPropertyName = "Specialty";
			this.Specialty.HeaderText = "Направление подготовки";
			this.Specialty.Name = "Specialty";
			this.Specialty.ReadOnly = true;
			// 
			// Shift
			// 
			this.Shift.DataPropertyName = "Shift";
			this.Shift.HeaderText = "Смена";
			this.Shift.Name = "Shift";
			this.Shift.ReadOnly = true;
			// 
			// Students
			// 
			this.Students.DataPropertyName = "Students";
			this.Students.HeaderText = "Студентов";
			this.Students.Name = "Students";
			this.Students.ReadOnly = true;
			// 
			// MinNumberOfClass
			// 
			this.MinNumberOfClass.DataPropertyName = "MinNumberOfClass";
			this.MinNumberOfClass.HeaderText = "Пар/день min";
			this.MinNumberOfClass.Name = "MinNumberOfClass";
			this.MinNumberOfClass.ReadOnly = true;
			// 
			// MaxNumberOfClass
			// 
			this.MaxNumberOfClass.DataPropertyName = "MaxNumberOfClass";
			this.MaxNumberOfClass.HeaderText = "Пар/день max";
			this.MaxNumberOfClass.Name = "MaxNumberOfClass";
			this.MaxNumberOfClass.ReadOnly = true;
			// 
			// Weekends
			// 
			this.Weekends.DataPropertyName = "Weekends";
			this.Weekends.HeaderText = "Выходные";
			this.Weekends.Name = "Weekends";
			this.Weekends.ReadOnly = true;
			// 
			// btDelete
			// 
			this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btDelete.Location = new System.Drawing.Point(172, 365);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(75, 23);
			this.btDelete.TabIndex = 1;
			this.btDelete.Text = "Удалить";
			this.btDelete.UseVisualStyleBackColor = true;
			this.btDelete.Click += new System.EventHandler(this.DeleteRow);
			// 
			// btAdd
			// 
			this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btAdd.Location = new System.Drawing.Point(334, 365);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(75, 23);
			this.btAdd.TabIndex = 2;
			this.btAdd.Text = "Добавить";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.AddRow);
			// 
			// btUpdate
			// 
			this.btUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btUpdate.Location = new System.Drawing.Point(253, 365);
			this.btUpdate.Name = "btUpdate";
			this.btUpdate.Size = new System.Drawing.Size(75, 23);
			this.btUpdate.TabIndex = 3;
			this.btUpdate.Text = "Изменить";
			this.btUpdate.UseVisualStyleBackColor = true;
			this.btUpdate.Click += new System.EventHandler(this.Update);
			// 
			// Groups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 400);
			this.Controls.Add(this.btUpdate);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.DG_Group);
			this.Name = "Groups";
			this.Text = "Группы";
			((System.ComponentModel.ISupportInitialize)(this.DG_Group)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Group;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btUpdate;
		private System.Windows.Forms.DataGridViewTextBoxColumn Group;
		private System.Windows.Forms.DataGridViewTextBoxColumn Semestr;
		private System.Windows.Forms.DataGridViewTextBoxColumn Specialty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
		private System.Windows.Forms.DataGridViewTextBoxColumn Students;
		private System.Windows.Forms.DataGridViewTextBoxColumn MinNumberOfClass;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaxNumberOfClass;
		private System.Windows.Forms.DataGridViewTextBoxColumn Weekends;
	}
}