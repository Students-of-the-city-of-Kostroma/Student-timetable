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
			this.Code = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Сокращенная запись уч. звания";
			// 
			// Reduction
			// 
			this.Reduction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Reduction.Location = new System.Drawing.Point(10, 24);
			this.Reduction.Name = "Reduction";
			this.Reduction.Size = new System.Drawing.Size(321, 20);
			this.Reduction.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Полная запись уч. звания";
			// 
			// FullName
			// 
			this.FullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FullName.Location = new System.Drawing.Point(10, 80);
			this.FullName.Name = "FullName";
			this.FullName.Size = new System.Drawing.Size(321, 20);
			this.FullName.TabIndex = 9;
			// 
			// btCancel
			// 
			this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btCancel.Location = new System.Drawing.Point(45, 194);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 37);
			this.btCancel.TabIndex = 10;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// btCreateAndClean
			// 
			this.btCreateAndClean.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btCreateAndClean.Location = new System.Drawing.Point(129, 194);
			this.btCreateAndClean.Name = "btCreateAndClean";
			this.btCreateAndClean.Size = new System.Drawing.Size(75, 37);
			this.btCreateAndClean.TabIndex = 11;
			this.btCreateAndClean.Text = "Создать и очистить";
			this.btCreateAndClean.UseVisualStyleBackColor = true;
			this.btCreateAndClean.Click += new System.EventHandler(this.btCreateAndClean_Click);
			// 
			// btCreateAndClose
			// 
			this.btCreateAndClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btCreateAndClose.Location = new System.Drawing.Point(210, 194);
			this.btCreateAndClose.Name = "btCreateAndClose";
			this.btCreateAndClose.Size = new System.Drawing.Size(75, 37);
			this.btCreateAndClose.TabIndex = 12;
			this.btCreateAndClose.Text = "Создать и закрыть";
			this.btCreateAndClose.UseVisualStyleBackColor = true;
			this.btCreateAndClose.Click += new System.EventHandler(this.btCreateAndClose_Click);
			// 
			// Code
			// 
			this.Code.Location = new System.Drawing.Point(10, 131);
			this.Code.Name = "Code";
			this.Code.Size = new System.Drawing.Size(168, 20);
			this.Code.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Код уч. звания";
			// 
			// AddAcademicTitle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(343, 243);
			this.Controls.Add(this.btCreateAndClean);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Code);
			this.Controls.Add(this.btCreateAndClose);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.FullName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Reduction);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "AddAcademicTitle";
			this.Text = "Добавление уч. звания";
			this.Load += new System.EventHandler(this.AddAcademicTitle_Load);
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
		private System.Windows.Forms.TextBox Code;
		private System.Windows.Forms.Label label3;
	}
}