namespace TimetableOfClasses
{
	partial class DirectionOfPreparation
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
			this.dgDirectionOfPreparation = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btAddDirection = new System.Windows.Forms.Button();
			this.btDeleteDirection = new System.Windows.Forms.Button();
			this.btChangeDirection = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgDirectionOfPreparation)).BeginInit();
			this.SuspendLayout();
			// 
			// dgDirectionOfPreparation
			// 
			this.dgDirectionOfPreparation.AllowUserToAddRows = false;
			this.dgDirectionOfPreparation.AllowUserToDeleteRows = false;
			this.dgDirectionOfPreparation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgDirectionOfPreparation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgDirectionOfPreparation.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgDirectionOfPreparation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDirectionOfPreparation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.dgDirectionOfPreparation.Location = new System.Drawing.Point(-1, 0);
			this.dgDirectionOfPreparation.Name = "dgDirectionOfPreparation";
			this.dgDirectionOfPreparation.ReadOnly = true;
			this.dgDirectionOfPreparation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDirectionOfPreparation.Size = new System.Drawing.Size(327, 252);
			this.dgDirectionOfPreparation.TabIndex = 0;
			this.dgDirectionOfPreparation.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgDirectionOfPreparation_RowPrePaint);
			this.dgDirectionOfPreparation.SelectionChanged += new System.EventHandler(this.dgDirectionOfPreparation_SelectionChanged);
			this.dgDirectionOfPreparation.DoubleClick += new System.EventHandler(this.dgDirectionOfPreparation_DoubleClick);
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "CodeOfDP";
			this.Column1.HeaderText = "Код";
			this.Column1.MaxInputLength = 20;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "NameOfDP";
			this.Column2.HeaderText = "Наименование";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "PeriodOfStudy";
			this.Column3.HeaderText = "Срок обучение";
			this.Column3.MaxInputLength = 2;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// btAddDirection
			// 
			this.btAddDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btAddDirection.Location = new System.Drawing.Point(239, 259);
			this.btAddDirection.Name = "btAddDirection";
			this.btAddDirection.Size = new System.Drawing.Size(75, 23);
			this.btAddDirection.TabIndex = 1;
			this.btAddDirection.Text = "Добавить";
			this.btAddDirection.UseVisualStyleBackColor = true;
			this.btAddDirection.Click += new System.EventHandler(this.btAddDirection_Click);
			// 
			// btDeleteDirection
			// 
			this.btDeleteDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btDeleteDirection.Location = new System.Drawing.Point(77, 259);
			this.btDeleteDirection.Name = "btDeleteDirection";
			this.btDeleteDirection.Size = new System.Drawing.Size(75, 23);
			this.btDeleteDirection.TabIndex = 2;
			this.btDeleteDirection.Text = "Удалить";
			this.btDeleteDirection.UseVisualStyleBackColor = true;
			this.btDeleteDirection.Click += new System.EventHandler(this.btDeleteDirection_Click);
			// 
			// btChangeDirection
			// 
			this.btChangeDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btChangeDirection.Location = new System.Drawing.Point(158, 259);
			this.btChangeDirection.Name = "btChangeDirection";
			this.btChangeDirection.Size = new System.Drawing.Size(75, 23);
			this.btChangeDirection.TabIndex = 3;
			this.btChangeDirection.Text = "Изменить";
			this.btChangeDirection.UseVisualStyleBackColor = true;
			this.btChangeDirection.Click += new System.EventHandler(this.btChangeDirection_Click);
			// 
			// DirectionOfPreparation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 284);
			this.Controls.Add(this.btChangeDirection);
			this.Controls.Add(this.btDeleteDirection);
			this.Controls.Add(this.btAddDirection);
			this.Controls.Add(this.dgDirectionOfPreparation);
			this.MinimumSize = new System.Drawing.Size(342, 323);
			this.Name = "DirectionOfPreparation";
			this.Text = "Направление подготовки";
			((System.ComponentModel.ISupportInitialize)(this.dgDirectionOfPreparation)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.DataGridView dgDirectionOfPreparation;
		private System.Windows.Forms.Button btAddDirection;
		private System.Windows.Forms.Button btDeleteDirection;
		private System.Windows.Forms.Button btChangeDirection;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
	}
}