namespace TimetableOfClasses
{
    partial class Auditor
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
			this.DataGridAuditor = new System.Windows.Forms.DataGridView();
			this.NameOfAuditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cafedra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Spacious = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Building = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btAddAuditor = new System.Windows.Forms.Button();
			this.btDelAuditor = new System.Windows.Forms.Button();
			this.btChange = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DataGridAuditor)).BeginInit();
			this.SuspendLayout();
			// 
			// DataGridAuditor
			// 
			this.DataGridAuditor.AllowUserToAddRows = false;
			this.DataGridAuditor.AllowUserToDeleteRows = false;
			this.DataGridAuditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DataGridAuditor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DataGridAuditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridAuditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfAuditor,
            this.Cafedra,
            this.Spacious,
            this.Building});
			this.DataGridAuditor.Location = new System.Drawing.Point(12, 12);
			this.DataGridAuditor.Name = "DataGridAuditor";
			this.DataGridAuditor.ReadOnly = true;
			this.DataGridAuditor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridAuditor.Size = new System.Drawing.Size(467, 225);
			this.DataGridAuditor.TabIndex = 1;
			this.DataGridAuditor.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridAuditor_RowPrePaint);
			this.DataGridAuditor.SelectionChanged += new System.EventHandler(this.DataGridAuditor_SelectionChanged);
			// 
			// NameOfAuditor
			// 
			this.NameOfAuditor.DataPropertyName = "NameOfAuditor";
			this.NameOfAuditor.HeaderText = "Аудитория";
			this.NameOfAuditor.Name = "NameOfAuditor";
			this.NameOfAuditor.ReadOnly = true;
			this.NameOfAuditor.Width = 85;
			// 
			// Cafedra
			// 
			this.Cafedra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Cafedra.DataPropertyName = "Cafedra";
			this.Cafedra.HeaderText = "Кафедра";
			this.Cafedra.Name = "Cafedra";
			this.Cafedra.ReadOnly = true;
			// 
			// Spacious
			// 
			this.Spacious.DataPropertyName = "Spacious";
			this.Spacious.HeaderText = "Число мест";
			this.Spacious.Name = "Spacious";
			this.Spacious.ReadOnly = true;
			this.Spacious.Width = 92;
			// 
			// Building
			// 
			this.Building.DataPropertyName = "Building";
			this.Building.HeaderText = "Корпус";
			this.Building.Name = "Building";
			this.Building.ReadOnly = true;
			this.Building.Width = 68;
			// 
			// btAddAuditor
			// 
			this.btAddAuditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btAddAuditor.Location = new System.Drawing.Point(12, 241);
			this.btAddAuditor.Name = "btAddAuditor";
			this.btAddAuditor.Size = new System.Drawing.Size(75, 23);
			this.btAddAuditor.TabIndex = 2;
			this.btAddAuditor.Text = "Добавить";
			this.btAddAuditor.UseVisualStyleBackColor = true;
			this.btAddAuditor.Click += new System.EventHandler(this.btAddAuditor_Click);
			// 
			// btDelAuditor
			// 
			this.btDelAuditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btDelAuditor.Enabled = false;
			this.btDelAuditor.Location = new System.Drawing.Point(174, 241);
			this.btDelAuditor.Name = "btDelAuditor";
			this.btDelAuditor.Size = new System.Drawing.Size(75, 23);
			this.btDelAuditor.TabIndex = 3;
			this.btDelAuditor.Text = "Удалить";
			this.btDelAuditor.UseVisualStyleBackColor = true;
			this.btDelAuditor.Click += new System.EventHandler(this.btDelAuditor_Click);
			// 
			// btChange
			// 
			this.btChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btChange.Enabled = false;
			this.btChange.Location = new System.Drawing.Point(93, 241);
			this.btChange.Name = "btChange";
			this.btChange.Size = new System.Drawing.Size(75, 23);
			this.btChange.TabIndex = 4;
			this.btChange.Text = "Изменить";
			this.btChange.UseVisualStyleBackColor = true;
			this.btChange.Click += new System.EventHandler(this.btChange_Click);
			// 
			// Auditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(491, 268);
			this.Controls.Add(this.btChange);
			this.Controls.Add(this.btDelAuditor);
			this.Controls.Add(this.btAddAuditor);
			this.Controls.Add(this.DataGridAuditor);
			this.MinimumSize = new System.Drawing.Size(507, 307);
			this.Name = "Auditor";
			this.Text = "Аудитории";
			((System.ComponentModel.ISupportInitialize)(this.DataGridAuditor)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridAuditor;
		private System.Windows.Forms.Button btAddAuditor;
		private System.Windows.Forms.Button btDelAuditor;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameOfAuditor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cafedra;
		private System.Windows.Forms.DataGridViewTextBoxColumn Spacious;
		private System.Windows.Forms.DataGridViewTextBoxColumn Building;
		private System.Windows.Forms.Button btChange;
	}
}