namespace TimetableOfClasses
{
	partial class AddAcademicTitle
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
			this.label1 = new System.Windows.Forms.Label();
			this.Reduction = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.FullName = new System.Windows.Forms.TextBox();
			this.btCancel = new System.Windows.Forms.Button();
			this.btCreateAndClean = new System.Windows.Forms.Button();
			this.btCreateAndClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(221, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Сокращенная запись уч. звания";
			// 
			// Reduction
			// 
			this.Reduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Reduction.Location = new System.Drawing.Point(13, 30);
			this.Reduction.Margin = new System.Windows.Forms.Padding(4);
			this.Reduction.Name = "Reduction";
			this.Reduction.Size = new System.Drawing.Size(409, 22);
			this.Reduction.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 99);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Полная запись уч. звания";
			// 
			// FullName
			// 
			this.FullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FullName.Location = new System.Drawing.Point(13, 120);
			this.FullName.Margin = new System.Windows.Forms.Padding(4);
			this.FullName.Name = "FullName";
			this.FullName.Size = new System.Drawing.Size(409, 22);
			this.FullName.TabIndex = 9;
			// 
			// btCancel
			// 
			this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btCancel.Location = new System.Drawing.Point(93, 166);
			this.btCancel.Margin = new System.Windows.Forms.Padding(4);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(100, 46);
			this.btCancel.TabIndex = 10;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// btCreateAndClean
			// 
			this.btCreateAndClean.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btCreateAndClean.Location = new System.Drawing.Point(205, 166);
			this.btCreateAndClean.Margin = new System.Windows.Forms.Padding(4);
			this.btCreateAndClean.Name = "btCreateAndClean";
			this.btCreateAndClean.Size = new System.Drawing.Size(100, 46);
			this.btCreateAndClean.TabIndex = 11;
			this.btCreateAndClean.Text = "Создать и очистить";
			this.btCreateAndClean.UseVisualStyleBackColor = true;
			this.btCreateAndClean.Click += new System.EventHandler(this.btCreateAndClean_Click);
			// 
			// btCreateAndClose
			// 
			this.btCreateAndClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btCreateAndClose.Location = new System.Drawing.Point(313, 166);
			this.btCreateAndClose.Margin = new System.Windows.Forms.Padding(4);
			this.btCreateAndClose.Name = "btCreateAndClose";
			this.btCreateAndClose.Size = new System.Drawing.Size(100, 46);
			this.btCreateAndClose.TabIndex = 12;
			this.btCreateAndClose.Text = "Создать и закрыть";
			this.btCreateAndClose.UseVisualStyleBackColor = true;
			this.btCreateAndClose.Click += new System.EventHandler(this.btCreateAndClose_Click);
			// 
			// AddAcademicTitle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 225);
			this.Controls.Add(this.btCreateAndClose);
			this.Controls.Add(this.btCreateAndClean);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.FullName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Reduction);
			this.Controls.Add(this.label1);
			this.Name = "AddAcademicTitle";
			this.Text = "Добавление уч. звания";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Reduction;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox FullName;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btCreateAndClean;
		private System.Windows.Forms.Button btCreateAndClose;
	}
}