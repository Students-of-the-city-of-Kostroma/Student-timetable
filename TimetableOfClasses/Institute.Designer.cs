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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Add = new System.Windows.Forms.Button();
			this.Change = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(776, 380);
			this.dataGridView1.TabIndex = 0;
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(674, 398);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(114, 40);
			this.Add.TabIndex = 1;
			this.Add.Text = "Добавить";
			this.Add.UseVisualStyleBackColor = true;
			// 
			// Change
			// 
			this.Change.Location = new System.Drawing.Point(554, 398);
			this.Change.Name = "Change";
			this.Change.Size = new System.Drawing.Size(114, 40);
			this.Change.TabIndex = 2;
			this.Change.Text = "Изменить";
			this.Change.UseVisualStyleBackColor = true;
			// 
			// Delete
			// 
			this.Delete.Location = new System.Drawing.Point(434, 398);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(114, 40);
			this.Delete.TabIndex = 3;
			this.Delete.Text = "Удалить";
			this.Delete.UseVisualStyleBackColor = true;
			// 
			// Institute
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Change);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Institute";
			this.Text = "Институт";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Change;
		private System.Windows.Forms.Button Delete;
	}
}