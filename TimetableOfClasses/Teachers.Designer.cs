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
			this.DG.Location = new System.Drawing.Point(12, 12);
			this.DG.Name = "DG";
			this.DG.ReadOnly = true;
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
	}
}