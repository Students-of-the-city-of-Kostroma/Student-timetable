namespace TimetableOfClasses
{
	partial class AddDiscipline
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
            this.textCodeOfDiscipline = new System.Windows.Forms.TextBox();
            this.textNameOfDiscipline = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCreateAndClean = new System.Windows.Forms.Button();
            this.btCreateAndClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textCodeOfDiscipline
            // 
            this.textCodeOfDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCodeOfDiscipline.Location = new System.Drawing.Point(12, 24);
            this.textCodeOfDiscipline.Name = "textCodeOfDiscipline";
            this.textCodeOfDiscipline.Size = new System.Drawing.Size(338, 20);
            this.textCodeOfDiscipline.TabIndex = 0;
            // 
            // textNameOfDiscipline
            // 
            this.textNameOfDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNameOfDiscipline.Location = new System.Drawing.Point(12, 63);
            this.textNameOfDiscipline.Name = "textNameOfDiscipline";
            this.textNameOfDiscipline.Size = new System.Drawing.Size(338, 20);
            this.textNameOfDiscipline.TabIndex = 1;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancel.Location = new System.Drawing.Point(26, 107);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 37);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btCreateAndClean
            // 
            this.btCreateAndClean.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCreateAndClean.Location = new System.Drawing.Point(143, 107);
            this.btCreateAndClean.Name = "btCreateAndClean";
            this.btCreateAndClean.Size = new System.Drawing.Size(75, 37);
            this.btCreateAndClean.TabIndex = 3;
            this.btCreateAndClean.Text = "Создать и очистить";
            this.btCreateAndClean.UseVisualStyleBackColor = true;
            this.btCreateAndClean.Click += new System.EventHandler(this.btCreateAndClean_Click);
            // 
            // btCreateAndClose
            // 
            this.btCreateAndClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCreateAndClose.Location = new System.Drawing.Point(260, 107);
            this.btCreateAndClose.Name = "btCreateAndClose";
            this.btCreateAndClose.Size = new System.Drawing.Size(75, 37);
            this.btCreateAndClose.TabIndex = 4;
            this.btCreateAndClose.Text = "Создать и закрыть";
            this.btCreateAndClose.UseVisualStyleBackColor = true;
            this.btCreateAndClose.Click += new System.EventHandler(this.btCreateAndClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Шифр дисциплины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Наименование дисциплины";
            // 
            // AddDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCreateAndClose);
            this.Controls.Add(this.btCreateAndClean);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.textNameOfDiscipline);
            this.Controls.Add(this.textCodeOfDiscipline);
            this.MinimumSize = new System.Drawing.Size(378, 194);
            this.Name = "AddDiscipline";
            this.Text = "AddDiscipline";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textCodeOfDiscipline;
		private System.Windows.Forms.TextBox textNameOfDiscipline;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btCreateAndClean;
		private System.Windows.Forms.Button btCreateAndClose;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}