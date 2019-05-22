namespace TimetableOfClasses
{
	partial class TrainingProfiles
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
			this.dgProfile = new System.Windows.Forms.DataGridView();
			this.AddProfile = new System.Windows.Forms.Button();
			this.ChangeProfile = new System.Windows.Forms.Button();
			this.DeleteProfile = new System.Windows.Forms.Button();
			this.Shiphr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgProfile)).BeginInit();
			this.SuspendLayout();
			// 
			// dgProfile
			// 
			this.dgProfile.AllowUserToAddRows = false;
			this.dgProfile.AllowUserToDeleteRows = false;
			this.dgProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgProfile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgProfile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgProfile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Shiphr,
            this.FullName,
            this.ShortName});
			this.dgProfile.Location = new System.Drawing.Point(12, 12);
			this.dgProfile.Name = "dgProfile";
			this.dgProfile.ReadOnly = true;
			this.dgProfile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgProfile.Size = new System.Drawing.Size(467, 223);
			this.dgProfile.TabIndex = 1;
			this.dgProfile.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgProfile_RowPrePaint);
			this.dgProfile.SelectionChanged += new System.EventHandler(this.dgProfile_SelectionChanged);
			this.dgProfile.DoubleClick += new System.EventHandler(this.DgProfile_DoubleClick);
			// 
			// AddProfile
			// 
			this.AddProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddProfile.Location = new System.Drawing.Point(404, 241);
			this.AddProfile.Name = "AddProfile";
			this.AddProfile.Size = new System.Drawing.Size(75, 23);
			this.AddProfile.TabIndex = 1;
			this.AddProfile.Text = "Добавить";
			this.AddProfile.UseVisualStyleBackColor = true;
			this.AddProfile.Click += new System.EventHandler(this.AddProfile_Click);
			// 
			// ChangeProfile
			// 
			this.ChangeProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ChangeProfile.Location = new System.Drawing.Point(323, 242);
			this.ChangeProfile.Name = "ChangeProfile";
			this.ChangeProfile.Size = new System.Drawing.Size(75, 23);
			this.ChangeProfile.TabIndex = 2;
			this.ChangeProfile.Text = "Изменить";
			this.ChangeProfile.UseVisualStyleBackColor = true;
			this.ChangeProfile.Click += new System.EventHandler(this.ChangeProfile_Click);
			// 
			// DeleteProfile
			// 
			this.DeleteProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteProfile.Location = new System.Drawing.Point(242, 242);
			this.DeleteProfile.Name = "DeleteProfile";
			this.DeleteProfile.Size = new System.Drawing.Size(75, 23);
			this.DeleteProfile.TabIndex = 3;
			this.DeleteProfile.Text = "Удалить";
			this.DeleteProfile.UseVisualStyleBackColor = true;
			this.DeleteProfile.Click += new System.EventHandler(this.DeleteProfile_Click);
			// 
			// Shiphr
			// 
			this.Shiphr.DataPropertyName = "Shiphr";
			this.Shiphr.HeaderText = "Ширф направления подготовки";
			this.Shiphr.Name = "Shiphr";
			this.Shiphr.ReadOnly = true;
			this.Shiphr.Width = 174;
			// 
			// FullName
			// 
			this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FullName.DataPropertyName = "FullName";
			this.FullName.HeaderText = "Полное название профиля подготовки";
			this.FullName.Name = "FullName";
			this.FullName.ReadOnly = true;
			// 
			// ShortName
			// 
			this.ShortName.DataPropertyName = "ShortName";
			this.ShortName.FillWeight = 200F;
			this.ShortName.HeaderText = "Краткое название профиля подготовки";
			this.ShortName.Name = "ShortName";
			this.ShortName.ReadOnly = true;
			this.ShortName.Width = 159;
			// 
			// TrainingProfiles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 268);
			this.Controls.Add(this.DeleteProfile);
			this.Controls.Add(this.ChangeProfile);
			this.Controls.Add(this.AddProfile);
			this.Controls.Add(this.dgProfile);
			this.MinimumSize = new System.Drawing.Size(507, 307);
			this.Name = "TrainingProfiles";
			this.Text = "Профиль подготовки";
			((System.ComponentModel.ISupportInitialize)(this.dgProfile)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView dgProfile;
		private System.Windows.Forms.Button AddProfile;
		private System.Windows.Forms.Button ChangeProfile;
		private System.Windows.Forms.Button DeleteProfile;
		private System.Windows.Forms.DataGridViewTextBoxColumn Shiphr;
		private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ShortName;
	}
}