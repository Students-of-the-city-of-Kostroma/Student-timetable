namespace TimetableOfClasses
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.ShortName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.FullName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btCreateAndClose = new System.Windows.Forms.Button();
			this.btCreateAndClean = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.VUS = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Director = new System.Windows.Forms.ComboBox();
			this.Open_Teacher = new System.Windows.Forms.Button();
			this.Open_University = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Краткое название института";
			// 
			// ShortName
			// 
			this.ShortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ShortName.Location = new System.Drawing.Point(13, 30);
			this.ShortName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ShortName.Name = "ShortName";
			this.ShortName.Size = new System.Drawing.Size(381, 22);
			this.ShortName.TabIndex = 8;
			this.ShortName.TextChanged += new System.EventHandler(this.ShortName_TextChanged);
			this.ShortName.Validating += new System.ComponentModel.CancelEventHandler(this.ShortName_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 57);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(195, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Полное название института";
			// 
			// FullName
			// 
			this.FullName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FullName.Location = new System.Drawing.Point(13, 78);
			this.FullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.FullName.Name = "FullName";
			this.FullName.Size = new System.Drawing.Size(381, 22);
			this.FullName.TabIndex = 10;
			this.FullName.TextChanged += new System.EventHandler(this.FullName_TextChanged);
			this.FullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullName_Keypress);
			this.FullName.Validating += new System.ComponentModel.CancelEventHandler(this.FullName_Validating);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 103);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Директор института";
			// 
			// btCreateAndClose
			// 
			this.btCreateAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCreateAndClose.Location = new System.Drawing.Point(307, 307);
			this.btCreateAndClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btCreateAndClose.Name = "btCreateAndClose";
			this.btCreateAndClose.Size = new System.Drawing.Size(100, 46);
			this.btCreateAndClose.TabIndex = 13;
			this.btCreateAndClose.Text = "Создать и закрыть";
			this.btCreateAndClose.UseVisualStyleBackColor = true;
			this.btCreateAndClose.Click += new System.EventHandler(this.btCreateAndClose_Click);
			// 
			// btCreateAndClean
			// 
			this.btCreateAndClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCreateAndClean.Location = new System.Drawing.Point(199, 306);
			this.btCreateAndClean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btCreateAndClean.Name = "btCreateAndClean";
			this.btCreateAndClean.Size = new System.Drawing.Size(100, 46);
			this.btCreateAndClean.TabIndex = 14;
			this.btCreateAndClean.Text = "Создать и очистить";
			this.btCreateAndClean.UseVisualStyleBackColor = true;
			this.btCreateAndClean.Click += new System.EventHandler(this.btCreateAndClean_Click);
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancel.Location = new System.Drawing.Point(91, 306);
			this.btCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(100, 46);
			this.btCancel.TabIndex = 15;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// VUS
			// 
			this.VUS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.VUS.FormattingEnabled = true;
			this.VUS.Location = new System.Drawing.Point(13, 213);
			this.VUS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.VUS.Name = "VUS";
			this.VUS.Size = new System.Drawing.Size(381, 24);
			this.VUS.TabIndex = 16;
			this.VUS.SelectedValueChanged += new System.EventHandler(this.VUS_SelectedValueChanged);
			this.VUS.Validating += new System.ComponentModel.CancelEventHandler(this.VUS_Validating);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 193);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 17);
			this.label4.TabIndex = 17;
			this.label4.Text = "ВУЗ";
			// 
			// Director
			// 
			this.Director.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Director.FormattingEnabled = true;
			this.Director.Location = new System.Drawing.Point(13, 126);
			this.Director.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Director.Name = "Director";
			this.Director.Size = new System.Drawing.Size(381, 24);
			this.Director.TabIndex = 18;
			this.Director.SelectedValueChanged += new System.EventHandler(this.Director_SelectedValueChanged);
			this.Director.Validating += new System.ComponentModel.CancelEventHandler(this.Director_Validating);
			// 
			// Open_Teacher
			// 
			this.Open_Teacher.Location = new System.Drawing.Point(13, 160);
			this.Open_Teacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Open_Teacher.Name = "Open_Teacher";
			this.Open_Teacher.Size = new System.Drawing.Size(383, 28);
			this.Open_Teacher.TabIndex = 19;
			this.Open_Teacher.Text = "Добавить";
			this.Open_Teacher.UseVisualStyleBackColor = true;
			this.Open_Teacher.Click += new System.EventHandler(this.Open_Teacher_Click);
			// 
			// Open_University
			// 
			this.Open_University.Location = new System.Drawing.Point(13, 246);
			this.Open_University.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Open_University.Name = "Open_University";
			this.Open_University.Size = new System.Drawing.Size(379, 28);
			this.Open_University.TabIndex = 20;
			this.Open_University.Text = "Добавить ВУЗ";
			this.Open_University.UseVisualStyleBackColor = true;
			this.Open_University.Click += new System.EventHandler(this.Open_University_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// AddInstitute
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 366);
			this.Controls.Add(this.Open_University);
			this.Controls.Add(this.Open_Teacher);
			this.Controls.Add(this.Director);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.VUS);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btCreateAndClean);
			this.Controls.Add(this.btCreateAndClose);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.FullName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ShortName);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "AddInstitute";
			this.Text = "Добавление института";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ShortName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox FullName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btCreateAndClose;
		private System.Windows.Forms.Button btCreateAndClean;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.ComboBox VUS;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox Director;
		private System.Windows.Forms.Button Open_Teacher;
		private System.Windows.Forms.Button Open_University;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}