﻿namespace TimetableOfClasses
{
	partial class AcademicTitle
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
			this.DG_AcademicTitle = new System.Windows.Forms.DataGridView();
			this.Add = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DG_AcademicTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// DG_AcademicTitle
			// 
			this.DG_AcademicTitle.AllowUserToAddRows = false;
			this.DG_AcademicTitle.AllowUserToDeleteRows = false;
			this.DG_AcademicTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DG_AcademicTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DG_AcademicTitle.Location = new System.Drawing.Point(12, 12);
			this.DG_AcademicTitle.Name = "DG_AcademicTitle";
			this.DG_AcademicTitle.ReadOnly = true;
			this.DG_AcademicTitle.Size = new System.Drawing.Size(562, 215);
			this.DG_AcademicTitle.TabIndex = 0;
			// 
			// Add
			// 
			this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Add.Location = new System.Drawing.Point(499, 233);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(75, 23);
			this.Add.TabIndex = 1;
			this.Add.Text = "Добавить";
			this.Add.UseVisualStyleBackColor = true;
			// 
			// Delete
			// 
			this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Delete.Location = new System.Drawing.Point(418, 233);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(75, 23);
			this.Delete.TabIndex = 2;
			this.Delete.Text = "Удалить";
			this.Delete.UseVisualStyleBackColor = true;
			// 
			// AcademicTitle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(586, 268);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.DG_AcademicTitle);
			this.Name = "AcademicTitle";
			this.Text = "Ученые звания";
			((System.ComponentModel.ISupportInitialize)(this.DG_AcademicTitle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView DG_AcademicTitle;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.Button Delete;
	}
}