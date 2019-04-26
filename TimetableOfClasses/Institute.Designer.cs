namespace TimetableOfClasses
{
	partial class Institute
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
			this.Add = new System.Windows.Forms.Button();
			this.Change = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.DG_Institute = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DG_Institute)).BeginInit();
			this.SuspendLayout();
			// 
			// Add
			// 
			this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Add.Location = new System.Drawing.Point(467, 237);
			this.Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(86, 32);
			this.Add.TabIndex = 1;
			this.Add.Text = "Добавить";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// Change
			// 
			this.Change.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Change.Location = new System.Drawing.Point(377, 237);
			this.Change.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Change.Name = "Change";
			this.Change.Size = new System.Drawing.Size(86, 32);
			this.Change.TabIndex = 2;
			this.Change.Text = "Изменить";
			this.Change.UseVisualStyleBackColor = true;
			// 
			// Delete
			// 
			this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Delete.Location = new System.Drawing.Point(287, 237);
			this.Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(86, 32);
			this.Delete.TabIndex = 3;
			this.Delete.Text = "Удалить";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// DG_Institute
			// 
			this.DG_Institute.AllowUserToAddRows = false;
			this.DG_Institute.AllowUserToDeleteRows = false;
			this.DG_Institute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DG_Institute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DG_Institute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DG_Institute.Location = new System.Drawing.Point(10, 11);
			this.DG_Institute.Name = "DG_Institute";
			this.DG_Institute.ReadOnly = true;
			this.DG_Institute.Size = new System.Drawing.Size(544, 217);
			this.DG_Institute.TabIndex = 4;
			// 
			// Institute
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 280);
			this.Controls.Add(this.DG_Institute);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Change);
			this.Controls.Add(this.Add);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Institute";
			this.Text = "Институт";
			((System.ComponentModel.ISupportInitialize)(this.DG_Institute)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Change;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.DataGridView DG_Institute;
	}
}