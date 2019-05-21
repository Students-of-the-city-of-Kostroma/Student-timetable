namespace TimetableOfClasses
{
	partial class AddAuditor
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
			this.tbAuditor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbKaf = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.nuPlaces = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.tbCorpus = new System.Windows.Forms.TextBox();
			this.btCancel = new System.Windows.Forms.Button();
			this.bt_Cr_n_Cl = new System.Windows.Forms.Button();
			this.bt_Cr_n_Close = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nuPlaces)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Аудитория";
			// 
			// tbAuditor
			// 
			this.tbAuditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAuditor.Location = new System.Drawing.Point(13, 33);
			this.tbAuditor.Name = "tbAuditor";
			this.tbAuditor.Size = new System.Drawing.Size(241, 20);
			this.tbAuditor.TabIndex = 1;
			this.tbAuditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAuditor_KeyPress);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(13, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Кафедра";
			// 
			// tbKaf
			// 
			this.tbKaf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbKaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbKaf.Location = new System.Drawing.Point(13, 84);
			this.tbKaf.Name = "tbKaf";
			this.tbKaf.Size = new System.Drawing.Size(241, 22);
			this.tbKaf.TabIndex = 3;
			this.tbKaf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKaf_KeyPress);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(13, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Число мест";
			// 
			// nuPlaces
			// 
			this.nuPlaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nuPlaces.Location = new System.Drawing.Point(13, 149);
			this.nuPlaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nuPlaces.Name = "nuPlaces";
			this.nuPlaces.Size = new System.Drawing.Size(241, 20);
			this.nuPlaces.TabIndex = 5;
			this.nuPlaces.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(13, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Корпус";
			// 
			// tbCorpus
			// 
			this.tbCorpus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCorpus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbCorpus.Location = new System.Drawing.Point(13, 201);
			this.tbCorpus.Name = "tbCorpus";
			this.tbCorpus.Size = new System.Drawing.Size(241, 22);
			this.tbCorpus.TabIndex = 7;
			this.tbCorpus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCorpus_KeyPress);
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancel.Location = new System.Drawing.Point(12, 262);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 37);
			this.btCancel.TabIndex = 8;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// bt_Cr_n_Cl
			// 
			this.bt_Cr_n_Cl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Cr_n_Cl.Location = new System.Drawing.Point(96, 262);
			this.bt_Cr_n_Cl.Name = "bt_Cr_n_Cl";
			this.bt_Cr_n_Cl.Size = new System.Drawing.Size(75, 37);
			this.bt_Cr_n_Cl.TabIndex = 9;
			this.bt_Cr_n_Cl.Text = "Создать и очистить";
			this.bt_Cr_n_Cl.UseVisualStyleBackColor = true;
			this.bt_Cr_n_Cl.Click += new System.EventHandler(this.bt_Cr_n_Cl_Click);
			// 
			// bt_Cr_n_Close
			// 
			this.bt_Cr_n_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Cr_n_Close.Location = new System.Drawing.Point(177, 262);
			this.bt_Cr_n_Close.Name = "bt_Cr_n_Close";
			this.bt_Cr_n_Close.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_Cr_n_Close.Size = new System.Drawing.Size(75, 37);
			this.bt_Cr_n_Close.TabIndex = 10;
			this.bt_Cr_n_Close.Text = "Создать и закрыть";
			this.bt_Cr_n_Close.UseVisualStyleBackColor = true;
			this.bt_Cr_n_Close.Click += new System.EventHandler(this.bt_Cr_n_Close_Click);
			// 
			// AddAuditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 311);
			this.Controls.Add(this.bt_Cr_n_Close);
			this.Controls.Add(this.bt_Cr_n_Cl);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.tbCorpus);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nuPlaces);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbKaf);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbAuditor);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(282, 350);
			this.MinimumSize = new System.Drawing.Size(282, 350);
			this.Name = "AddAuditor";
			this.Text = "Добавить аудиторию";
			((System.ComponentModel.ISupportInitialize)(this.nuPlaces)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbAuditor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbKaf;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nuPlaces;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbCorpus;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button bt_Cr_n_Cl;
		private System.Windows.Forms.Button bt_Cr_n_Close;
	}
}