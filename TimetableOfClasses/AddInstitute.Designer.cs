﻿namespace TimetableOfClasses
{
	partial class AddInstitute
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
			this.ShortName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.FullName = new System.Windows.Forms.TextBox();
			this.Director = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btCreateAndClose = new System.Windows.Forms.Button();
			this.btCreateAndClean = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Краткое название института";
			// 
			// ShortName
			// 
			this.ShortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ShortName.Location = new System.Drawing.Point(10, 24);
			this.ShortName.Name = "ShortName";
			this.ShortName.Size = new System.Drawing.Size(308, 20);
			this.ShortName.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Полное название института";
			// 
			// FullName
			// 
			this.FullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FullName.Location = new System.Drawing.Point(10, 63);
			this.FullName.Name = "FullName";
			this.FullName.Size = new System.Drawing.Size(308, 20);
			this.FullName.TabIndex = 10;
			// 
			// Director
			// 
			this.Director.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Director.Location = new System.Drawing.Point(10, 101);
			this.Director.Name = "Director";
			this.Director.Size = new System.Drawing.Size(308, 20);
			this.Director.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Директор института";
			// 
			// btCreateAndClose
			// 
			this.btCreateAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCreateAndClose.Location = new System.Drawing.Point(400, 145);
			this.btCreateAndClose.Name = "btCreateAndClose";
			this.btCreateAndClose.Size = new System.Drawing.Size(75, 37);
			this.btCreateAndClose.TabIndex = 13;
			this.btCreateAndClose.Text = "Создать и закрыть";
			this.btCreateAndClose.UseVisualStyleBackColor = true;
			this.btCreateAndClose.Click += new System.EventHandler(this.btCreateAndClose_Click);
			// 
			// btCreateAndClean
			// 
			this.btCreateAndClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCreateAndClean.Location = new System.Drawing.Point(319, 145);
			this.btCreateAndClean.Name = "btCreateAndClean";
			this.btCreateAndClean.Size = new System.Drawing.Size(75, 37);
			this.btCreateAndClean.TabIndex = 14;
			this.btCreateAndClean.Text = "Создать и очистить";
			this.btCreateAndClean.UseVisualStyleBackColor = true;
			this.btCreateAndClean.Click += new System.EventHandler(this.btCreateAndClean_Click);
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancel.Location = new System.Drawing.Point(238, 145);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 37);
			this.btCancel.TabIndex = 15;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// AddInstitute
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 193);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btCreateAndClean);
			this.Controls.Add(this.btCreateAndClose);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Director);
			this.Controls.Add(this.FullName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ShortName);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "AddInstitute";
			this.Text = "Добавление института";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ShortName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox FullName;
		private System.Windows.Forms.TextBox Director;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btCreateAndClose;
		private System.Windows.Forms.Button btCreateAndClean;
		private System.Windows.Forms.Button btCancel;
	}
}