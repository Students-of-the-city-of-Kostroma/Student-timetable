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
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Departament = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MetodicalDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Windows = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Weekends = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
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
            this.Number,
            this.FullName,
            this.Note,
            this.Departament,
            this.MetodicalDays,
            this.Windows,
            this.Weekends});
			this.DG.Location = new System.Drawing.Point(12, 12);
			this.DG.MultiSelect = false;
			this.DG.Name = "DG";
			this.DG.ReadOnly = true;
			this.DG.RowHeadersVisible = false;
			this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DG.Size = new System.Drawing.Size(690, 298);
			this.DG.TabIndex = 0;
			this.DG.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_ColumnHeaderMouseClick);
			this.DG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DG_DataBindingComplete);
			this.DG.SelectionChanged += new System.EventHandler(this.DG_SelectionChanged);
			// 
			// Number
			// 
			this.Number.DataPropertyName = "Number";
			this.Number.HeaderText = "";
			this.Number.Name = "Number";
			this.Number.ReadOnly = true;
			// 
			// FullName
			// 
			this.FullName.DataPropertyName = "FullName";
			this.FullName.HeaderText = "ФИО";
			this.FullName.Name = "FullName";
			this.FullName.ReadOnly = true;
			// 
			// Note
			// 
			this.Note.DataPropertyName = "Note";
			this.Note.HeaderText = "Примечание";
			this.Note.Name = "Note";
			this.Note.ReadOnly = true;
			// 
			// Departament
			// 
			this.Departament.DataPropertyName = "Departament";
			this.Departament.HeaderText = "Кафедра";
			this.Departament.Name = "Departament";
			this.Departament.ReadOnly = true;
			// 
			// MetodicalDays
			// 
			this.MetodicalDays.DataPropertyName = "MetodicalDays";
			this.MetodicalDays.HeaderText = "Метод. дни";
			this.MetodicalDays.Name = "MetodicalDays";
			this.MetodicalDays.ReadOnly = true;
			// 
			// Windows
			// 
			this.Windows.DataPropertyName = "Windows";
			this.Windows.HeaderText = "Окна";
			this.Windows.Name = "Windows";
			this.Windows.ReadOnly = true;
			// 
			// Weekends
			// 
			this.Weekends.DataPropertyName = "Weekends";
			this.Weekends.HeaderText = "Выходные";
			this.Weekends.Name = "Weekends";
			this.Weekends.ReadOnly = true;
			this.Weekends.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(631, 323);
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
			this.button2.Location = new System.Drawing.Point(483, 323);
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
			this.button3.Location = new System.Drawing.Point(554, 323);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(71, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Изменить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Update);
			// 
			// Teachers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 354);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.DG);
			this.Name = "Teachers";
			this.Text = "Teachers";
			((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.DataGridView DG;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Note;
		private System.Windows.Forms.DataGridViewTextBoxColumn Departament;
		private System.Windows.Forms.DataGridViewTextBoxColumn MetodicalDays;
		private System.Windows.Forms.DataGridViewTextBoxColumn Windows;
		private System.Windows.Forms.DataGridViewTextBoxColumn Weekends;
		private System.Windows.Forms.Button button3;
	}
}