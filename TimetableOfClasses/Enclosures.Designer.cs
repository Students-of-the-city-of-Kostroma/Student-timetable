namespace TimetableOfClasses
{
	partial class Enclosures
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
			this.DG = new System.Windows.Forms.DataGridView();
			this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CUniversity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Delete1 = new System.Windows.Forms.Button();
			this.Update1 = new System.Windows.Forms.Button();
			this.Create1 = new System.Windows.Forms.Button();
			this.сEnclosuresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.сEnclosuresBindingSource)).BeginInit();
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
            this.CName,
            this.CUniversity,
            this.CAddress,
            this.CPhone,
            this.CComment});
			this.DG.Location = new System.Drawing.Point(12, 12);
			this.DG.MultiSelect = false;
			this.DG.Name = "DG";
			this.DG.ReadOnly = true;
			this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DG.Size = new System.Drawing.Size(672, 283);
			this.DG.TabIndex = 0;
			this.DG.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_ColumnHeaderMouseClick);
			this.DG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DG_DataBindingComplete);
			this.DG.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DG_RowPrePaint);
			this.DG.DoubleClick += new System.EventHandler(this.DG_DoubleClick);
			// 
			// CName
			// 
			this.CName.DataPropertyName = "Name";
			this.CName.HeaderText = "Наименование";
			this.CName.Name = "CName";
			this.CName.ReadOnly = true;
			// 
			// CUniversity
			// 
			this.CUniversity.DataPropertyName = "University";
			this.CUniversity.HeaderText = "ВУЗ";
			this.CUniversity.Name = "CUniversity";
			this.CUniversity.ReadOnly = true;
			// 
			// CAddress
			// 
			this.CAddress.DataPropertyName = "Address";
			this.CAddress.HeaderText = "Адрес";
			this.CAddress.Name = "CAddress";
			this.CAddress.ReadOnly = true;
			// 
			// CPhone
			// 
			this.CPhone.DataPropertyName = "Phone";
			this.CPhone.HeaderText = "Номер";
			this.CPhone.Name = "CPhone";
			this.CPhone.ReadOnly = true;
			// 
			// CComment
			// 
			this.CComment.DataPropertyName = "Comment";
			this.CComment.HeaderText = "Примечание";
			this.CComment.Name = "CComment";
			this.CComment.ReadOnly = true;
			// 
			// Delete1
			// 
			this.Delete1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Delete1.Location = new System.Drawing.Point(447, 301);
			this.Delete1.Name = "Delete1";
			this.Delete1.Size = new System.Drawing.Size(75, 23);
			this.Delete1.TabIndex = 1;
			this.Delete1.Text = "Удалить";
			this.Delete1.UseVisualStyleBackColor = true;
			this.Delete1.Click += new System.EventHandler(this.Deletet);
			// 
			// Update1
			// 
			this.Update1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Update1.Location = new System.Drawing.Point(528, 301);
			this.Update1.Name = "Update1";
			this.Update1.Size = new System.Drawing.Size(75, 23);
			this.Update1.TabIndex = 2;
			this.Update1.Text = "Изменить";
			this.Update1.UseVisualStyleBackColor = true;
			this.Update1.Click += new System.EventHandler(this.Updatet);
			// 
			// Create1
			// 
			this.Create1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Create1.Location = new System.Drawing.Point(609, 301);
			this.Create1.Name = "Create1";
			this.Create1.Size = new System.Drawing.Size(75, 23);
			this.Create1.TabIndex = 3;
			this.Create1.Text = "Добавить";
			this.Create1.UseVisualStyleBackColor = true;
			this.Create1.Click += new System.EventHandler(this.Added);
			// 
			// сEnclosuresBindingSource
			// 
			this.сEnclosuresBindingSource.DataSource = typeof(LibOfTimetableOfClasses.СEnclosures);
			// 
			// Enclosures
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 336);
			this.Controls.Add(this.Create1);
			this.Controls.Add(this.Update1);
			this.Controls.Add(this.Delete1);
			this.Controls.Add(this.DG);
			this.Name = "Enclosures";
			this.Text = "Корпуса";
			((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.сEnclosuresBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView DG;
		private System.Windows.Forms.Button Delete1;
		private System.Windows.Forms.Button Update1;
		private System.Windows.Forms.Button Create1;
		private System.Windows.Forms.DataGridViewTextBoxColumn CName;
		private System.Windows.Forms.DataGridViewTextBoxColumn CUniversity;
		private System.Windows.Forms.DataGridViewTextBoxColumn CAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn CPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn CComment;
		private System.Windows.Forms.BindingSource сEnclosuresBindingSource;
	}
}