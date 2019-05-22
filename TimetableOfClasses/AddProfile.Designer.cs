namespace TimetableOfClasses
{
	partial class AddProfile
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
			this.label2 = new System.Windows.Forms.Label();
			this.tbShortName = new System.Windows.Forms.TextBox();
			this.bt_Cr_n_Close = new System.Windows.Forms.Button();
			this.bt_Cr_n_Cl = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.tbFullName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbCodeSpec = new System.Windows.Forms.TextBox();
			this.btCodeSpec = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(13, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(215, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Шифр направления подготовки";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Краткое название профиля";
			// 
			// tbShortName
			// 
			this.tbShortName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbShortName.Location = new System.Drawing.Point(13, 85);
			this.tbShortName.MaxLength = 40;
			this.tbShortName.Name = "tbShortName";
			this.tbShortName.Size = new System.Drawing.Size(241, 20);
			this.tbShortName.TabIndex = 3;
			// 
			// bt_Cr_n_Close
			// 
			this.bt_Cr_n_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Cr_n_Close.Location = new System.Drawing.Point(177, 175);
			this.bt_Cr_n_Close.Name = "bt_Cr_n_Close";
			this.bt_Cr_n_Close.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_Cr_n_Close.Size = new System.Drawing.Size(75, 37);
			this.bt_Cr_n_Close.TabIndex = 14;
			this.bt_Cr_n_Close.Text = "Создать и закрыть";
			this.bt_Cr_n_Close.UseVisualStyleBackColor = true;
			this.bt_Cr_n_Close.Click += new System.EventHandler(this.bt_Cr_n_Close_Click);
			// 
			// bt_Cr_n_Cl
			// 
			this.bt_Cr_n_Cl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Cr_n_Cl.Location = new System.Drawing.Point(96, 175);
			this.bt_Cr_n_Cl.Name = "bt_Cr_n_Cl";
			this.bt_Cr_n_Cl.Size = new System.Drawing.Size(75, 37);
			this.bt_Cr_n_Cl.TabIndex = 13;
			this.bt_Cr_n_Cl.Text = "Создать и очистить";
			this.bt_Cr_n_Cl.UseVisualStyleBackColor = true;
			this.bt_Cr_n_Cl.Click += new System.EventHandler(this.bt_Cr_n_Cl_Click);
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancel.Location = new System.Drawing.Point(12, 175);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 37);
			this.btCancel.TabIndex = 12;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// tbFullName
			// 
			this.tbFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFullName.Location = new System.Drawing.Point(13, 38);
			this.tbFullName.MaxLength = 40;
			this.tbFullName.Name = "tbFullName";
			this.tbFullName.Size = new System.Drawing.Size(241, 20);
			this.tbFullName.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(186, 16);
			this.label3.TabIndex = 17;
			this.label3.Text = "Полное название профиля";
			// 
			// tbCodeSpec
			// 
			this.tbCodeSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCodeSpec.Location = new System.Drawing.Point(13, 138);
			this.tbCodeSpec.Name = "tbCodeSpec";
			this.tbCodeSpec.ReadOnly = true;
			this.tbCodeSpec.Size = new System.Drawing.Size(158, 20);
			this.tbCodeSpec.TabIndex = 18;
			// 
			// btCodeSpec
			// 
			this.btCodeSpec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btCodeSpec.Location = new System.Drawing.Point(177, 138);
			this.btCodeSpec.Name = "btCodeSpec";
			this.btCodeSpec.Size = new System.Drawing.Size(75, 23);
			this.btCodeSpec.TabIndex = 19;
			this.btCodeSpec.Text = "Выбрать";
			this.btCodeSpec.UseVisualStyleBackColor = true;
			this.btCodeSpec.Click += new System.EventHandler(this.btCodeSpec_Click);
			// 
			// AddProfile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 224);
			this.Controls.Add(this.btCodeSpec);
			this.Controls.Add(this.tbCodeSpec);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbFullName);
			this.Controls.Add(this.bt_Cr_n_Close);
			this.Controls.Add(this.bt_Cr_n_Cl);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.tbShortName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(282, 202);
			this.Name = "AddProfile";
			this.Text = "Добавить профиль ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbShortName;
		private System.Windows.Forms.Button bt_Cr_n_Close;
		private System.Windows.Forms.Button bt_Cr_n_Cl;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.TextBox tbFullName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCodeSpec;
		private System.Windows.Forms.Button btCodeSpec;
	}
}