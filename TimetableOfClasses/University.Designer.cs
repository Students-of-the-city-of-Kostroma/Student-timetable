namespace TimetableOfClasses
{
	partial class University
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
			this.INN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shortname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fulltitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.actualaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.legaladdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.namerector = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.delete = new System.Windows.Forms.Button();
			this.add = new System.Windows.Forms.Button();
			this.update = new System.Windows.Forms.Button();
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
            this.INN,
            this.shortname,
            this.fulltitle,
            this.actualaddress,
            this.legaladdress,
            this.namerector,
            this.mail,
            this.phone});
			this.DG.Location = new System.Drawing.Point(12, 12);
			this.DG.MultiSelect = false;
			this.DG.Name = "DG";
			this.DG.ReadOnly = true;
			this.DG.RowHeadersWidth = 60;
			this.DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DG.Size = new System.Drawing.Size(700, 309);
			this.DG.TabIndex = 0;
			this.DG.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellDoubleClick);
			this.DG.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_ColumnHeaderMouseClick);
			this.DG.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DG_DataBindingComplete);
			this.DG.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DG_RowPrePaint);
			// 
			// INN
			// 
			this.INN.DataPropertyName = "INN";
			this.INN.HeaderText = "ИНН";
			this.INN.Name = "INN";
			this.INN.ReadOnly = true;
			// 
			// shortname
			// 
			this.shortname.DataPropertyName = "ShortName";
			this.shortname.HeaderText = "Краткое название";
			this.shortname.Name = "shortname";
			this.shortname.ReadOnly = true;
			// 
			// fulltitle
			// 
			this.fulltitle.DataPropertyName = "FullName";
			this.fulltitle.HeaderText = "Полное название";
			this.fulltitle.Name = "fulltitle";
			this.fulltitle.ReadOnly = true;
			// 
			// actualaddress
			// 
			this.actualaddress.DataPropertyName = "ActualAddress";
			this.actualaddress.HeaderText = "Фактический адрес";
			this.actualaddress.Name = "actualaddress";
			this.actualaddress.ReadOnly = true;
			// 
			// legaladdress
			// 
			this.legaladdress.DataPropertyName = "LegalAddress";
			this.legaladdress.HeaderText = "Юридический адрес";
			this.legaladdress.Name = "legaladdress";
			this.legaladdress.ReadOnly = true;
			// 
			// namerector
			// 
			this.namerector.DataPropertyName = "FullNameRector";
			this.namerector.HeaderText = "ФИО ректора";
			this.namerector.Name = "namerector";
			this.namerector.ReadOnly = true;
			// 
			// mail
			// 
			this.mail.DataPropertyName = "Email";
			this.mail.HeaderText = "Почта";
			this.mail.Name = "mail";
			this.mail.ReadOnly = true;
			// 
			// phone
			// 
			this.phone.DataPropertyName = "Phone";
			this.phone.HeaderText = "Телефон";
			this.phone.Name = "phone";
			this.phone.ReadOnly = true;
			// 
			// delete
			// 
			this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.delete.Location = new System.Drawing.Point(475, 327);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(75, 23);
			this.delete.TabIndex = 1;
			this.delete.Text = "Удалить";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.Delete);
			// 
			// add
			// 
			this.add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.add.Location = new System.Drawing.Point(637, 327);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(75, 23);
			this.add.TabIndex = 2;
			this.add.Text = "Добавить";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.Add);
			// 
			// update
			// 
			this.update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.update.Location = new System.Drawing.Point(556, 327);
			this.update.Name = "update";
			this.update.Size = new System.Drawing.Size(75, 23);
			this.update.TabIndex = 3;
			this.update.Text = "Изменить";
			this.update.UseVisualStyleBackColor = true;
			this.update.Click += new System.EventHandler(this.Update);
			// 
			// University
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 362);
			this.Controls.Add(this.update);
			this.Controls.Add(this.add);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.DG);
			this.Name = "University";
			this.Text = "ВУЗы";
			((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView DG;
		private System.Windows.Forms.DataGridViewTextBoxColumn INN;
		private System.Windows.Forms.DataGridViewTextBoxColumn shortname;
		private System.Windows.Forms.DataGridViewTextBoxColumn fulltitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn actualaddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn legaladdress;
		private System.Windows.Forms.DataGridViewTextBoxColumn namerector;
		private System.Windows.Forms.DataGridViewTextBoxColumn mail;
		private System.Windows.Forms.DataGridViewTextBoxColumn phone;
		protected internal System.Windows.Forms.Button delete;
		protected internal System.Windows.Forms.Button add;
		protected internal System.Windows.Forms.Button update;
	}
}