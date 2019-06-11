namespace TimetableOfClasses
{
	partial class AddDirectionOfPreparation
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
			this.label3 = new System.Windows.Forms.Label();
			this.tbCod = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.bt_Cr_n_Close = new System.Windows.Forms.Button();
			this.bt_Cr_n_Cl = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.nuPeriod = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nuPeriod)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(13, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Код направления подготовки";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(276, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Наименование направления подготовки";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Срок обучения в месяцах";
			// 
			// tbCod
			// 
			this.tbCod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbCod.Location = new System.Drawing.Point(12, 41);
			this.tbCod.Name = "tbCod";
			this.tbCod.Size = new System.Drawing.Size(274, 20);
			this.tbCod.TabIndex = 3;
			this.tbCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCod_KeyPress);
			this.tbCod.Leave += new System.EventHandler(this.tbCod_Leave);
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(12, 93);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(274, 20);
			this.tbName.TabIndex = 4;
			// 
			// bt_Cr_n_Close
			// 
			this.bt_Cr_n_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Cr_n_Close.Location = new System.Drawing.Point(191, 177);
			this.bt_Cr_n_Close.Name = "bt_Cr_n_Close";
			this.bt_Cr_n_Close.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bt_Cr_n_Close.Size = new System.Drawing.Size(75, 37);
			this.bt_Cr_n_Close.TabIndex = 13;
			this.bt_Cr_n_Close.Text = "Создать и закрыть";
			this.bt_Cr_n_Close.UseVisualStyleBackColor = true;
			this.bt_Cr_n_Close.Click += new System.EventHandler(this.bt_Cr_n_Close_Click);
			// 
			// bt_Cr_n_Cl
			// 
			this.bt_Cr_n_Cl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Cr_n_Cl.Location = new System.Drawing.Point(110, 177);
			this.bt_Cr_n_Cl.Name = "bt_Cr_n_Cl";
			this.bt_Cr_n_Cl.Size = new System.Drawing.Size(75, 37);
			this.bt_Cr_n_Cl.TabIndex = 12;
			this.bt_Cr_n_Cl.Text = "Создать и очистить";
			this.bt_Cr_n_Cl.UseVisualStyleBackColor = true;
			this.bt_Cr_n_Cl.Click += new System.EventHandler(this.bt_Cr_n_Cl_Click);
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancel.Location = new System.Drawing.Point(26, 177);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(75, 37);
			this.btCancel.TabIndex = 11;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// nuPeriod
			// 
			this.nuPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nuPeriod.Location = new System.Drawing.Point(12, 146);
			this.nuPeriod.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.nuPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nuPeriod.Name = "nuPeriod";
			this.nuPeriod.Size = new System.Drawing.Size(274, 20);
			this.nuPeriod.TabIndex = 14;
			this.nuPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// AddDirectionOfPreparation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 226);
			this.Controls.Add(this.nuPeriod);
			this.Controls.Add(this.bt_Cr_n_Close);
			this.Controls.Add(this.bt_Cr_n_Cl);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbCod);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(311, 265);
			this.Name = "AddDirectionOfPreparation";
			this.Text = "Добавить направление подготовки";
			((System.ComponentModel.ISupportInitialize)(this.nuPeriod)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCod;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Button bt_Cr_n_Close;
		private System.Windows.Forms.Button bt_Cr_n_Cl;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.NumericUpDown nuPeriod;
	}
}