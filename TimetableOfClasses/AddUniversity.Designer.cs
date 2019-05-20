namespace TimetableOfClasses
{
	partial class AddUniversity
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
			this.lbTitle = new System.Windows.Forms.Label();
			this.tbShortTittle = new System.Windows.Forms.TextBox();
			this.tbFullTitle = new System.Windows.Forms.TextBox();
			this.lbFullTitle = new System.Windows.Forms.Label();
			this.tbActualAddress = new System.Windows.Forms.TextBox();
			this.lbActualAddress = new System.Windows.Forms.Label();
			this.tbLegalAddress = new System.Windows.Forms.TextBox();
			this.lbLegalAddress = new System.Windows.Forms.Label();
			this.tbRectorName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbMail = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btSave = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.tbINN = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbTitle
			// 
			this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbTitle.Location = new System.Drawing.Point(12, 9);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(129, 16);
			this.lbTitle.TabIndex = 20;
			this.lbTitle.Text = "Краткое название";
			// 
			// tbShortTittle
			// 
			this.tbShortTittle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbShortTittle.Location = new System.Drawing.Point(15, 29);
			this.tbShortTittle.MaxLength = 10;
			this.tbShortTittle.Name = "tbShortTittle";
			this.tbShortTittle.Size = new System.Drawing.Size(232, 20);
			this.tbShortTittle.TabIndex = 21;
			this.tbShortTittle.TextChanged += new System.EventHandler(this.TextChanged);
			this.tbShortTittle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShortTitle_KeyPress);
			this.tbShortTittle.Leave += new System.EventHandler(this.tbShortTittle_Leave);
			// 
			// tbFullTitle
			// 
			this.tbFullTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbFullTitle.Location = new System.Drawing.Point(15, 82);
			this.tbFullTitle.MaxLength = 256;
			this.tbFullTitle.Name = "tbFullTitle";
			this.tbFullTitle.Size = new System.Drawing.Size(232, 20);
			this.tbFullTitle.TabIndex = 23;
			this.tbFullTitle.TextChanged += new System.EventHandler(this.TextChanged);
			this.tbFullTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullTitle_KeyPress);
			this.tbFullTitle.Leave += new System.EventHandler(this.tbFullTitle_Leave);
			// 
			// lbFullTitle
			// 
			this.lbFullTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbFullTitle.AutoSize = true;
			this.lbFullTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbFullTitle.Location = new System.Drawing.Point(12, 63);
			this.lbFullTitle.Name = "lbFullTitle";
			this.lbFullTitle.Size = new System.Drawing.Size(125, 16);
			this.lbFullTitle.TabIndex = 22;
			this.lbFullTitle.Text = "Полное название";
			// 
			// tbActualAddress
			// 
			this.tbActualAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbActualAddress.Location = new System.Drawing.Point(15, 139);
			this.tbActualAddress.MaxLength = 256;
			this.tbActualAddress.Name = "tbActualAddress";
			this.tbActualAddress.Size = new System.Drawing.Size(232, 20);
			this.tbActualAddress.TabIndex = 25;
			this.tbActualAddress.TextChanged += new System.EventHandler(this.TextChanged);
			this.tbActualAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbActualAddress_KeyPress);
			this.tbActualAddress.Leave += new System.EventHandler(this.tbActualAddress_Leave);
			// 
			// lbActualAddress
			// 
			this.lbActualAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbActualAddress.AutoSize = true;
			this.lbActualAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbActualAddress.Location = new System.Drawing.Point(12, 120);
			this.lbActualAddress.Name = "lbActualAddress";
			this.lbActualAddress.Size = new System.Drawing.Size(137, 16);
			this.lbActualAddress.TabIndex = 24;
			this.lbActualAddress.Text = "Фактический адрес";
			// 
			// tbLegalAddress
			// 
			this.tbLegalAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLegalAddress.Location = new System.Drawing.Point(15, 194);
			this.tbLegalAddress.MaxLength = 256;
			this.tbLegalAddress.Name = "tbLegalAddress";
			this.tbLegalAddress.Size = new System.Drawing.Size(232, 20);
			this.tbLegalAddress.TabIndex = 27;
			this.tbLegalAddress.TextChanged += new System.EventHandler(this.TextChanged);
			this.tbLegalAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbActualAddress_KeyPress);
			this.tbLegalAddress.Leave += new System.EventHandler(this.tbActualAddress_Leave);
			// 
			// lbLegalAddress
			// 
			this.lbLegalAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbLegalAddress.AutoSize = true;
			this.lbLegalAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbLegalAddress.Location = new System.Drawing.Point(12, 175);
			this.lbLegalAddress.Name = "lbLegalAddress";
			this.lbLegalAddress.Size = new System.Drawing.Size(139, 16);
			this.lbLegalAddress.TabIndex = 26;
			this.lbLegalAddress.Text = "Юридический адрес";
			// 
			// tbRectorName
			// 
			this.tbRectorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRectorName.Location = new System.Drawing.Point(15, 248);
			this.tbRectorName.MaxLength = 256;
			this.tbRectorName.Name = "tbRectorName";
			this.tbRectorName.Size = new System.Drawing.Size(232, 20);
			this.tbRectorName.TabIndex = 29;
			this.tbRectorName.TextChanged += new System.EventHandler(this.TextChanged);
			this.tbRectorName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullTitle_KeyPress);
			this.tbRectorName.Leave += new System.EventHandler(this.tbFullTitle_Leave);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 229);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 16);
			this.label1.TabIndex = 28;
			this.label1.Text = "ФИО ректора";
			// 
			// tbPhone
			// 
			this.tbPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPhone.Location = new System.Drawing.Point(15, 356);
			this.tbPhone.MaxLength = 11;
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(232, 20);
			this.tbPhone.TabIndex = 33;
			this.tbPhone.TextChanged += new System.EventHandler(this.TextChanged);
			this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
			this.tbPhone.Leave += new System.EventHandler(this.tbPhone_Leave);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 337);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 16);
			this.label2.TabIndex = 32;
			this.label2.Text = "Телефон";
			// 
			// tbMail
			// 
			this.tbMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbMail.Location = new System.Drawing.Point(15, 301);
			this.tbMail.MaxLength = 256;
			this.tbMail.Name = "tbMail";
			this.tbMail.Size = new System.Drawing.Size(232, 20);
			this.tbMail.TabIndex = 31;
			this.tbMail.TextChanged += new System.EventHandler(this.fieldChanged);
			this.tbMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMail_KeyPress);
			this.tbMail.Leave += new System.EventHandler(this.tbMail_Leave);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 282);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 16);
			this.label3.TabIndex = 30;
			this.label3.Text = "Почта";
			// 
			// btSave
			// 
			this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btSave.Location = new System.Drawing.Point(164, 468);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(83, 32);
			this.btSave.TabIndex = 34;
			this.btSave.Text = "Сохранить";
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancel.Location = new System.Drawing.Point(81, 468);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(77, 32);
			this.btCancel.TabIndex = 35;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.Cancel);
			// 
			// tbINN
			// 
			this.tbINN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbINN.Location = new System.Drawing.Point(15, 413);
			this.tbINN.MaxLength = 10;
			this.tbINN.Name = "tbINN";
			this.tbINN.Size = new System.Drawing.Size(232, 20);
			this.tbINN.TabIndex = 37;
			this.tbINN.TextChanged += new System.EventHandler(this.TextChanged);
			this.tbINN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
			this.tbINN.Leave += new System.EventHandler(this.tbINN_Leave);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 394);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 16);
			this.label4.TabIndex = 36;
			this.label4.Text = "ИНН";
			// 
			// AddUniversity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 512);
			this.Controls.Add(this.tbINN);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btSave);
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbMail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbRectorName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbLegalAddress);
			this.Controls.Add(this.lbLegalAddress);
			this.Controls.Add(this.tbActualAddress);
			this.Controls.Add(this.lbActualAddress);
			this.Controls.Add(this.tbFullTitle);
			this.Controls.Add(this.lbFullTitle);
			this.Controls.Add(this.tbShortTittle);
			this.Controls.Add(this.lbTitle);
			this.MinimumSize = new System.Drawing.Size(275, 478);
			this.Name = "AddUniversity";
			this.Text = "Добавить Университет";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.TextBox tbShortTittle;
		private System.Windows.Forms.TextBox tbFullTitle;
		private System.Windows.Forms.Label lbFullTitle;
		private System.Windows.Forms.TextBox tbActualAddress;
		private System.Windows.Forms.Label lbActualAddress;
		private System.Windows.Forms.TextBox tbLegalAddress;
		private System.Windows.Forms.Label lbLegalAddress;
		private System.Windows.Forms.TextBox tbRectorName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPhone;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbMail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.TextBox tbINN;
		private System.Windows.Forms.Label label4;
	}
}