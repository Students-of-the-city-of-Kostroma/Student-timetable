namespace TimetableOfClasses
{
	partial class AddEnclosures
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
			this.name = new System.Windows.Forms.TextBox();
			this.university = new System.Windows.Forms.TextBox();
			this.address = new System.Windows.Forms.TextBox();
			this.note = new System.Windows.Forms.TextBox();
			this.phoneNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cancel = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.Button();
			this.btAddUniversity = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(12, 32);
			this.name.MaxLength = 50;
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(188, 20);
			this.name.TabIndex = 0;
			this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
			this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
			// 
			// university
			// 
			this.university.Location = new System.Drawing.Point(12, 85);
			this.university.MaxLength = 10;
			this.university.Name = "university";
			this.university.ReadOnly = true;
			this.university.Size = new System.Drawing.Size(188, 20);
			this.university.TabIndex = 1;
			this.university.TextChanged += new System.EventHandler(this.name_TextChanged);
			this.university.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.university_KeyPress);
			this.university.Leave += new System.EventHandler(this.university_Leave);
			// 
			// address
			// 
			this.address.Location = new System.Drawing.Point(12, 168);
			this.address.MaxLength = 255;
			this.address.Name = "address";
			this.address.Size = new System.Drawing.Size(188, 20);
			this.address.TabIndex = 2;
			this.address.TextChanged += new System.EventHandler(this.name_TextChanged);
			this.address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.address_KeyPress);
			// 
			// note
			// 
			this.note.Location = new System.Drawing.Point(12, 280);
			this.note.MaxLength = 256;
			this.note.Name = "note";
			this.note.Size = new System.Drawing.Size(188, 20);
			this.note.TabIndex = 4;
			this.note.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.note_KeyPress);
			// 
			// phoneNumber
			// 
			this.phoneNumber.Location = new System.Drawing.Point(12, 227);
			this.phoneNumber.MaxLength = 11;
			this.phoneNumber.Name = "phoneNumber";
			this.phoneNumber.Size = new System.Drawing.Size(188, 20);
			this.phoneNumber.TabIndex = 3;
			this.phoneNumber.TextChanged += new System.EventHandler(this.name_TextChanged);
			this.phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumber_KeyPress);
			this.phoneNumber.Layout += new System.Windows.Forms.LayoutEventHandler(this.phoneNumber_Layout);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Название корпуса";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "ВУЗ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Адрес";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Телефон";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 264);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Примечание";
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(12, 306);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(91, 32);
			this.cancel.TabIndex = 10;
			this.cancel.Text = "Отмена";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// save
			// 
			this.save.Location = new System.Drawing.Point(109, 306);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(91, 32);
			this.save.TabIndex = 11;
			this.save.Text = "Сохранить";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// btAddUniversity
			// 
			this.btAddUniversity.Location = new System.Drawing.Point(12, 121);
			this.btAddUniversity.Name = "btAddUniversity";
			this.btAddUniversity.Size = new System.Drawing.Size(188, 23);
			this.btAddUniversity.TabIndex = 12;
			this.btAddUniversity.Text = "Добавить ВУЗ";
			this.btAddUniversity.UseVisualStyleBackColor = true;
			this.btAddUniversity.Click += new System.EventHandler(this.btAddUniversity_Click);
			// 
			// AddEnclosures
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(216, 346);
			this.Controls.Add(this.btAddUniversity);
			this.Controls.Add(this.save);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.note);
			this.Controls.Add(this.phoneNumber);
			this.Controls.Add(this.address);
			this.Controls.Add(this.university);
			this.Controls.Add(this.name);
			this.Name = "AddEnclosures";
			this.Text = "AddEnclosures";
			this.Shown += new System.EventHandler(this.AddEnclosures_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox address;
		private System.Windows.Forms.TextBox note;
		private System.Windows.Forms.TextBox phoneNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button btAddUniversity;
		protected internal System.Windows.Forms.TextBox university;
	}
}