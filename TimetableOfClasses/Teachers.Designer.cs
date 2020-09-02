namespace TimetableOfClasses
{
    partial class Teachers
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
            this.DG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetodicalDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Windows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weekends = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            this.SuspendLayout();
            // 
            // DG
            // 
            this.DG.AllowUserToAddRows = false;
            this.DG.AllowUserToDeleteRows = false;
            this.DG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.AcademicDegree,
            this.aTitle,
            this.Post,
            this.Departament,
            this.MetodicalDays,
            this.Windows,
            this.Weekends});
            this.DG.Location = new System.Drawing.Point(12, 12);
            this.DG.MultiSelect = false;
            this.DG.Name = "DG";
            this.DG.ReadOnly = true;
            this.DG.RowHeadersWidth = 60;
            this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG.Size = new System.Drawing.Size(807, 344);
            this.DG.TabIndex = 0;
            this.DG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellContentClick);
            this.DG.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_ColumnHeaderMouseClick);
            this.DG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DG_DataBindingComplete);
            this.DG.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DG_RowPrePaint);
            this.DG.SelectionChanged += new System.EventHandler(this.DG_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(748, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddTeacher);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(600, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RemoveTeacher);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(671, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Update);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 95.63452F;
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // AcademicDegree
            // 
            this.AcademicDegree.DataPropertyName = "AcademicDegree";
            this.AcademicDegree.FillWeight = 121.8274F;
            this.AcademicDegree.HeaderText = "Учёная степень";
            this.AcademicDegree.Name = "AcademicDegree";
            this.AcademicDegree.ReadOnly = true;
            // 
            // aTitle
            // 
            this.aTitle.DataPropertyName = "AcademicTitle";
            this.aTitle.HeaderText = "Учёное звание";
            this.aTitle.Name = "aTitle";
            this.aTitle.ReadOnly = true;
            // 
            // Post
            // 
            this.Post.HeaderText = "Должность";
            this.Post.Name = "Post";
            this.Post.ReadOnly = true;
            // 
            // Departament
            // 
            this.Departament.DataPropertyName = "Departament";
            this.Departament.FillWeight = 95.63452F;
            this.Departament.HeaderText = "Кафедра";
            this.Departament.Name = "Departament";
            this.Departament.ReadOnly = true;
            // 
            // MetodicalDays
            // 
            this.MetodicalDays.DataPropertyName = "MetodicalDays";
            this.MetodicalDays.FillWeight = 95.63452F;
            this.MetodicalDays.HeaderText = "Метод. дни";
            this.MetodicalDays.Name = "MetodicalDays";
            this.MetodicalDays.ReadOnly = true;
            // 
            // Windows
            // 
            this.Windows.DataPropertyName = "Windows";
            this.Windows.FillWeight = 95.63452F;
            this.Windows.HeaderText = "Окна";
            this.Windows.Name = "Windows";
            this.Windows.ReadOnly = true;
            // 
            // Weekends
            // 
            this.Weekends.DataPropertyName = "Weekends";
            this.Weekends.FillWeight = 95.63452F;
            this.Weekends.HeaderText = "Выходные";
            this.Weekends.Name = "Weekends";
            this.Weekends.ReadOnly = true;
            this.Weekends.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 400);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DG);
            this.Name = "Teachers";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departament;
        private System.Windows.Forms.DataGridViewTextBoxColumn MetodicalDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn Windows;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weekends;
    }
}