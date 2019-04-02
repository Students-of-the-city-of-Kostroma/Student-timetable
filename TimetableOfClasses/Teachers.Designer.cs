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
			this.Number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Note1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Department1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Methodays = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Window = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Weekends1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Number1,
            this.FIO,
            this.Note1,
            this.Department1,
            this.Methodays,
            this.Window,
            this.Weekends1});
			this.DG.Location = new System.Drawing.Point(12, 12);
			this.DG.Name = "DG";
			this.DG.ReadOnly = true;
			this.DG.RowHeadersVisible = false;
			this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DG.Size = new System.Drawing.Size(690, 287);
			this.DG.TabIndex = 0;
			this.DG.SelectionChanged += new System.EventHandler(this.DG_SelectionChanged);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(608, 305);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 36);
			this.button1.TabIndex = 1;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.AddTeacher);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(508, 305);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 36);
			this.button2.TabIndex = 2;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.RemoveTeacher);
			// 
			// Number1
			// 
			this.Number1.DataPropertyName = "Number";
			this.Number1.HeaderText = "";
			this.Number1.Name = "Number1";
			this.Number1.ReadOnly = true;
			// 
			// FIO
			// 
			this.FIO.DataPropertyName = "FullName";
			this.FIO.HeaderText = "ФИО";
			this.FIO.Name = "FIO";
			this.FIO.ReadOnly = true;
			// 
			// Note1
			// 
			this.Note1.DataPropertyName = "Note";
			this.Note1.HeaderText = "Примечание";
			this.Note1.Name = "Note1";
			this.Note1.ReadOnly = true;
			// 
			// Department1
			// 
			this.Department1.DataPropertyName = "Departament";
			this.Department1.HeaderText = "Кафедра";
			this.Department1.Name = "Department1";
			this.Department1.ReadOnly = true;
			// 
			// Methodays
			// 
			this.Methodays.DataPropertyName = "MetodicalDays";
			this.Methodays.HeaderText = "Метод. дни";
			this.Methodays.Name = "Methodays";
			this.Methodays.ReadOnly = true;
			// 
			// Window
			// 
			this.Window.DataPropertyName = "Windows";
			this.Window.HeaderText = "Окна";
			this.Window.Name = "Window";
			this.Window.ReadOnly = true;
			// 
			// Weekends1
			// 
			this.Weekends1.DataPropertyName = "Weekends";
			this.Weekends1.HeaderText = "Выходные";
			this.Weekends1.Name = "Weekends1";
			this.Weekends1.ReadOnly = true;
			// 
			// Teachers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 343);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn Number1;
		private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
		private System.Windows.Forms.DataGridViewTextBoxColumn Note1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Department1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Methodays;
		private System.Windows.Forms.DataGridViewTextBoxColumn Window;
		private System.Windows.Forms.DataGridViewTextBoxColumn Weekends1;
	}
}