namespace TimetableOfClasses
{
	partial class AddOrEditDirectory
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.btCancel = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.btClose = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 261);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
			this.flowLayoutPanel1.Controls.Add(this.btCancel);
			this.flowLayoutPanel1.Controls.Add(this.btClear);
			this.flowLayoutPanel1.Controls.Add(this.btClose);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 44);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// btCancel
			// 
			this.btCancel.Location = new System.Drawing.Point(3, 3);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 37);
			this.btCancel.TabIndex = 0;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// btClear
			// 
			this.btClear.Location = new System.Drawing.Point(84, 3);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(75, 37);
			this.btClear.TabIndex = 1;
			this.btClear.Text = "Создать и очистить";
			this.btClear.UseVisualStyleBackColor = true;
			// 
			// btClose
			// 
			this.btClose.Location = new System.Drawing.Point(165, 3);
			this.btClose.Name = "btClose";
			this.btClose.Size = new System.Drawing.Size(75, 37);
			this.btClose.TabIndex = 2;
			this.btClose.Text = "Создать и закрыть";
			this.btClose.UseVisualStyleBackColor = true;
			// 
			// AddOrEditDirectory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(250, 261);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MinimumSize = new System.Drawing.Size(266, 300);
			this.Name = "AddOrEditDirectory";
			this.Text = "Добавить запись";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Button btClose;
	}
}